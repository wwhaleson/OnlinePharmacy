
function removerow() {
    // Add a click event listener to the document
    document.addEventListener('click', function (event) {
        // Check if the clicked element has the class "removebutton"
        if (event.target.classList.contains('removebutton')) {
            // Find the closest <tr> ancestor and remove it
            var row = event.target.closest('tr');
            if (row) {
                row.remove();
            }
        }
    });
}

function updateTotalAmount() {
    var total = 0;
    var finaltotal = 5;

    // Loop through each element with class "subtotalofaproduct"
    $('.subtotalofaproduct').each(function () {
        // Extract numeric value from the text (assuming currency format)
        var value1 = parseFloat($(this).text().replace('$', '').trim());
        // Add the value to the total
        total += isNaN(value1) ? 0 : value1;
    });

    // Update the total in the specified element
    $('#allproductsubtotalcol2').text('$' + total.toFixed(2));
    var value2 = parseFloat($('#deliveryamountcol2').text().replace('$', '').trim());
    finaltotal = total + value2;
    $('#totalamountcol2').text('$' + finaltotal.toFixed(2));
}

