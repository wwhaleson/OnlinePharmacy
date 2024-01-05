// external.js

function handlecheckout() {
    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation');

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms).forEach(function (form) {
        form.addEventListener('submit', function (event) {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
                window.location.href = '/SuccessfulPurchase';
            }


            form.classList.add('was-validated');
        }, false);
    });
}

// Function to be called when the DOM is ready
function handlecheckout() {
    // Assuming you have a button with the ID "submitbutton"
    var checkoutButton = document.getElementById('submitbutton');

    // Add a click event listener to the checkout button
    checkoutButton.addEventListener('click', function (event) {
        // Call handlecheckout when the checkout button is clicked
        handlecheckout();
    });
}

