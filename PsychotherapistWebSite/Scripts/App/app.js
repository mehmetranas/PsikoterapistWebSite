var animate = function() {
    $.fn.extend({
        animateCss: function (animationName) {
            var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
            this.addClass('animated ' + animationName).one(animationEnd, function () {
                $(this).removeClass('animated ' + animationName).remove();
            });
            return this;
        }
    });
};

var counter = function (count) {
    $(".js-counter").html(count - $(".js-form textarea").val().length);

    $(".js-form textarea").on("input DOMContentLoaded",
        function () {
            var length = $(".js-form textarea").val().length;
            var counter = count - length;
            $(".js-counter").html(counter);
            if (counter < 0) {
                $(".js-counter").css({ "color": "red" });
            } else {
                $(".js-counter").css({ "color": "black" });
            }
        });
}
