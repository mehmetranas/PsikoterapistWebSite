var MessageService = function() {

    var deleteAction = function(id, success, error) {
        $.ajax({
            method: "DELETE",
            url: "/api/message/" + id,
            success: success,
            error: error
    });
    };

    var readAction = function(id, success, fail) {
        $.post("/api/message/" + id).done(success).fail(fail);
    }

    var getUnReadMessageCount = function () {
        $.get("/api/message",
            function (data) {
                if (data > 0) {
                    $("span.notification").show().text("(" + data + ")");
                }
            });
    }

    return {
        delete: deleteAction,
        read: readAction,
        getUnReadMessageCount: getUnReadMessageCount
    }
}();