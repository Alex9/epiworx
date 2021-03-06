﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using Epiworx.Business;
using Epiworx.Service;
using Epiworx.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Epiworx.Security;

namespace Epiworx.Tests
{
    [TestClass]
    public class CategoryTestsWithRoleReview
    {
        public static string UserName { get; set; }
        public static string UserPassword { get; set; }

        public CategoryTestsWithRoleReview()
        {

        }

        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            CategoryTestsWithRoleReview.UserName = DataHelper.RandomString(20);
            CategoryTestsWithRoleReview.UserPassword = DataHelper.RandomString(20);

            BusinessHelper.CreateUserWithReview(
                CategoryTestsWithRoleReview.UserName,
                CategoryTestsWithRoleReview.UserPassword);
        }

        [ClassCleanup]
        public static void MyClassCleanup()
        {
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            BusinessPrincipal.Login(
                CategoryTestsWithRoleReview.UserName,
                CategoryTestsWithRoleReview.UserPassword);
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            BusinessPrincipal.Logout();
        }

        [TestMethod]
        public void Category_New()
        {
            Exception exception = null;

            try
            {
                CategoryService.CategoryNew();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception != null, "Exception should not be null");
            Assert.IsTrue(exception.GetBaseException() is SecurityException);
        }

        [TestMethod]
        public void Category_Edit()
        {
            var category = BusinessHelper.CreateCategoryAndLogon(
                CategoryTestsWithRoleReview.UserName, CategoryTestsWithRoleReview.UserPassword);

            Exception exception = null;

            try
            {
                category = CategoryService.CategoryFetch(category.CategoryId);

                category.Name = DataHelper.RandomString(20);

                CategoryService.CategorySave(category);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception != null, "Exception should not be null");
            Assert.IsTrue(exception.GetBaseException() is SecurityException);
        }

        [TestMethod]
        public void Category_Delete()
        {
            var category = BusinessHelper.CreateCategoryAndLogon(
                 CategoryTestsWithRoleReview.UserName, CategoryTestsWithRoleReview.UserPassword);

            Exception exception = null;

            try
            {
                CategoryService.CategoryDelete(category.CategoryId);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception != null, "Exception should not be null");
            Assert.IsTrue(exception.GetBaseException() is SecurityException);
        }

        [TestMethod]
        public void Category_Fetch()
        {
            Exception exception = null;

            var category = BusinessHelper.CreateCategoryAndLogon(
                 CategoryTestsWithRoleReview.UserName, CategoryTestsWithRoleReview.UserPassword);

            try
            {
                CategoryService.CategoryFetch(category.CategoryId);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception == null, "Exception should be null");
        }

        [TestMethod]
        public void Category_Fetch_List()
        {
            Exception exception = null;

            BusinessHelper.CreateCategoryAndLogon(
                 CategoryTestsWithRoleReview.UserName, CategoryTestsWithRoleReview.UserPassword);

            BusinessHelper.CreateCategoryAndLogon(
                 CategoryTestsWithRoleReview.UserName, CategoryTestsWithRoleReview.UserPassword);

            try
            {
                CategoryService.CategoryFetchInfoList();
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsTrue(exception == null, "Exception should be null");
        }
    }
}
