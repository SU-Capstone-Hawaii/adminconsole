// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function findBootstrapEnvironment() {
    let envs = ['xs', 'sm', 'md', 'lg', 'xl'];

    let el = document.createElement('div');
    document.body.appendChild(el);

    let curEnv = envs.shift();

    for (let env of envs.reverse()) {
        el.classList.add(`d-${env}-none`);

        if (window.getComputedStyle(el).display === 'none') {
            curEnv = env;
            break;
        }
    }

    document.body.removeChild(el);
    return curEnv;
}


/**
 * Itinitalizes Google Map drawing with marker. This function is called on load
 * of Edit and Create views
 */
function initMap() {
    var lat;
    var long;
    geocoder = new google.maps.Geocoder();
    var address = '601 E Pike St.';
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status == 'OK') {
            console.log(results);
            lat = results[0]['geometry']['location'].lat();
            long = results[0]['geometry']['location'].lng();
            console.log("lat: ", results[0]['geometry']['location'].lat());
            console.log("long: ", results[0]['geometry']['location'].lng());
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });

    
    var lat = parseFloat($('#Latitude').attr('value'));
    var long = parseFloat($('#Longitude').attr('value'))

    console.log(findBootstrapEnvironment());

    if ((lat != null) && (long != null)) { // If we have a latitude and longitude, display map and drop pin


        displayMap(lat, long);


    } else {                               // Get get lat/long from address
        var LatLong = document.getElementById("getLatLongBtn")
            .addEventListener("click", getLatLongFromAddress);
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
 * To Do: Get latitude and longitude from address 
 **/


/*function getLatLongFromAddress() {


    var street = $('#Address').attr('value').trim();
    var city = $('#City').attr('value').trim();

    if (empty(street) || empty(city)) {
        return;
    }

    var addressArray = street.split() + city.split();


    var formattedAddress = addressArray.join('+');



    if (!empty($address)) {
        //Formatted address
        $formattedAddr = str_replace(' ', '+', $address);
        //Send request and receive json data by address
        $geocodeFromAddr = file_get_contents('http://maps.googleapis.com/maps/api/geocode/json?address='.$formattedAddr.'&sensor=false');
        $output = json_decode($geocodeFromAddr);
        //Get latitude and longitute from json data
        $data['latitude'] = $output -> results[0] -> geometry -> location -> lat;
        $data['longitude'] = $output -> results[0] -> geometry -> location -> lng;
        //Return latitude and longitude of the given address
        if (!empty($data)) {
            return $data;
        } else {
            return false;
        }
    } else {
        return false;
    }
}*/


/**
 * Truncates JavaScript Float to maximum of 6 digits after the decimal. Left as 
 * a parameter for long-term code flexibility.
 */
Number.prototype.toFixedDown = function (digits = 6) {
    var re = new RegExp("([-+]?\\d+\\.\\d{" + digits + "})(\\d)"),
        m = this.toString().match(re);
    return m ? parseFloat(m[1]) : this.valueOf();
};

