var ContactService = function() {

    var send = function(message, success, error) {
        $.ajax({
            method: "POST",
            url: "/api/message",
            data: message,
            success: success,
            error: error
        });
    };

    return {
        send: send
    };

}();