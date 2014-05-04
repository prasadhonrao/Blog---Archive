(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.onready = function () {
        var contentDiv = document.getElementById('contentDiv');
        var deleteButton = document.getElementById('DeleteButton').winControl;

        deleteButton.addEventListener('click', function () {
            var dialog = Windows.UI.Popups.MessageDialog("Do you want to delete the content?", "Content Deletion");
            dialog.commands.append(new Windows.UI.Popups.UICommand("Yes", dialogCommandHandler));
            dialog.commands.append(new Windows.UI.Popups.UICommand("No", dialogCommandHandler));
            dialog.defaultCommandIndex = 0;
            dialog.showAsync();
        });

        function dialogCommandHandler(command) {
            if (command.label === 'Yes' && contentDiv.parentElement != null) {
                contentDiv.parentElement.removeChild(contentDiv);
            }
        }
    };

    app.start();
})();
