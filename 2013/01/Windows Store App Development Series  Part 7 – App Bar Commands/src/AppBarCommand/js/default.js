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

    app.onready =  function (args) {
        var containerDiv = document.getElementById('containerDiv');
        var displayCommand = document.getElementById('DisplayCommand').addEventListener('click', DisplayMessage);
        var hideommand = document.getElementById('HideCommand').addEventListener('click', HideMessage);
    }

    function DisplayMessage() {
        containerDiv.innerHTML = "<h1>Windows 8 Rocks!</h1>"
    }

    function HideMessage() {
        containerDiv.innerHTML = ""
    }

    app.oncheckpoint = function (args) {
    };

    app.start();
})();
