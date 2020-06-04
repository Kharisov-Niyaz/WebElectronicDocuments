<template>
    <component :is="layout">
        <router-view />
    </component>
</template>

<script>
    import EmptyLayout from './layouts/EmptyLayout.vue'
    import MainLayout from './layouts/MainLayout.vue'

    export default {
        name: 'app',

        computed: {
            layout() {
                return (this.$route.meta.layout || 'empty') + '-layout'
            }
        },
        mounted() {

        },
        components: {
            EmptyLayout,
            MainLayout
        }
    }
</script>

<style lang="css" scoped>
    @import url('https://fonts.googleapis.com/icon?family=Material+Icons');
    @import '~materialize-css/dist/css/materialize.min.css';
    @import './css/app.css';
    @import './css/btnGroup.css';
</style>
