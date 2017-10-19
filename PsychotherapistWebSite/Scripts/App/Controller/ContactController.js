var ContactController = function() {

    var send = function() {
        $("#contact-btn").click(function () {
            var isValid = $("#contactform").valid();
            if (isValid === false) return;
            var message = {
                    Id: 0,
                    Name: $("#name").val(),
                    Email: $("#email").val(),
                    Title: $("#title").val(),
                    MessageText: $("#messageText").val(),
                    IsRead: false,
                    DateTime: null
                };

            var success = function () {
                $("#validation").show().addClass("alert alert-success").text("Teşekkürler, mesajınz iletildi");
                $("#contactform")[0].reset();
                setTimeout(function() {
                    $("#validation").animateHide("fadeOut");
                },5000);
            };

            var error = function (xhr) {
                console.log(xhr);
                $("#validation").show().addClass("alert alert-warning").text("Üzgünüm! Mesajınız iletilemedi, lütfen daha sonra tekrar deneyiniz.");
                setTimeout(function () {
                    $("#validation").animateHide("fadeOut");
                }, 3000);

                };
                ContactService.send(message, success, error);
        });
    };

    return {
        send: send
    }
}();