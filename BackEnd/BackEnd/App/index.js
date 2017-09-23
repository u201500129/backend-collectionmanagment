var app = angular.module("backend", ["dx", "ngRoute"]);

app.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "Login/login.html",
        controller: "loginController"
    })
    .when("/logout", {
        templateUrl: "Login/logout.html",
        controller: "logoutController"
    })
    .when("/home", {
        templateUrl: "Home/home.html",
        controller: "homeController"
    })
    .when("/usuario", {
        templateUrl: "Usuario/usuario.html",
        controller: "usuarioController"
    })
    .when("/crearCampania", {
        templateUrl: "Campania/crearCampania.html",
        controller: "crearCampaniaController"
    });
});