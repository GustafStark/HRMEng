
function swapImages() {
    var $active = $('#myGallery .active');
    var $next = ($('#myGallery .active').next().length > 0) ? ('#myGallery .active').next() : $('#myGallery img:first');
    $active.fadeOut(function () {
        $active.removeClass('active');
        $next.fadeIn().addClass('active');
    });

}
var img = new Image();
img.src ( http://www.hrmengineering.se/template/default/img/logo.png');

var images = new Array(img, 'test2.png', 'test3.png');
var index = 1;

function rotateImage() {
    $('#myImage').fadeOut('fast', function () {
        alert("Hej");
        $(this).attr('src', images[index])
        $(this).fadeIn('fast', function () {
            if (index = Image.length - 1) {
                index = 0;
                alert();
            }
            else {
                index++;
            }
        });
    });
}

$(document).ready(function () {
    setInterval(rotateImage, 2500);
});

function AlertMessage()
{ 
    alert("Message Alert");
};

function myFunction(a, b) {
    return a * b;
}
document.getElementById("demo").innerHTML = window.myFunction(10, 2);