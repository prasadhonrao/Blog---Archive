(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var articlesList = [];
    var dataList = [];

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            var requestUrl = "http://prasadhonrao.com/feed/";

            WinJS.xhr({ url: requestUrl})
                 .done(
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
                    function (request) {
                        var x = 0;
                    },

                    // Progress function
                    function (request) {
                        var x = 0;
                    }
                );

            WinJS.UI.processAll();
        }
    };

    app.start();
})();
