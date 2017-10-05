var ServiceService = function () {
    var request = function (method, data, success, error) {
        $.ajax({
            method: method,
            url: "/api/service",
            data: data,
            contentType: "application/json",
            success: success,
            error: error
        });
    }

    var deleteService = function (id) {
        var success = function() {
            $("tr#" + id).animateCss("fadeOutUp").remove();
        };

        var error = function(textStatus) {
            console.log(textStatus);
        };

        request("delete", id, success, error);
    };

    var saveService = function () {
        var data = JSON.stringify({
            id: $("#service-id").val(),
            name: $(".js-form input").val(),
            content: $(".js-form textarea").val(),
            ImageId1: $(".js-form .js-image1").val(),
            ImageId2: $(".js-form .js-image2").val()
        });

        var success = function() {
            bootbox.alert(BootboxController.add("/user/service"));
        };

        var error = function (textStatus) {
                console.log(textStatus);
                }

        request("post", data, success, error);
    };

    var editService = function () {

        var data = JSON.stringify({
            id: $("#service-id").val(),
            name: $(".js-form input").val(),
            content: $(".js-form textarea").val(),
            ImageId1: $(".js-form .js-image1").val(),
            ImageId2: $(".js-form .js-image2").val()
        });

        var success = function () {
            bootbox.alert(BootboxController.save("/user/service"));
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