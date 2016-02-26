module.exports = (grunt) ->
  grunt.initConfig
    # read package info
    pkg: grunt.file.readJSON 'package.json'
    # coffee
    coffee:
      default:
        expand: yes
        cwd: 'app'
        src: ['**/*.coffee']
        dest: 'content/scripts/'
    # coffeelint
    coffeelint:
      options:
        configFile: 'coffeelint.json'
      default: ['app/*.coffee']
    # include source
    includeSource:
      options:
        templates:
          html:
            css: '<link rel="stylesheet" type="text/css" href="{filePath}" />'
            js: '<script src="{filePath}"></script>'
      default:
        files:
          'app/index.html': 'app/index.tpl.html'
    # less
    less:
      default:
        expand: yes
        cwd: 'app'
        src: ['**/*.less']
        dest: 'content/styles/'
    # wiredep
    wiredep:
      default:
        src: ['app/index.html']
  
  grunt.loadNpmTasks 'grunt-coffeelint'
  grunt.loadNpmTasks 'grunt-contrib-coffee'
  grunt.loadNpmTasks 'grunt-contrib-less'
  grunt.loadNpmTasks 'grunt-include-source'
  grunt.loadNpmTasks 'grunt-wiredep'
  
  grunt.registerTask 'default', ['coffee','coffeelint','less','includeSource', 'wiredep']
