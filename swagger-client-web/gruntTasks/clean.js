'use strict';
module.exports = function(grunt) {
    
    grunt.config('clean',
    {
            all: '<%= settings.build.dst %>'
    });

}
