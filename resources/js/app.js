import Vue from 'vue'
import Vuetify from 'vuetify'


window.Vue = Vue;
Vue.use(Vuetify)

import CookieConsent from "./component/CookieConsent"



const app = new Vue({
    el: '#app',
    components: {
        CookieConsent
    }
});