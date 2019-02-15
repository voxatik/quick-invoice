
const mix = require('laravel-mix')

mix.setPublicPath("wwwroot")

mix.js('resources/js/app.js', 'wwwroot/js/site.js')
   .sass('resources/sass/app.scss', 'wwwroot/css/site.css')
   .version()