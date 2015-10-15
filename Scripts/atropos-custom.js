$(document).ready(function () {
    // remove submenu arrow
    $('.dropdown-menu i').remove();

    // change submenu class
    $('.dropdown-menu .dropdown').removeClass('dropdown').addClass('dropdown-submenu');

    // unwrap last item in breadcrumb
    $('.breadcrumb .active a').contents().unwrap();

    // resize the page content to the window height
    var height = $(window).height();
    height -= $('footer').height(); //footer
    $('#wrapper').css('min-height', height);

    // resize the main layout when the window size changes
    $(window).on('resize', function () {
        var height = $(window).height();
        height -= $('footer').height(); //footer

        $('#wrapper').css('min-height', height);
    });

    // pagination
    $('#pagination ul').removeClass('pager').addClass('pagination');
    $('#pager-current').parent('li').addClass('active');

    // toggle for archive
    var $toggle = $('.toggle');
    if ($toggle.length > 0) {
        $toggle.each(function () {
            var element = $(this),
                elementState = element.attr('data-state');

            if (elementState != 'open') {
                element.find('.togglec').hide();
            } else {
                element.find('.togglet').addClass("toggleta");
            }

            element.find('.togglet').click(function () {
                $(this).toggleClass('toggleta').next('.togglec').slideToggle(300);
                return true;
            });
        });
    }

    // blog timeline
    $('.blog-timeline ul.blog-posts li:odd > .timeline-item').addClass('pull-right');
    $('.blog-timeline ul.blog-posts li:even > .timeline-item').addClass('pull-left');
});