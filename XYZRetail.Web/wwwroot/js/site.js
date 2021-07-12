// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $("#productGobackButton").hide();
    $("#customer-details").hide();
    $("#basket").hide();

    let items = [];
    let count = 0;

    $(".product").on("click", function () {

        const id = $(this).attr("data-product-id");

        let productItemIndex = items.findIndex(x => x.productId == id);

        if (productItemIndex === - 1) {
            const newEntry = {
                productId: parseInt(id),
                quantity: 1
            };

            items.push(newEntry);
        }
        else {
            items[productItemIndex].quantity++;
        }

        count = items.length;
        document.getElementById("basket-item-count").innerHTML = count;

    });

    $("#cartButton").on("click", function () {

        $("#productGobackButton").show();
        $("#productList").hide();
        $("#cartButton").hide();
        $("#customer-details").show();
        document.getElementById("app-header").innerHTML = "Enter your Details";

    });

    $("#SaveCustomerButton").on("click", function (e) {

        e.preventDefault();

        const customerName = document.getElementById("customerName").value;
        const email = document.getElementById("email").value;
        const address = document.getElementById("address").value;

        basketRequest = {
            customerName: customerName,
            email: email,
            address: address,
            items: items
        };

        $.post({
            url: "api/basket",
            type: "POST",
            async: false,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(basketRequest),
            success: function (response) {
                $("#productList").hide();
                $("#cartButton").hide();
                $("#customer-details").hide();
                $("#basket").show();
                var basketView = $("#basket-view").html();
                $("#customer-name").html(response.customerName);
                $("#customer-email").html(response.email);
                $("#customer-address").html(response.address);
                document.getElementById("app-header").innerHTML = "Your Cart";

                var tableRows = $('#data-row').html();
                response.items.forEach(function (item) {

                    $('#data-row').append(tableRows
                        .replace("{row-{productId}}", "row-" + item.productId)
                        .replace("{itemName}", item.itemName)
                        .replace("{quantity}", item.quantity)
                        .replace("{basePrice}", item.itemBasePrice)
                        .replace("{netPrice}", item.itemNetPrice));
                });

                $("tr:eq(1)").remove();
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        })
    })
});