LiteBot.controller("ForgotPasswordController",
    [
        '$scope', '$timeout', '$compile', '$http', '$interval',
        function ($scope, $timeout, $compile, $http, $interval) {
            $scope.isSentEmail = false;

            $scope.sendEmail = function() {
                $scope.isSentEmail = true;
            };
        }
    ]);