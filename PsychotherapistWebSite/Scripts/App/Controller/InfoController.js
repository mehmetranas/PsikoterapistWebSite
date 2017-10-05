var InfoController = function() {

    var save = function () {
        $("input.js-save").on("click",
            function(e) {
                var data = {
                    personName: $("#js-name").val(),
                    personTitle: $("#js-title").val(),
                    adressId: $("#js-adressId").val(),
                    phone: $("#js-phone").val(),
                    facebookUrl: $("#js-facebook").val(),
                    youtubeUrl: $("#js-youtube").val(),
                    tweeterUrl: $("#js-tweeter").val(),
                    aboutme: $("#js-aboutme").val(),
                    imagesId: [
                        $("#js-image1Id").val(), $("#js-image2Id").val()
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