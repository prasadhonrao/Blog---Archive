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

                        for (var n = 0; n < items.length; n++) {
                            var article = {};
                            article.title = items[n].querySelector("title").textContent;
                            article.pubDate = items[n].querySelector("pubDate").textContent;
                            articlesList.push(article);
                            //var thumbs = items[n].querySelectorAll("thumbnail");
                            //if (thumbs.length > 1) {
                            //    article.thumbnail = thumbs[1].attributes.getNamedItem("url").textContent;
                            //    article.content = items[n].textContent;
                            //    articlesList.push(article);
                            //}
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


    app.onerror = function (args) {
        var e = 0;
    }

    app.start();
})();
