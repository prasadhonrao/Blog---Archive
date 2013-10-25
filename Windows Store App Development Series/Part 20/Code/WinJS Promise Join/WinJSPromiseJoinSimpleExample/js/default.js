(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var nameOutputDiv = document.getElementById('NameOutputDiv');
            var websiteOutputDiv = document.getElementById('WebsiteOutputDiv');

            var promises = [];
            promises[0] = WinJS.Promise.timeout(3000)
                                       .then(function () {
                                           nameOutputDiv.textContent = "Prasad Honrao";
                                       });

            promises[1] = WinJS.Promise.timeout(6000)
                                       .then(function () {
                                           websiteOutputDiv.textContent = "http://PrasadHonrao.com";
                                       });

            WinJS.Promise.join(promises).done(
                function () {
                    setTimeout(function () {
                        var containerDiv = document.getElementById('ContainerDiv');
                        containerDiv.style.border = "2px solid white";
                        containerDiv.style.borderRadius = "10px";
                    }, 3000);
                }
            );

            args.setPromise(WinJS.UI.processAll());
        }
    };
    app.start();
})();
