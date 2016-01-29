'use strict';
module.exports = function(grunt) {

    grunt.config('swagger-js-codegen',
    {
        queries: {
            options: {
                apis: [
                    {
                        swagger: '<%= settings.swagger.endpoints.helloWorld %>',
                        moduleName: 'api.HelloWorld', 
                        className: 'helloWorldFactory',
                        fileName: 'helloWorldFactory.js', 
                        angularjs: true
                    }
                ],
                dest: '<%= settings.swagger.dst %>'
            },
            dist: {
            }
        }
    });

}
