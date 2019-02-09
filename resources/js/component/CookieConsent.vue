<template>
    <v-alert :value="isActive" color="purple" type="info">
        <span>    
            We use cookies to improve your expierence on our site.
        </span>
        <v-btn href="/home/privacy">Learn More</v-btn>
        <v-btn @click="accept">
            <span aria-hidden="true">Accept</span>
        </v-btn>
    </v-alert>
</template>

<script>
export default {
    props: ['cookieString'],
    data() {
        return {
            isActive: true
        }
    },
    methods: {
        accept() {
            document.cookie = this.cookieString
            this.isActive = false;
        }
    }
}
</script>

