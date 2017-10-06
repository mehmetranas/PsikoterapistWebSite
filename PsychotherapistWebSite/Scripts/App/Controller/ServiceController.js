var ServiceController = function () {
    var deleteService = function () {
        $(".js-service-delete").on("click", function (e) {
            var id = $(e.target).attr("id");

            bootbox.confirm(BootboxController.delete(id));
        });
    };
    
    var saveService = function() {
        $("button.js-service-save").click(function (e) {
            $("form.js-service").validate();
            if (!$("form.js-service").valid()) {
                var count = 1000 - $(".js-form textarea").val().length;
                if (count < 0) {
                    bootbox.alert("Açıklama bölümü daha kısa tutun");
                } else {
                    bootbox.alert("Sanırım Alan Adını ve/veya Alan Açıklamasını boş bıraktın");
                }
                return;
            }
            
            var method = $(e.target).attr("data-type");
            if (method === "Save") {
                ServiceService.saveService();
            } else if (method === "Edit") {
                ServiceService.editService();
            }
        });
    };

    var cancel = function () {
        $("button.js-service-cancel").click(function() {
            window.location.href = "/user/service";
        });
    }


    return {
        deleteService: deleteService,
        saveService: saveService,
        cancel: cancel
    }
}();