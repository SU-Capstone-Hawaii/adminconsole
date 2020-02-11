// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function initMap() {
    var center = { lat: 55.92965249, lng: 12.47840507 };

    var map = new google.maps.Map(document.getElementById("map"), {
        zoom: 12,
        center: center
    });
}
