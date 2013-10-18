(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var customerPromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Customers" });
            var employeePromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Employees" });

            var promises = { customer: customerPromise , employee : employeePromise } ;

            WinJS.Promise.join(promises).done(
                function complete(xhr) {
                    var x = 0;
                },
                function error(xhr) {
                    var x = 0;
                },
                function progress(xhr) {
                    var x = 0;
                }
           );

            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.start();
})();
