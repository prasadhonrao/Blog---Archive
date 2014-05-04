(function () {
    var app = WinJS.Application;
    app.onactivated = function (args) {
        // Custom model with 'name' attribute
        var customer = WinJS.Binding.as({
            name: ''
        });

        //// Bind the model attribute name to Output span
        //var outputSpan = document.getElementById('OutputSpan');
        //customer.bind('name', function (value) {
        //    outputSpan.textContent = value;
        //});

        // Update model value [name] when user types in input textbox
        var inputText = document.getElementById('InputText');
        inputText.onkeyup = function () {
            customer.name = inputText.value;
        }

        WinJS.UI.processAll();
        WinJS.Binding.processAll(document.rootElement, customer);
        
    };

app.onactivated = function (args) {
    // Custom model with 'name' attribute
    var customer = WinJS.Binding.as({
        name: ''
    });

    // Update model value [name] when user types in input textbox
    var inputText = document.getElementById('InputText');
    inputText.onkeyup = function () {
        customer.name = inputText.value;
    }

    WinJS.UI.processAll();
    WinJS.Binding.processAll(document.rootElement, customer);
};

    app.start();
})();
