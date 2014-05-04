(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    var flyout;
    var deleteCommand;
    var okCommand;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.onready = function (args) {
        deleteCommand = document.getElementById('DeleteCommand').winControl;
        flyout = document.getElementById('Flyout');
        okCommand = document.getElementById('OkButton');

        deleteCommand.addEventListener('click', DisplayFlyout);
        okCommand.addEventListener('click', DeleteContent);
    }

    function DisplayFlyout() {
        flyout.winControl.show(deleteCommand, 'top');
    }

    function DeleteContent() {
        var contentDiv = document.getElementById('contentDiv');;
        if (contentDiv != null && contentDiv.parentElement != null) {
            contentDiv.parentElement.removeChild(contentDiv);
        }
    }


    app.start();
})();
