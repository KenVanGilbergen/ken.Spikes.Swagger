angular.module('app').controller('IndexController', function ($scope, HelloWorldApi) {
    
    var vm = this;

    vm.name = 'Unloaded person';

    $scope.$watch(
        function() { return vm.name; }, //'vm.name', // you would have to use <controllerName> as vm in order to be able to do $scope.$watch(vm.<property>)
        function(newValue, oldValue) {
            if (vm.name.length > 0) {
                var api = new HelloWorldApi({ domain: 'http://localhost:10010' });
                var hello = api.hello({ name: newValue });
                hello.then(function(greeting) {
                    vm.greeting = greeting;
                });
            } else {
                vm.greeting = "Hmmmm... emptiness... used to be " + oldValue;
            }
        });

});
