$(document).ready(function () {
    $('input[type=text]').on('blur', function () {
        $(this).each(function () {
            nama($('#form3Example1m').val());
            no($('#form3Example1n').val());
        });
    });


    function nama(myname) {
        if (!myname) {
            $('<span>name cannot be empty</span>').insertAfter('#form3Example1m');
        }
    }


    function no(mynomor) {
        if (!mynomor) {
            $('<span>number cannot be empty</span>').insertAfter('#form3Example1n');
        }
    }
});