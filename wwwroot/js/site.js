// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var gmt = 3;

$("#cf-3").on("change", function () {
    var rentSelected = $("#cf-3").val();
    var date = new Date(rentSelected);
    date.setHours(date.getHours() + gmt + 1);
    var value = date.toISOString();
    value = value.substring(0, value.length - 8);
    $("#cf-4").attr("min", value);
});


$(window).bind("pageshow", function () {
    var input1 = $('#cf-3');
    var input2 = $('#cf-4');
    input1.val("");
    input2.val("");
});

