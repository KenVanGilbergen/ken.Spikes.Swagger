'use strict';
module.exports = function(grunt) {

    grunt.config('swagger-js-codegen',
    {
        queries: {
            options: {
                apis: [
                    {
                        swagger: 'http://127.0.0.1:10010/swagger',
                        className: 'HelloWorld',
                        moduleName: 'HelloWorld', // This is the model and file name
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
