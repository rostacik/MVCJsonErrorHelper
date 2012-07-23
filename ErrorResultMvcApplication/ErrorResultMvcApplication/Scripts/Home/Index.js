$(document).ready(function () {
    $("#sendButton").click(function () {
        ajaxRequest();
    });
});

function ajaxRequest() {
    $.ajax({
        url: 'Home/RequestTest',
        type: "POST",
        cache: false,
        data: { id: $("#valueInput").val() },
        dataType: 'json',
        success: function (data) {
            showAjaxResult(data);
        },
        error: function (data) {
            var parsedResponse = $.parseJSON(data.responseText);
            showAjaxResult(parsedResponse);
        }
    });
}

function showAjaxResult(data) {
    alert(data.responseText);
}