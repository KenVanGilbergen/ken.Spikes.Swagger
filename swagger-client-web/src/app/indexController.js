angular.module('app').controller('IndexController', function ($cacheFactory, $scope, helloWorldFactory) {
   
    var vm = this;

    vm.name = 'Unloaded person';
    vm.cache = $cacheFactory('hwa');
    
    // using grunt generated factory
    var api = new helloWorldFactory('http://localhost:10010', vm.cache); // does not seem to cache the request
    $scope.$watch(
        function() { return vm.name; }, //'vm.name', // you would have to use <controllerName> as vm in order to be able to do $scope.$watch(vm.<property>)
        function(newValue, oldValue) {
            if (vm.name.length > 0) {
                var hello = api.hello({ name: newValue });
                hello.then(function(greeting) {
                    vm.greeting = greeting;
                });
            } else {
                vm.greeting = "Hmmmm... emptiness... used to be " + oldValue;
            }
        });
    
    // using at runtime javascript client    
    vm.swaggerDynamic = 'Loading...';
    var client = new SwaggerClient({
        url: 'http://127.0.0.1:10010/swagger',
        success: function () {
            client.default.hello({ name: 'DynamicNameFromVM' }, { responseContentType: 'application/json' }, function (response) {
                vm.swaggerDynamic = response.data;
                $scope.$apply();
            });
        }
    });
});
