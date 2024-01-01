function AddChangeBadge() {

    document.addEventListener('click', function (event) {
        var badge = document.getElementById('dummy');
        var cartItemCount = parseInt(badge.innerText) || 0; // Initial value

        // Update the badge value
        badge.innerText = ++cartItemCount;
        console.log("Added to Cart");
    });
 


    

}