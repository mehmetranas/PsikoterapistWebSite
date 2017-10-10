var MessageService = function() {

    var deleteAction = function(id, success, error) {
        $.ajax({
            method: "DELETE",
            url: "/api/message/" + id,
            success: success,
            error: error
    });
    };

    return {
        delete: deleteAction
    }
}();