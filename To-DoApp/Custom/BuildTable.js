$(document).ready(function () {
    $.ajax({
        url: '/Tasks/BuildToDoTable',

        success: function (result) {
            $('#tableDiv').html(result);
        }

    })


});