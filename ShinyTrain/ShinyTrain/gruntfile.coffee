module.exports = (grunt) ->
  grunt.initConfig
    # read package info
    pkg: grunt.file.readJSON 'package.json'
    # clean
    clean:
      default: ['index.html']
    # coffee
    coffee:
      options:
        bare: yes
      default:
        expand: yes
        cwd: 'content/app/coffee'
        src: ['**/*.coffee']
        dest: 'content/app/scripts/'
        ext: '.js'
    # coffeelint
    coffeelint:
      options:
        configFile: 'coffeelint.json'
      default: ['content/app/coffee/**/*.coffee']
    # include source
    includeSource:
      options:
        templates:
          html:
            css: '<link rel="stylesheet" type="text/css" href="{filePath}" />'
            js: '<script src="{filePath}"></script>'
      default:
        files:
          'index.html': 'index.tpl.html'
    # less
    less:
      default:
        expand: yes
        cwd: 'content/app/less'
        src: ['**/*.less']
        dest: 'content/app/styles/'
    # wiredep
    wiredep:
      default:
        src: ['index.html']
  
  grunt.loadNpmTasks 'grunt-coffeelint'
  grunt.loadNpmTasks 'grunt-contrib-clean'
  grunt.loadNpmTasks 'grunt-contrib-coffee'
  grunt.loadNpmTasks 'grunt-contrib-less'
  grunt.loadNpmTasks 'grunt-include-source'
  grunt.loadNpmTasks 'grunt-wiredep'
  
  grunt.registerTask 'default', ['coffee','coffeelint','less','includeSource','wiredep']
