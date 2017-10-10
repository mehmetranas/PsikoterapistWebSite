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
    return {
        delete: deleteAction,
        read: readAction
    }
}();