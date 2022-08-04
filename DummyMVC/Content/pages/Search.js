
$(document).ready(function () {
    getMainspList();
  
});



var getMainspList = function () {
    debugger;
    var empname = $("#txtename").val();
    var model = { Empname: empname };

    $.ajax({
        url:"/Sreach/GetEmpSpList",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblemp tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.EmpName + "</td></tr >";
            });
            $("#tblemp").append(html);

        }
    });
}