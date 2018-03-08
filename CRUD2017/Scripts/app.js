var app = angular.module("Crud2017App", ["Crud2017App.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
    when("/", {
        templateUrl: "/Pages/Lista.html",
        controller: "IniCtrl"
    }).
        when("/Add",
        {
            templateUrl: "/Pages/Add.html",
            controller: "AddCtrl"
        }).
        when("/Edit/:id",
        {
            templateUrl: "/Pages/Edit.html",
            controller: "EditCtrl"
        }).
        when("/Details",
        {
            templateUrl: "/Pages/Details.html",
            controller: "DetailsCtrl"
        }).        
    otherwise({ redirectTo: "/" });
}])