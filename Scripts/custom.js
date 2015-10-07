$(document).ready(function () {
    // remove submenu arrow
    $('.dropdown-menu i').remove();

    // change submenu class
    $('.dropdown-menu .dropdown').removeClass('dropdown').addClass('dropdown-submenu');

    // unwrap last item in breadcrumb
    $('.breadcrumb .active a').contents().unwrap();

    // SIZE PAGE CONTENT TO WINDOW HEIGHT
    var height = $(window).height();
    height -= $('#topHead').height(); //top bar
    height -= $('#topNav').height(); //navigation
    height -= $('footer').height(); //footer

    $('#wrapper').css('min-height', height+99);
});