var myApp = angular.module('myApp', []);
myApp.controller('projetoCtrl', function ($http) {
    debugger
    var ctrl = this;
    $http.get("/PMS/GetUsuario")
        .then(function (result) {
            ctrl.usuario = result.data;
        })
        .catch(function (result) {
            console.log(result);
        });

    ctrl.adicionarUsuario = function (usuario) {
        ctrl.usuario.push(angular.copy(usuario));
        delete ctrl.usuario;
    };
});

