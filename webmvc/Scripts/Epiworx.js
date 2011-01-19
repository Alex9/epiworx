﻿$(function () {
    $("#sidebar .part li").each(function () {
        $(this).click(function () {
            var link = $(this).find("a");
            if (link != undefined) {
                window.location = link.attr("href");
            }
        });
    });

    $("#main .list tr").each(function () {
        $(this).click(function () {
            var link = $(this).find("a");
            if (link != undefined) {
                window.location = link.attr("href");
            }
        });
    });

    $("#main .list li").each(function () {
        $(this).click(function () {
            var link = $(this).find("a");
            if (link != undefined) {
                window.location = link.attr("href");
            }
        });
    });
});

$(function () {
    $(".date").datepicker({
        showButtonPanel: true,
        prevText: "<<",
        nextText: ">>"
    });
    $("ul li:first").css("class", "first");
    $("ul li:last").css("class", "last");
    $("#main .list li a").parent("li").css("cursor", "pointer");
    $("#main .list td a").parent("td").parent("tr").css("cursor", "pointer");
    $("#sidebar .part a").parent("li").css("cursor", "pointer");
});

$(function () {

    $("#filter .filter-value-multiple .filter-value-multiple-container").hide();

    $("#filter .filter-value-multiple .filter-value-multiple-container a").click(function () {
        $(this).parent().parent().parent().parent().hide();
    });

    $("#filter .filter-value-multiple strong").click(function () {
        $("#filter .filter-value-multiple-container").hide();
        $(this).siblings(".filter-value-multiple-container:first").show();
    });

    $("#filter .filter-value-single select").hide();

    $("#filter .filter-value-single strong").html(function () {
        return $(this).next().find(":selected").text();
    })

    $("#filter .filter-value-single strong").click(function () {
        $("#filter select").hide();
        $("#filter .filter-value-multiple-container").hide();
        $(this).hide();
        $(this).siblings("select:first").show();
    });
});

