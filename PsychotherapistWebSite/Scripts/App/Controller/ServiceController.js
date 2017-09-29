var ServiceController = function () {
    var deleteService = function () {
        $(".js-service-delete").on("click", function (e) {
            bootbox.confirm({
                size: "small",
                buttons: {
                    confirm: {
                        label: "Evet",
                        className:"btn btn-danger"
                    },
                    cancel: {
                        label: "İptal",
                        className:"btn btn-default"
                    }
                },
                message: "Silmek istediğinizden emin misiniz?",
                callback: function (result) {
                    if (result) {
                        var id = $(e.target).attr("id");
                        ServiceService.delete(id);
                    }
                }
            });
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