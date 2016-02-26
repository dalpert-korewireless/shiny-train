module.export = (grunt) ->
  grunt.initConfig
    pkg: grunt.file.readJSON 'package.json'
    bower:
      css_dest: 'vendor/style'
      fonts_dest: 'vendor/fonts'
      js_dest: 'vendor/scripts'
      options:
        keepExpandedHierarchy: no
        packageSpecific:
          'bootstrap':
            files: ['dist/css/bootstrap.css', 'dist/fonts/*', 'dist/js/bootstrap.js']
    clean: ['compiled','vendor']
    coffee:
      compile:
        expand: yes
        cwd: 'app'
        src: '**/*.coffee'
        dest: 'compiled'
  
  grunt.loadNpmTasks 'grunt-bower'
  grunt.loadNpmTasks 'grunt-contrib-clean'
  grunt.loadNpmTasks 'grunt-contrib-coffee'
  
  grunt.registerTask 'default', ['bower','coffee']
