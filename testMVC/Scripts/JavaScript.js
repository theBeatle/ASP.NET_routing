$(function () {
    $("button").click(function () {
        let loginV = $('#login').val();
        let passwordV = $('#password').val();
        let myUrl = `http://localhost:12294/Home/Registration/${loginV}/${passwordV}`;
        $.ajax({
            async: false,
            method: "GET",
            url: myUrl,
            success: function (data) {
                //TODO: reload page
                alert('ok');
            },
            error: function () {
                alert(' error');
            } 
        });
    });
});