app.service("UserService", ['$http', function ($http) {

    // Obter todos os usuários
    this.GetUsers = function () {
        return $http.get("http://localhost:56468/api/User");
    }

    // Obter usuário por id
    this.GetUserById = function (id) {
        return $http.get("http://localhost:56468/api/User?Key=" + id);
    }

    // Atualizar usuário
    this.PutUser = function (user) {
        var response = $http({
            method: "put",
            url: "http://localhost:56468/api/User/" + user.Id,
            data: JSON.stringify(user),
            dataType: "Json"
        });

        return response;
    }

    // Adicionar usuário
    this.PostUser = function (user) {
        var response = $http({
            method: "post",
            url: "http://localhost:56468/api/User",
            data: JSON.stringify(user),
            dataType: "Json"
        });

        return response;
    }

    // Excluir usuário
    this.DeleteUser = function (id) {
        var response = $http({
            method: "delete",
            url: "http://localhost:56468/api/User/" + JSON.stringify(id)
        });

        return response;
    }
}])
