import Vue from 'vue'
import Vuetify from 'vuetify'


window.Vue = Vue;
Vue.use(Vuetify)

import axios from './axios'

const app = new Vue({
    el: '#app'
});