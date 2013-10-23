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

            promises[0] = WinJS.Promise.timeout(2000)
                                      .then(function ()
                                      {
                                          nameOutputDiv.textContent = "Prasad Honrao";
                                      });

            promises[1] = WinJS.Promise.timeout(4000)
                                      .then(function () {
                                          websiteOutputDiv.textContent = "http://PrasadHonrao.com";
                                      });

            WinJS.Promise.join(promises).done(
                function (promises)
                {
                    var containerDiv = document.getElementById('ContainerDiv');
                    containerDiv.style.backgroundColor = "black";
                }
            );

            args.setPromise(WinJS.UI.processAll());
        }
    };
    app.start();
})();
