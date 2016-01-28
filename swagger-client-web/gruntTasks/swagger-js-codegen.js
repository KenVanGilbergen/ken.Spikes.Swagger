'use strict';
module.exports = function(grunt) {

    grunt.config('swagger-js-codegen',
    {
        queries: {
            options: {
                apis: [
                    {
                        swagger: '<%= settings.swagger.endpoints.helloWorld %>',
                        className: 'HelloWorldApi',
                        moduleName: 'HelloWorldApi', // This is the model and file name
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
