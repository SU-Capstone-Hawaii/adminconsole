/** Sets the exportDataType attribute of the bootstrap
     * table to 'all'. This allows the export to export all
     * of the data in the table, instead of only the rows on
     * the current page. */

$(function () {
    selectLocations();
});

function selectLocations() {
    $(".showLocations").show();
    $(".showContacts").hide();
    $(".showSpecialQualities").hide();
    $(".showDailyHours").hide();
    $(".showAll").hide();
}

function selectContacts() {
    $(".showLocations").hide();
    $(".showContacts").show();
    $(".showSpecialQualities").hide();
    $(".showDailyHours").hide();
    $(".showAll").hide();
}

function selectSpecialQualities() {
    $(".showLocations").hide();
    $(".showContacts").hide();
    $(".showSpecialQualities").show();
    $(".showDailyHours").hide();
    $(".showAll").hide();
}

function selectDailyHours() {
    $(".showLocations").hide();
    $(".showContacts").hide();
    $(".showSpecialQualities").hide();
    $(".showDailyHours").show();
    $(".showAll").hide();
}

function showAll() {
    $(".showLocations").hide();
    $(".showContacts").hide();
    $(".showSpecialQualities").hide();
    $(".showDailyHours").hide();
    $(".showAll").show();
}