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

    var counter = function () {
        $(".js-counter").html(1000 - $(".js-form textarea").val().length);
        
        $(".js-form textarea").on("input DOMContentLoaded",
            function() {
                var length = $(".js-form textarea").val().length;
                var counter = 1000 - length;
                $(".js-counter").html(counter);
                if (counter < 0) {
                    $(".js-counter").css({ "color": "red" });
                } else {
                    $(".js-counter").css({ "color": "black" });
                }
            });
    }

    return {
        deleteService: deleteService,
        saveService: saveService,
        cancel: cancel,
        counter: counter
    }
}();