// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#submitbtn").on("click", function () {
    var completedMadword = stories.story[1].text;
    $('.word').each(function () {
        completedMadword = completedMadword.replace('*', this.value);
        //a += this.value + ",";
    });
    $('#words').val(completedMadword);
}
);