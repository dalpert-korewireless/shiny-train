module.exports = (grunt) ->
  grunt.initConfig
    # read package info
    pkg: grunt.file.readJSON 'package.json'
    # bower
    bower:
      default:
        dest: 'vendor/'
        css_dest: 'vendor/styles'
        fonts_dest: 'vendor/fonts'
        js_dest: 'vendor/scripts'
        options:
          keepExpandedHierarchy: no
          packageSpecific:
            'bootstrap':
              files: ['dist/css/bootstrap.css', 'dist/fonts/*', 'dist/js/bootstrap.js']
    # clean
    clean: ['compiled','vendor']
    # coffee
    coffee:
      default:
        expand: yes
        cwd: 'app'
        src: ['**/*.coffee']
        dest: 'compiled/scripts/'
    # coffeelint
    coffeelint:
      options:
        configFile: 'coffeelint.json'
      default: ['app/*.coffee']
    # less
    less:
      default:
        expand: yes
        cwd: 'app'
        src: ['**/*.less']
        dest: 'compiled/styles/'
  
  grunt.loadNpmTasks 'grunt-bower'
  grunt.loadNpmTasks 'grunt-coffeelint'
  grunt.loadNpmTasks 'grunt-contrib-clean'
  grunt.loadNpmTasks 'grunt-contrib-coffee'
  grunt.loadNpmTasks 'grunt-contrib-less'
  
  grunt.registerTask 'default', ['bower','coffee','coffeelint','less']
