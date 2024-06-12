$(document).load($(window).bind("resize", checkPosition));
function checkPosition() {
    if (window.matchMedia('(max-width: 767px)').matches) {
        $('.main-menu .container ul').css('display', 'none');
    } else {
        $('.main-menu .container ul').css('display', 'block');
    }
}
$(function ($) {

    $('.main-menu .container > span').click(function () {
        $('.main-menu .container ul').slideToggle();
    });
    $('.main-menu .container > ul > li').click(function () {
        $(this).find('ul').slideToggle();
    });

    $("#slider-one").owlCarousel({

        slideSpeed: 300,
        paginationSpeed: 400,
        items: 1,
        autoplay: true,
        autoplayTimeout: 5000,
        center: true,
        autoplayHoverPause: true,
        loop: true,
        nav: true,
        navText: [
            "<i class='fa fa-caret-left'></i>",
            "<i class='fa fa-caret-right'></i>"
        ]
    });

    var owl = $("#slider-one");
    $(".next").click(function () {
        owl.trigger('owl.next');
    });
    $(".prev").click(function () {
        owl.trigger('owl.prev');
    });


});




