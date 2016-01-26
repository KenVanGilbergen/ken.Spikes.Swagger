'use strict';
module.exports = function(grunt) {

    grunt.config('copy',
    {
        html: {
            files: [
                { cwd: '<%= settings.build.src %>', src: ['**/*.html'], dest: '<%= settings.build.dst %>', expand: true }
            ]
        },
        js: {
            files: [
                { cwd: '<%= settings.build.src %>', src: ['**/*.js'], dest: '<%= settings.build.dst %>', expand: true }
            ]
        }
    });

}
