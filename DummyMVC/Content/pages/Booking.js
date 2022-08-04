
$(document).ready(function () {
    spjoinbook();
    joinusinglinq();
});



var spjoinbook = function () {
    debugger;
    //var empid = $("#txtempid").val();
    //var empname = $("#txtempname").val();
    //var name = $("#txtname").val();
    //var address = $("#txtaddress").val();

   /* var model = { EmpId: empid, EmpName: empname, Name: name, Address: address };*/

    $.ajax({
        url: "/Booking/getspjoin",
        method: "post",
        /*data: JSON.stringify(model),*/
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblbooking tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.EmpId + "</td><td>" + elementValue.EmpName +"</td></tr >";
            });
            $("#tblbooking").append(html);

        }
    });
}


var joinusinglinq = function () {
    debugger;
   
    $.ajax({
        url: "/Booking/usinglinqjoin",
        method: "post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblbook tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.BookingId + "</td><td>" + elementValue.Name + "</td><td>" + elementValue.EmpId + "</td><td>" + elementValue.MobileNo + "</td></tr >";
            });
            $("#tblbook").append(html);

        }
    });
}