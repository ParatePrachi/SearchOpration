$(document).ready(function () {
    detailsdata();
});

var Saveproduct = function () {
    debugger;
    var id = $("#hdnid").val();
    var productname = $("#txtpname").val();
    var offer = $("#txtoffer").val();
    var discount = $("#txtdiscount").val();

    var model = { Id: id, ProductName: productname, Offer: offer, Discount: discount };
    
        $.ajax({
            url: "/Product/SaveProduct",
            method: "post",
            data: JSON.stringify(model),
            contentType: "application/json;charset=utf-8",
            datatype: "json",
            success: function (response) {
                console.log.massage();
                alert("success");
                detailsdata(response.massage);
            }
        });

}

var detailsdata = function (Id) {
    debugger;
    var model = { Id: Id };
    $.ajax({
        url:"/Product/DetailData",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        async: false,
        success: function (response) {
            alert(response.model.ProductName);
            $("#txtPname").text(response.model.ProductName);
            $("#txtoff").text(response.model.Offer);
            $("#txtdis").text(response.model.Discount);
        }
    });
}