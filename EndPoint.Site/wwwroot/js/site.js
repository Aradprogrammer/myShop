// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ChangeCountItem(productId, Count) {
    var postdata = {
        productCount: Count,
        productId: productId
    };
    var url = location.origin + "/Carts/AddToCart";
    $.ajax({
        contentType: 'application/x-www-form-urlencoded',
        dataType: 'json',
        type: "POST",
        url: url,
        data: postdata,
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                )
                    .then
                    (function (isConfirm) {
                        history.go(-1);
                    }
                    );
            }
            else {
                swal.fire
                    (
                        'هشدار!',
                        data.message,
                        'warning'
                    );
            }
        },
        error: function (request, status, error) {
            if (request.responseText != null) {
                alert(request.responseText);
            }
            else {
                alert(error.text);
            }
        }

    });
}
function RemoveCartItem(productId,cartid) {
    var url = location.origin + "/Carts/RemoveCartItem";
    var postdata = {
        productId: productId,
        CartId: cartid
    };
    $.ajax({
        contentType: 'application/x-www-form-urlencoded',
        dataType: 'json',
        type: "POST",
        url: url,
        data: postdata,
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                )
                    .then
                    (function (isConfirm) {
                        location.reload();
                    }
                    );
            }
            else {
                swal.fire
                    (
                        'هشدار!',
                        data.message,
                        'warning'
                    );
            }
        },
        error: function (request, status, error) {
            if (request.responseText != null) {
                alert(request.responseText);
            }
            else {
                alert(error.text);
            }
        }

    });
}