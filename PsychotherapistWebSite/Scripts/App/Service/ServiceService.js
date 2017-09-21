var ServiceService = function () {
    var request = function (method, data, success, error) {
        $.ajax({
            method: method,
            url: "/api/service",
            data: data,
            success: success,
            error: error
        });
    }

    var deleteService = function (id) {
        var success = function() {
            $("tr#" + id).animateCss("fadeOutUp");
        };

        var error = function(textStatus) {
            console.log(textStatus);
        };

        request("delete", id, success, error);
    };

    var saveService = function () {
        var data = {
            id: $("#service-id").val(),
            name: $(".js-form input").val(),
            content: $(".js-form textarea").val()
        };

        var success = function() {
            bootbox.alert({
                size: "small",
                buttons: {
                    ok: {
                        label: "Tamam",
                        className: "btn btn-success"
                    }
                },
                message: "Yeni Alan başarı ile eklendi.",
                callback: function() {
                    window.location.href = "/user/admin";
                }
            });
        };

        var error = function (textStatus) {
                console.log(textStatus);
                }

        request("post", data, success, error);
    };

    var editService = function () {

        var data = {
            id: $("#service-id").val(),
            name: $(".js-form input").val(),
            content: $(".js-form textarea").val()
        };

        var success = function () {
            bootbox.alert({
                size: "small",
                buttons: {
                    ok: {
                        label: "Tamam",
                        className: "btn btn-success"
                    }
                },
                message: "Güncellendi.",
                callback: function () {
                    window.location.href = "/user/admin";
                }
            });
        };

        var error = function (textStatus) {
            console.log(textStatus);
        }

        request("put", data, success, error);
    }

    return {
        delete: deleteService,
        saveService: saveService,
        editService: editService
}
}();