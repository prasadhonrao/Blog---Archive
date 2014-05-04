(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
            } else {
            }
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.onready = function () {
        var message = document.getElementById('message');
        var display = Windows.Graphics.Display.DisplayProperties;
        display.addEventListener('orientationchanged', onOrientationchanged);

        onOrientationchanged();
    }

    function onOrientationchanged() {
        switch (Windows.Graphics.Display.DisplayProperties.currentOrientation) {

            case Windows.Graphics.Display.DisplayOrientations.landscape:
                message.innerText = "Display Orientation - Landscape";
                break;

            case Windows.Graphics.Display.DisplayOrientations.portrait:
                message.innerText = "Display Orientation - Portrait";
                break;

            case Windows.Graphics.Display.DisplayOrientations.landscapeFlipped:
                message.innerText = "Display Orientation - Landscape (flipped)";
                break;

            case Windows.Graphics.Display.DisplayOrientations.portraitFlipped:
                message.innerText = "Display Orientation - Portrait (flipped)";
                break;

            default:
                message.innerText = "Unknown";
                break;
        }

    }

    app.oncheckpoint = function (args) {
    };

    app.start();
})();