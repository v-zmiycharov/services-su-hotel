var createSelect2 = function (selector, searchUrl, parentSelector) {
    var placeholder = 'Search';
    $(selector).select2({
        placeholder: placeholder,
        allowClear: true,
        containerCssClass: "select2-allowclear",
        initSelection: function (element, callback) {
            var id = $(element).val();
            if (id !== "") {
                return $.ajax({
                    url: searchUrl + '/' + id,
                    type: "GET",
                    dataType: "json"
                }).done(function (data) {
                    var results;
                    results = [];
                    results.push({
                        id: data.id,
                        text: data.text
                    });
                    callback(results[0]);
                });
            }
        },
        ajax: {
            url: searchUrl,
            dataType: 'json',
            type: "POST",
            quietMillis: 250,
            data: function (term) {
                return {
                    term: term,
                    parentId: $(parentSelector).val()
                };
            },
            results: function (data) {
                return {
                    results: $.map(data, function (item) {
                        return {
                            id: item.id,
                            text: item.text
                        }
                    })
                };
            }
        },
    });

    $(parentSelector).change(function () {
        $(selector).select2('data', null).change();
    });
}

$(document).ready(function () {
    $('input#reservation-submit').click( function() {
        $.ajax({
            url: '/api/HotelReservations',
            type: 'post',
            dataType: 'json',
            data: $('form#reservation-form').serialize(),
            success: function(data) {
                window.location.href = "/Home/HotelReservations"
            }
        });
    });

    $('.datepicker').datepicker({
        dateFormat: 'dd.mm.yy'
    });

    $('[name="DateFrom"].datepicker').datepicker("setDate", new Date(2016, 6, 15));
    $('[name="DateTo"].datepicker').datepicker("setDate", new Date(2016, 6, 22));
})