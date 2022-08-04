$(document).ready(function () {
    getMainSearchList();
});
var getMainSearchList = function () {
    debugger;
    var NAME = $("#txtName").val();
    var model = { NAME: NAME };


    $.ajax({
        url: "/SearLinq/GetSearchList",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblsearch tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Id + "</td><td>" + elementValue.Name + "</td><td>" + elementValue.Address + "</td><td>"
                    + elementValue.Emailid + "</td></tr > ";
            });
            $("#tblsearch").append(html);

        }
    });
}

