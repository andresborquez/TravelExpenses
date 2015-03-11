$('input[type="date"]').prop('type', 'text');

$('input[type="date"]').datepicker().prop('type', 'text');

/*
$(document).ready(function () {
    $('.date').datepicker({
        format: 'dd/mm/yyyy',
        autoclose: true,
        todayHighlight: true
    });
})
*/

if (Modernizr.inputtypes.date) {
    $(function () {
        $(".date").datepicker({
            format: 'dd/mm/yyyy',
            autoclose: true,
            todayHighlight: true
        });
    });
}
