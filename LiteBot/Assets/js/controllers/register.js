LiteBot.controller("RegisterController",
    [
        '$rootScope', '$scope', '$timeout', '$compile', '$http', '$interval',
        function ($rootScope, $scope, $timeout, $compile, $http, $interval) {
            $scope.fullname = '';
            $scope.email = '';
            $scope.username = '';
            $scope.password = '';
            $scope.repeatPassword = '';

            $scope.isValidEmail = function() {
                return validateEmail($scope.email);
            };

            $scope.isValidUsername = function() {
                return validUsername($scope.username);
            };

            $scope.doRegister = function () {
                if ($scope.fullname === '') {
                    $('input').eq(0).focus();
                    return;
                }
                if (!$scope.isValidEmail()) {
                    $('input').eq(1).focus();
                    return;
                }
                if (!$scope.isValidUsername()) {
                    $('input').eq(2).focus();
                    return;
                }
                if ($scope.password !== $scope.repeatPassword) {
                    UIkit.notification({ message: $rootScope.Lang.RegisterModule.RepeatPasswordNotMatch, status: 'warning' });
                    return;
                }

                $.ajax({
                    url: '/Auth/Register',
                    type: 'POST',
                    dataType: 'json',
                    success: function (data) {
                        console.log(data);
                        $("#btn-load-more-search").remove();
                        $("#load-more-search").replaceWith(data);
                    },
                    error: function (data) {
                        $("#btn-load-more-search").remove();
                        $("#load-more-search").replaceWith(data.responseText);
                    },
                    data: {
                        fullname: $scope.fullname,
                        email: $scope.email,
                        username: $scope.username,
                        password: $scope.password
                    }
                });
            }
        }
    ]);