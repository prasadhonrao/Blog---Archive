(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var customerList = [];
    var productList = [];

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var customerPromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Customers" });
            var productPromise = WinJS.xhr({ url: "http://services.odata.org/V3/Northwind/Northwind.svc/Products" });

            var promises = { customer: customerPromise , product : productPromise } ;

            WinJS.Promise.join(promises).done(
                function complete(xhr) {

                    var customerResult = xhr.customer.responseXML;
                    var items = customerResult.querySelectorAll("entry");

                    for (var ctr = 0; ctr < items.length; ctr++) {
                        var customer = {};

                        customer.ContactName = items[ctr].querySelector("ContactName").textContent;
                        customerList.push(customer);
                    }

                    var customerDataList = new WinJS.Binding.List(customerList);
                    var customerListView = document.getElementById('CustomerListView').winControl;
                    customerListView.itemDataSource = customerDataList.dataSource;

                    var productResult = xhr.product.responseXML;
                    var items = productResult.querySelectorAll("entry");

                    for (var ctr = 0; ctr < items.length; ctr++) {
                        var product = {};
                        product.ProductName = items[ctr].querySelector("ProductName").textContent;
                        product.UnitPrice = items[ctr].querySelector("UnitPrice").textContent;
                        productList.push(product);
                    }

                    var productDataList = new WinJS.Binding.List(productList);
                    var productListView = document.getElementById('ProductListView').winControl;
                    productListView.itemDataSource = productDataList.dataSource;
                    
                },
                function error(xhr) {
                    // Handle error here...
                },
                function progress(xhr) {
                    // Handle progress here...
                }
           );

            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.start();
})();
