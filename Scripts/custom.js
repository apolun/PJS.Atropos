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
});