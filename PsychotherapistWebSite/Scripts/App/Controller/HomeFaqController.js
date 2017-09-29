var HomeFaqController = function () {

    var add = function (id) {
        var method = "POST";
        var success = function () {
            $("#" + id).animateCss("jello").toggleClass("fa-star fa-star-o");
        };
        var error = function (data) {
            console.log(data);
        };
        HomeFaqService.action(method, id, success, error);

    }

    var remove = function (id) {
        var method = "DELETE";
        var success = function () {
            $("#" + id).toggleClass("fa-star fa-star-o");
        };
        var error = function (data) {
            console.log(data);
        };
        HomeFaqService.action(method, id, success, error);

    }

    var action = function () {
        $("i.js-actionFaq").on("click", function (e) {
            
            var id = $(e.target).attr("id");

            if ($(e.target).hasClass("fa-star-o")) {
                if ($("i.fa-star").length >= 2) {
                    bootbox.alert({
                        message: "İki sorudan fazlası seçemezsin.",
                        size: "small"
                    });
                    return;
                }
                add(id);
            }else if ($(e.target).hasClass("fa-star")) {
                remove(id);
            }

        });
    }

    return {
        action: action
    }

}();