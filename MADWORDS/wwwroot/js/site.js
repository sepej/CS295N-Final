// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#submitbtn").on("click", function () {
    var a = '';
    $('.word').each(function () {
        a += this.value+",";
    });
    $('#words').val(a);
}
);