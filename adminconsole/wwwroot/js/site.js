// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function initMap() {
    // set BECU Headquarters for default map starting location
    /*var headquarters = {
        lat: 47.490305,
        lng: -122.272081
    }*/

    // The location of Uluru
    var uluru = { lat: 47.490305, lng: -122.272081};
    // The map, centered at Uluru
    var map = new google.maps.Map(
        document.getElementById('map-wrapper'), {
            zoom: 15,
            center: uluru
    });

    var image = {
        url: '/media/pin.png',
        scaledSize: new google.maps.Size(40, 50),
    };
    // The marker, positioned at Uluru
    var marker = new google.maps.Marker({
        position: uluru,
        map: map,
        icon: image,
        draggable: true
    });
    //var marker = new google.maps.Marker({ position: uluru, map: map });

    // *** set default map parameters *** //  
    /*var mapOptions = {
        center: headquarters,
        gestureHandling: 'cooperative',
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        //streetViewControl: false,
        zoom: 15,
    };

    // ***  display the Google map with the default Options  *** //
    map = new google.maps.Map(document.getElementById('map-wrapper'), mapOptions);*/


};

