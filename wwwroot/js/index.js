var thanksModal, stepUpModal;
$(document).ready(function () {
    $('.card-allergy').popover({ trigger: "hover", content: "Please be aware that the food may contain or come into contact with eggs." });

    thanksModal = new bootstrap.Modal(document.getElementById('thanksModal'), {
        keyboard: false
    });

    stepUpModal = new bootstrap.Modal(document.getElementById('stepUpModal'), {
        keyboard: false
    });
});

function addItem(price) {
    var total = parseInt($("#total").text(), 0) + price;
    $("#total").text(total);
    $("#checkoutContainer").show();

    return false;
}

function checkout() {
    var total = parseInt($("#total").text(), 0);

    if (total > 50 && $("#stepUpFulfilled").text() != "True") {
        stepUpModal.show();
    }
    else {
        completeOrder();
    }

    return false;
}

function completeOrder() {
    $("#total").text(0);
    $("#checkoutContainer").hide();

    thanksModal.show();
    window.location.hash = '';
    const myTimeout = setTimeout(completeOrderHide, 5000);
}

function completeOrderHide() {
    thanksModal.hide();
}


// Calculate how long each ‘frame’ should last if we want to update the animation 60 times per second
const frameDuration = 15;
// Use that to calculate how many frames we need to complete the animation
const totalFrames = 120;
// An ease-out function that slows the count as it progresses
const easeOutQuad = t => t * (2 - t);

// The animation function, which takes an Element
const animateCountUp = el => {
    let frame = 0;
    const countTo = parseInt(el.innerHTML, 10);
    // Start the animation running 60 times per second
    const counter = setInterval(() => {
        frame++;
        // Calculate our progress as a value between 0 and 1
        // Pass that value to our easing function to get our
        // progress on a curve
        const progress = easeOutQuad(frame / totalFrames);
        // Use the progress value to calculate the current count
        const currentCount = Math.round(countTo * progress);

        // If the current count has changed, update the element
        if (parseInt(el.innerHTML, 10) !== currentCount) {
            el.innerHTML = currentCount;
        }

        // If we’ve reached our last frame, stop the animation
        if (frame === totalFrames) {
            clearInterval(counter);
        }
    }, frameDuration);
};

// Run the animation on all elements with a class of ‘countup’
const runAnimations = () => {
    const countupEls = document.querySelectorAll('.countup');
    countupEls.forEach(animateCountUp);
};

runAnimations();