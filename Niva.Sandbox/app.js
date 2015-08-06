
/// <summary>fgfgfg</summary>

    var app = angular.module('Store', []);
    
    app.config(['$httpProvider', function ($httpProvider) {
        $httpProvider.defaults.useXDomain = true;
        delete $httpProvider.defaults.headers.common['X-Requested-With'];
    }
    ]);




//function MyController(parameters) {
//    alert("hi");
//}

