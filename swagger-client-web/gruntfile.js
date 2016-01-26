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
                dst: 'src/api'
            }
        }
    });

    grunt.registerTask('default', ['clean', 'swagger-js-codegen', 'copy']);

}
