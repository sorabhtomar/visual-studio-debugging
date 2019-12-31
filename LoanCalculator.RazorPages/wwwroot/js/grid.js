$(document).ready(function () {
    var table = $('#loans').DataTable({
        "processing": true, // for show progress bar
        "serverSide": true,
        "ajax": '/loans',
        "rowId": "resultId",
        "columnDefs": [{
            "targets": [3],
            "render": function (data, type, row) {
                return Number(data).toLocaleString('en-IN', {
                    maximumFractionDigits: 2,
                    style: 'currency',
                    currency: 'INR'
                });
            }
        }],
        "columns": [
            { "data": "resultId" },
            { "data": "firstName" },
            { "data": "lastName" },
            { "data": "loanAmount" },
            { "data": "approved" },
        ]
    });

    $('.dataTables_filter input').addClass('form-control dt-input');
    $('.dataTables_length select').addClass('form-control dt-select');

    $('#loans').on('click', 'tr', function () {
        var id = table.row(this).id();
        $.get("/loans/" + id, function (data) {
            $("#details").html(data)
        })
    });
});
