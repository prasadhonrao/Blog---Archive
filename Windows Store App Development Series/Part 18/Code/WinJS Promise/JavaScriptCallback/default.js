$(document).ready(ready);

function ready() {
    $('#GetData').click(GetDataFromWeb);
}

function GetDataFromWeb() {
    $.ajax({
        type: "GET",
        url: "http://PrasadHonrao.com/feed/",
        complete: function (data) {
            // data processing logic goes here...
        }
    });
}