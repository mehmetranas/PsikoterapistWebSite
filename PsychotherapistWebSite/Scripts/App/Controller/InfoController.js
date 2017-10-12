var InfoController = function() {

    var save = function () {
        $("input.js-save").on("click",
            function() {
                var data = {
                    personName: $("#js-name").val(),
                    personTitle: $("#js-title").val(),
                    adressId: $("#js-adressId").val(),
                    mail: $("#js-mail").val(),
                    phone: $("#js-phone").val(),
                    facebookUrl: $("#js-facebook").val(),
                    youtubeUrl: $("#js-youtube").val(),
                    tweeterUrl: $("#js-tweeter").val(),
                    aboutme: $("#js-aboutme").val(),
                    mail: $("#js-email").val(),
                    imagesId: [
                        $("#js-image1Id").val(),
                        $("#js-image2Id").val(),
                        $("#js-image3Id").val()
                    ]
                }

                var success = function () {
                    bootbox.alert(BootboxController.save("/user/info"));
                };

                var error = function() {
                    console.log("Error");
                };

                InfoService.save(data, success, error);

            });
    }

    return {
        save: save
    }
}();