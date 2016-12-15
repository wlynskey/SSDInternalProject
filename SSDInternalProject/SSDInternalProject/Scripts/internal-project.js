$(function () {
    filterBrand();
    $('#BrandSelect').change(filterBrand);
    $('#BrandSelect').change(resetBrand);
})

function filterBrand() {
    var brandId = $('#BrandSelect').val();
    $('#ModelSelect option').each(function () {
        if ($(this).attr('class') != brandId) {
            $(this).css('display', 'none');
        }
        else {
            $(this).css('display', 'block');
        }
    })
}
function resetBrand() {
    $('#ModelSelect option').removeAttr('selected')
    $('#ModelSelect .BlankSelect').attr("selected", "selected");
}