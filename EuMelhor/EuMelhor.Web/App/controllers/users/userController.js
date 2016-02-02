app.controller('UserController', ['$scope', '$http', 'UserService', function ($scope, $http, UserService) {

    var _users = [];

    var loadUsers = function () {
        UserService.GetUserById("36ED183C-2893-4EF5-88A3-122150DA50F8").success(function (data) {
            _users = new Array(data);
            $scope.users = _users;
        }).error(function (data, status) {
            toastr['error']('Aconteceu um problema: ' + data);
        });
    };

    loadUsers();

}]);