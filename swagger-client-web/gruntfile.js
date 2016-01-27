module.exports = function(grunt) {

    require('time-grunt')(grunt);
    require('load-grunt-tasks')(grunt);
    grunt.task.loadTasks('gruntTasks');

    grunt.config.merge({
        settings: {
            build: {
                src: 'src',
                dst: '_site'
            },
            swagger: {
                dst: 'src/api',
                endpoints: {
                    helloWorld: 'http://127.0.0.1:10010/swagger'
                }
            }
        }
    });
    
    grunt.registerTask('rebuild', ['clean', 'swagger-js-codegen', 'copy']);
    grunt.registerTask('serve', ['rebuild', 'express', 'open:serve']);
    grunt.registerTask('refresh', ['serve', 'watch']);

    grunt.registerTask('default', ['rebuild']);

}
