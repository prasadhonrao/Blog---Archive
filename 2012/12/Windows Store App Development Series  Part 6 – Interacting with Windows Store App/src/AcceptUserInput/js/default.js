(function () {
    "use strict";
    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            args.setPromise(WinJS.UI.processAll());
        }

        var cityListBox = document.getElementById('cityListBox');
        var submitButton = document.getElementById('submitButton');
        var outputSpan = document.getElementById('outputSpan');
        var rating = document.getElementById('ratingDiv').winControl;

        submitButton.addEventListener('click', function () {
            outputSpan.innerHTML += cityListBox.value + " : " + rating.userRating + "</br>";
        });
    };

    app.start();
})();
