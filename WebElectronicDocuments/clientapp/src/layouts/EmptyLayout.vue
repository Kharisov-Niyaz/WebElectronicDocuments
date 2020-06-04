<template>
    <div class="grey darken-3 empty-layout">        
        <router-view />
    </div>
</template>

<script>    
    import Messages from '../utils/messages'
    export default {
        name: 'empty-layout',
        computed: {
            error() {
                return this.$store.getters.error
            }
        },
        watch: {
            error(fbError) {
                if (fbError) {
                    this.$error(Messages[fbError.message] || fbError.message || Messages[fbError.code] || 'Что-то пошло не так')
                    this.$store.commit('clearError')
                }
            }
        }
    }
</script>
<style scoped>
   
</style>