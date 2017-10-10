var MessageController = function() {
    var deleteAction = function () {
        $("button.js-btn-delete").on("click",
            function(e) {
                var id = $(e.target).attr("id");
                if (id) {
                    var success = function () {
                        $(e.target).closest("tr")
                            .addClass("animated fadeOut")
                            .on("webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend", function () {
                            this.remove();
                        });
                    };
                    var error = function () {
                        console.log("error");
                    };

                    MessageService.delete(id, success, error);
                }
            });
    }

    var readAction = function (id) {
        var success = function() {
            console.log("read");
        };
        var fail = function() {
            console.log("Fail");
        };
        MessageService.read(id, success, fail);
    }

    return {
        delete: deleteAction,
        read: readAction
    }
}();