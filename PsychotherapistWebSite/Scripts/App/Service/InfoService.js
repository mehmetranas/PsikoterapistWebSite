var InfoService = function() {

    var save = function(data, success, error) {
        $.ajax({
            method:"POST",
            url: "/api/info/",
            data: data,
            success: success,
            error: error
        });
    }

    return {
        save: save
    }
}();