var MapController = function() {

    var map;
    var marker;
    var addMarker = function (location) {
         marker = new google.maps.Marker({
            position: location,
            map: map
        });
    };
    var load = function (loc) {
        var openLatLng;

        if (loc)
            openLatLng = new google.maps.LatLng(parseFloat(loc.lat), parseFloat(loc.lon));
        else
            openLatLng = new google.maps.LatLng(41.010151, 28.972411);
        
        var mapOptions = {
            center: openLatLng,
            zoom: 14,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
        addMarker(openLatLng);
        google.maps.event.addListener(map, 'click', function (e) {
            var location = new google.maps.LatLng(e.latLng.lat(), e.latLng.lng());
            marker.setPosition(location);
            $("#latitude").val(e.latLng.lat());
            $("#longitude").val(e.latLng.lng());
        });
    };

   

    return {
        load: load
    }
}();
