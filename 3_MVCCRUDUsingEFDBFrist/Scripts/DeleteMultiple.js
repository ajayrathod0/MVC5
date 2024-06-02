
$(function () {

    $('[name="selectAll"]').click(function () {
        var checked = $(this).prop('checked');
        $('[name="ProductToDelete"]').prop('checked', checked);
    });

    $('[name="ProductToDelete"]').click(function () {
        var totelRecords = $('[name="ProductToDelete"]').length;
        var selectResords = $('[name="ProductToDelete]: checked').length;

        if (totelRecords == selectResords) {
            $('[name="selectAll"]').prop('checked', true);
        } else {
            $('[name="selectAll"]').prop('checked', false)
        }
    })


    $('#deleteMultiple').click(function () {
        var selectedRecord = $('[name="ProductToDelete"]:cheched').length;
        return confirm('Are you Sure You Want To Delete' + selectedRecord + 'records?');
    })


});