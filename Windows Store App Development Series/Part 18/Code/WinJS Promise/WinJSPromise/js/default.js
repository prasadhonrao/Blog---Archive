(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var articlesList = [];
    var dataList = [];

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var requestUrl = "http://PrasadHonrao.com/feed/";

            var promise = WinJS.xhr({ url: requestUrl });

            promise.done(
               // Complete function
               function (response) {
                   var items = response.responseXML.querySelectorAll("item");

                   for (var ctr = 0; ctr < items.length; ctr++) {
                       var article = {};
                       article.title = items[ctr].querySelector("title").textContent;
                       var date = new Date(items[ctr].querySelector("pubDate").textContent).toDateString();
                       article.pubDate = date;
                       articlesList.push(article);
                   }

                   dataList = new WinJS.Binding.List(articlesList);
                   var articleListView = document.getElementById('articleListView').winControl;
                   articleListView.itemDataSource = dataList.dataSource;
               },

               // Error function
               function (response) {
                   // handle error here...
               },

               // Progress function
               function (response) {
                   // progress implementation goes here...
               }
           );

            WinJS.UI.processAll();
        }
    };

    app.start();
})();
