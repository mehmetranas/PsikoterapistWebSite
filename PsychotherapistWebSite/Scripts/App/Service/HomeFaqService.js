var HomeFaqService = function() {
    var action = function(method, id, success, error) {
        $.ajax({
            method: method,
            url: "/api/homefaq/" + id,
            success: success,
            error: error
        });
    }

    return {
        action: action
    }
}();