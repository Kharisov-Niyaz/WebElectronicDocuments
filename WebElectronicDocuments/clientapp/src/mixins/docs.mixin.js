export default {
    methods: {
        async getDocsList() {
            return await this.$store.dispatch('getDocsList')
        },
        async getSearchDocsList(data) {
            return await this.$store.dispatch('getSearchDocsList', data)
        }
    }
}