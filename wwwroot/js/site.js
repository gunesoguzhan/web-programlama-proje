// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var date = new Date();
var year = date.getFullYear();
var month = date.getMonth() + 1;
var day = date.getDate();
var hour = date.getHours();
var minute = date.getMinutes() + 10;

var rentMin = year + "-" + month + "-" + day + "T" + hour + ":" + minute;

$("#cf-3").attr("min", rentMin);

$("#cf-3").on("change", function () {
    var rentSelected = $("#cf-3").val();
    var returnMin = parseDate(rentSelected);
    $("#cf-4").attr("min", returnMin);
});

function parseDate(value) {
    const array = value.split("-");
    var y = array[0];
    var m = array[1];
    const array2 = array[2].split("T");
    var d = array2[0];
    const array3 = array2[1].split(":");
    var h = array3[0];
    var M = array3[1];
    h++;
    return y + "-" + m + "-" + d + "T" + h + ":" + M;
}

$(window).bind("pageshow", function () {
    var input1 = $('#cf-3');
    var input2 = $('#cf-4');
    input1.val("");
    input2.val("");
});
