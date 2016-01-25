module.exports = function (grunt) {
    
    require('load-grunt-tasks')(grunt);
    require('time-grunt')(grunt);
    
    grunt.initConfig({
        'swagger-js-codegen': {
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
                    dest: 'src/api'
                },
                dist: {
                }
            }
        }
    });

    grunt.registerTask('default', ['swagger-js-codegen']);
}
