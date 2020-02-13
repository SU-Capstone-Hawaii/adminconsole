// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



/**
 * Itinitalizes Google Map drawing with marker. This function is called on load
 * of Edit and Create views
 */
function initMap() {

    var lat = parseFloat($('#Latitude').attr('value'));
    var long = parseFloat($('#Longitude').attr('value'))



    if ((lat != null) && (long != null)) { // If we have a latitude and longitude, display map and drop pin
        displayMap(lat, long);
    }

}



/**
 * Displays the Google Map and a marker on the page
 * @param {any} lat:    Location Latitude
 * @param {any} long:   Location Longitude
 */
function displayMap(lat, long) {


    var location = { lat: lat, lng: long };




    // Center map on location
    var map = new google.maps.Map(
        document.getElementById('map-wrapper'), {
        zoom: 15,
        center: location
    });




    // Generate pin image to indicate position on map
    var image = {
        url: '/media/pin.png',
        scaledSize: new google.maps.Size(40, 50),
    };



    // Position marker on map
    var marker = new google.maps.Marker({
        position: location,
        map: map,
        draggable: true
    });



    // Change value of Latitude and Longitude based on marker position
    google.maps.event.addListener(marker, 'dragend', function (marker) {
        var latLng = marker.latLng;
        var lat = latLng.lat().toFixedDown(6);
        var long = latLng.lng().toFixedDown(6);
        $('#Latitude').val(lat);
        $('#Longitude').val(long);
    });

}



/**
 * Truncates JavaScript Float to maximum of 6 digits after the decimal. Left as 
 * a parameter for long-term code flexibility.
 */
Number.prototype.toFixedDown = function (digits = 6) {
    var re = new RegExp("([-+]?\\d+\\.\\d{" + digits + "})(\\d)"),
        m = this.toString().match(re);
    return m ? parseFloat(m[1]) : this.valueOf();
};

