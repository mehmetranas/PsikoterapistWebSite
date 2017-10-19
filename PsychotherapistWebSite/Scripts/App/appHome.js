var animate = function () {
    $.fn.extend({
        animateHide: function (animationName) {
            var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
            this.addClass('animated ' + animationName).one(animationEnd, function () {
                $(this).removeClass();
                $(this).hide();
            });
            return this;
        }
    });
};