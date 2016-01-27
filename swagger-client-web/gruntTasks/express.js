'use strict';
module.exports = function(grunt) {

    grunt.config('express',
    {
        serve: {
            options: {
                script: 'lib/server.js'
            }
        }
    });

}
