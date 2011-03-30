﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div id="menu">
    <ul>
        <%
            if (this.Request.IsAuthenticated)
            {
        %>
        <li>
            <%: this.Html.ActionLink("Sign Out", "LogOff", "Account")%></li>
        <li class="separator">|</li>
        <li>
            <%: this.Html.ActionLink("Settings", "Settings", "Home")%></li>
        <%
            }
        %>
    </ul>
</div>
