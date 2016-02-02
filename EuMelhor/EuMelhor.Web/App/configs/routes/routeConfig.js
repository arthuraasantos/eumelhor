app.config(function ($routeProvider, $locationProvider) {

    $routeProvider

    .when('/Home', {
        templateUrl: 'App/views/Home.html',
        controller: 'HomeCtrl',
    })

    .when('/About', {
        templateUrl: 'App/views/About.html',
        controller: 'AboutCtrl',
    })

    .when('/Contact', {
        templateUrl: 'App/views/Contact.html',
        controller: 'ContactCtrl',
    })

    .when('/Login', {
        templateUrl: 'App/views/Login.html',
        controller: 'LoginCtrl',
    })

    .otherwise({ redirectTo: '/Default.html' });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});