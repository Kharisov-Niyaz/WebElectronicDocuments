<template>
    <div>
        <div class="page-title">
            <h3>Журнал пользователя</h3>
        </div>

        <Loader v-if="loading" />

        <div v-else class="row">
            <table class="striped highlight responsive-table">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Сообщение</th>
                        <th>Дата</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(item, index) in partItems" :key="item.id">
                        <th>{{++index}}</th>
                        <th>{{item.message}}</th>
                        <th>{{item.createDate | date('datetime')}}</th>
                    </tr>
                </tbody>
            </table>
            <Paginate v-model="page"
                      :page-count="pageCount"
                      :click-handler="pageChangeHandler"
                      :prev-text="'←Назад'"
                      :next-text="'Вперед→'"
                      :container-class="'pagination'"
                      :page-class="'pagination-item waves-effect'"
                      />
        </div>
    </div>
</template>
<script>
    import PaginationMixin from '../mixins/pagination.mixin.js'
    export default {
        mixins: [PaginationMixin], 
        name: 'journal',
        metaInfo() {
            return {
                title: 'Журнал пользователя'
            }
        },
        data: () => ({
            loading: true,
            userJournal: []
        }),
        async mounted() {
            try {
                this.userJournal = await this.$store.dispatch('getUserJournalList')
                this.setupPagination(this.userJournal)
            }
            catch (e) { }
            finally { this.loading = false }
        }
    }
</script>