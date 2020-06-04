<template>
    <div id="journalModal" class="modal modal-fixed-footer" ref="journalModal">
        <div class="modal-title center">
            <h6>Журнал документа</h6>
        </div>
        <Loader v-if="loading" />
        <div v-else>
            <div class="modal-content">
                <table class="highlight responsive-table">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Сообщение</th>
                            <th>Тип</th>
                            <th>Пользователь</th>
                            <th>Дата</th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr v-for="(item, index) of journalList" :key="item.id"
                            :class="{'deep-purple lighten-5 black-text' : (item.eventType == 1)}">
                            <td>{{++index}}</td>
                            <td>{{item.message}}</td>
                            <td>
                                <i v-if="item.eventType == 0" class="material-icons left rotate">reply</i>
                                <i v-if="item.eventType == 1" class="material-icons left">reply</i>
                                <i v-if="item.eventType == 2" class="material-icons left">insert_drive_file</i>
                                <i v-if="item.eventType == 3" class="material-icons left">file_upload</i>
                                <i v-if="item.eventType == 4" class="material-icons left">error_outline</i>
                                <i v-if="item.eventType == 5" class="material-icons left">person</i>

                                <b :class="{'green-text' :(item.eventType == 0),
                                            'red-text' :(item.eventType == 1),
                                            'blue-text' :  (item.eventType != 0 && item.eventType != 1)}">
                                    <strong v-if="item.eventType == 0">Перевод</strong>
                                    <strong v-if="item.eventType == 1">Возрат</strong>
                                    <strong v-if="item.eventType != 0 && item.eventType != 1">Сообщение</strong>
                                </b>
                            </td>
                            <td>{{userListAll[item.userId]}}</td>
                            <td>{{item.createDate |date('datetime')}}</td>
                        </tr>
                    </tbody>
                </table>

            </div>
            <div class="modal-footer">
                <a href="#!" class="modal-close waves-effect waves-green btn-flat">
                    <i class="material-icons center">close</i>
                </a>
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        props: ['userId', 'docId', 'userListAll'],
        data: () => ({
            loading: false,
            journalModal: null,
            journalList: []
        }),
        mounted() {
            setTimeout(() => {
                let context = this
                this.journalModal = M.Modal.init(this.$refs.journalModal, {
                    dismissible: true,
                    onCloseEnd: function () { },
                    onOpenStart: async function () {
                        let value = context.docId
                        if (value) {
                            try {
                                context.loading = true
                                let docId = value
                                context.journalList = await context.$store.dispatch('getDocJournalList', { docId })
                            }
                            catch (e) { }
                            finally {
                                context.loading = false
                            }
                        }
                    }
                });
            }, 0)
        },
        methods: {},
        beforeDestroy() {
            if (this.journalModal && this.journalModal.destroy) {
                this.journalModal.destroy()
            }
        }
    }
</script>