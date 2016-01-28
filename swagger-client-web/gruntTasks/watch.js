'use strict';
module.exports = function(grunt) {

    grunt.config('watch',
    {
        html: {
            files: ['<%= settings.build.src %>/**/*.html'],
            tasks: ['newer:copy:html'],
        },
        js: {
            files: ['<%= settings.build.src %>/**/*.js'],
            tasks: ['newer:copy:js'],
        },
        serve: {
            options: {
                livereload: {
                    host: 'localhost',
                    port: 8000
                }
            },
            files: ['<%= settings.build.dst %>/**/*.*']
        },
    });

}
