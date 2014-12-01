angular.module('ConverterApp', [])
  .controller('ConverterController', ['$scope', '$http', function ($scope, $http) {

      $scope.convert = function () {


          $scope.convertionResult = {};

          $http.get('/api/converter/' + $scope.currencyFrom + '/' + $scope.currencyTo + '/' + $scope.amount + '/').
              success(function (data) {
  
                  $scope.convertionResult = data;
              }).
              error(function (data) {
        
                  $scope.convertionResult.error = true;

              });

      }
  }]);