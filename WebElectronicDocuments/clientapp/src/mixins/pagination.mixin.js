import _ from 'lodash'
export default
    {
        data() {
            return {
                page: +this.$route.query.page || 1,
                pageSize: 25,
                pageCount: 0,
                allItems: [],
                partItems: []
            }
        },
        methods: {
            pageChangeHandler(page) {
                this.$router.push(`${this.$route.path}?page=${page}`)
                this.partItems = this.allItems[page - 1] || this.allItems[0]
            },
            setupPagination(allItems) {
                this.allItems = _.chunk(allItems, this.pageSize)
                this.pageCount = _.size(this.allItems)
                this.partItems = this.allItems[this.page - 1] || this.allItems[0]
            }
        }
    }