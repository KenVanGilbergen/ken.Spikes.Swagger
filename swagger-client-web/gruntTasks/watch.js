'use strict';
module.exports = function(grunt) {

    grunt.config('watch',
    {
        html: {
            files: ['<%= settings.build.src %>/**/*.html'],
            tasks: ['newer:copy:html'],
        },
        serve: {
            options: {
                livereload: {
                    host: 'localhost',
                    port: 8000
                }
            },
            files: ['<%= settings.build.dst %>/**/*.html']
        },
    });

}
