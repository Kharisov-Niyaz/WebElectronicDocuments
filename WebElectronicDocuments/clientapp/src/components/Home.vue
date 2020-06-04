<template>
    <div>
        <div class="page-title">
            <h3>Список задач</h3>
        </div>

        <Loader v-if="loading" />

        <div v-else class="row">
            <Question :question="question"
                      @questionClick="questionClick" />
            <Upload :userId="userId"
                    :docId="docId"
                    @getFileName="getFileName" />
            <Journal :userId="userId"
                     :docId="docId"
                     :userListAll="userListAll"/>
            <div class="input-field col s12 m12 l12">
                <i class="material-icons prefix">search</i>
                <input type="text" id="searchInput" v-model="searchDoc">
                <label for="searchInput">Поиск</label>
            </div>
            <div class="progress" v-if="loadingSmall">
                <div class="indeterminate"></div>
            </div>
            <div class="col s12 m12 l12">
                <div class="card grey lighten-5 z-depth-2" v-for="(item, index) in dataListTask" :key="item.id">
                    <div class="card-text waves-effect waves-block waves-light">
                        <span class="badge white-text green left"
                              data-badge-caption="обновлено"
                              v-if="item.docAction.update">
                        </span>
                        <span class="badge white-text red left"
                              data-badge-caption="срочно"
                              v-if="item.docAction.urgency">
                        </span>
                        <span class="badge white-text lime left"
                              data-badge-caption="закреплен"
                              v-if="userStage == 2 && item.docAction.normalInspectionId > 0">
                        </span>
                        <span class="badge white-text"
                              :class="stageList[item.docAction.stageId].Color"
                              :data-badge-caption="stageList[item.docAction.stageId].Name">
                        </span>
                    </div>
                    <div class="card-content">
                        <p class="card-title activator grey-text text-darken-4">
                            <b>{{item.customer}}</b>
                            <hr />
                            <b>{{item.name}}</b>
                            <i class="material-icons right">more_vert</i>
                        </p>
                        <p><i>Исполнитель: <b>{{item.executor}}</b></i></p>
                        <p v-if="userHead ||  userStage != 1"><i>Сотрудник: <b>{{item.initiatorName}}</b></i></p>
                        <p v-if="item.docAction.normalInspectionId"><i>Нормоконтроль: <b>{{userListAll[item.docAction.normalInspectionId]}}</b></i></p>
                        <p><i>Дата создания:<b>{{ item.createDate |date('date') }}</b></i></p>
                        <p><i>Дата завершения:<b>{{ item.closeDate |date('date') }}</b></i></p>
                        <p>
                            <label>
                                <input type="checkbox" onclick="this.checked=!this.checked;" :checked="item.payment" />
                                <span>Договор оплачен</span>
                            </label>
                        </p>
                    </div>
                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4"> {{item.name}}<i class="material-icons right">close</i></span>
                        <p>{{item.description}}</p>
                    </div>

                    <div class="card-action">
                        <div style='padding:5px'>
                            <div class="btn-group" role="group">
                                <a :disabled="!item.docAction.fileName"
                                   @click.prevent="downloadDocFile(item.id, item.docAction.fileName)"
                                   href="#!"
                                   class="waves-effect waves-light btn"
                                   v-tooltip="'Скачать документ'"
                                   download>
                                    <i class="medium material-icons">insert_drive_file</i>
                                </a>
                                <a href="#uploadDataModal"
                                   @click.prevent="uploadDataClick(item.id)"
                                   v-tooltip="'Загрузка документа'" class="waves-effect waves-light btn modal-trigger">
                                    <i class=" medium material-icons">file_upload</i>
                                    <span></span>
                                </a>
                                <a href="#journalModal"
                                   @click.prevent="uploadDataClick(item.id)"
                                   v-tooltip="'Статистика документа'" class="waves-effect waves-light btn modal-trigger">
                                    <i class="medium material-icons">format_list_bulleted</i>
                                    <span></span>
                                </a>
                                <a href="#questionModal"
                                   :disabled="item.docAction.stageId != userStage || userStage == 1"
                                   @click.prevent="signDocClick(item.id, -1)"
                                   v-tooltip="'Возврат документа'" class="waves-effect waves-light btn modal-trigger">
                                    <i class="medium material-icons">reply</i>
                                    <span></span>
                                </a>
                                <a href="#questionModal"
                                   :disabled="item.docAction.stageId != userStage"
                                   @click.prevent="signDocClick(item.id, 1)"
                                   v-tooltip="'Перевод документа'" class="waves-effect waves-light btn  modal-trigger">
                                    <i class="medium material-icons rotate">reply</i>
                                    <span></span>
                                </a>
                            </div>

                            <div v-if="userStage == 1" class="switch right">
                                <label>
                                    <input :disabled="!userHead"
                                           v-model="item.docAction.urgency"
                                           @change="changeDocUrgency(item.id, item.docAction.urgency)"
                                           type="checkbox">
                                    <span class="lever"></span>
                                    <b>Срочно</b>
                                </label>
                            </div>
                            <div v-if="userStage == 2" class="switch right">
                                <label>
                                    <input :disabled="userId != item.docAction.normalInspectionId && item.docAction.normalInspectionId > 0"
                                           :checked="item.docAction.normalInspectionId > 0"
                                           @change="changeDocNormalInspection(item.id, $event)"
                                           type="checkbox">
                                    <span class="lever"></span>
                                    <b>Закрепить</b>
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import Upload from './child/Upload.vue'
    import Journal from './child/Journal.vue'
    import Question from './child/Question.vue'
    import DocsMixin from '../mixins/docs.mixin.js'
    export default {
        mixins: [DocsMixin],
        data: () => ({
            loading: true,
            loadingSmall: false,
            userId: 0,
            userStage: 0,
            userHead: false,
            docId: 0,
            signType: 0,
            searchDoc: '',
            question: {},
            dataList: [],
            stageList: [],
            userList: [],
            userListAll: []
        }),
        metaInfo() {
            return { title: 'Главная страница' }
        },
        computed: {
            dataListTask() {
                return this.dataList.filter(f => {
                    if (!this.searchDoc)
                        return true

                    return f.name.toUpperCase().indexOf(this.searchDoc.toUpperCase()) !== -1
                })
            }
        },
        async mounted() {
            try {
                this.userId = this.$store.getters.userId
                this.userStage = this.$store.getters.userInfo.stageId
                this.userHead = this.$store.getters.userHead
                this.stageList = this.$store.getters.stages
                this.userList = this.$store.getters.users
                this.userListAll = this.$store.getters.usersAll
                this.dataList = await this.getDocsList()

                this.$notification.show('Hello World', {
                    body: 'This is an example!'
                }, {})
            }
            catch (e) { }
            finally {
                this.loading = false
            }
        },
        methods: {
            uploadDataClick(docId) {
                this.docId = docId
            },
            getFileName(fileName) {
                if (fileName) {
                    const docId = this.docId
                    try {
                        const docIndex = this.dataList.findIndex(f => f.id === docId)                        
                        this.dataList[docIndex].docAction.fileName = fileName
                    }
                    catch{ }
                }
            },
            signDocClick(docId, signType) {
                this.docId = docId
                this.signType = signType
                this.question = {
                    text: signType > 0 ? 'Вы уверены, что хотите <b>подписать</b> документ?' :
                        'Вы уверены, что хотите <b>вернуть</b> документ?'
                }
            },
            async questionClick(chooseVal) {
                if (chooseVal) {
                    const docId = this.docId
                    const newStage = this.signType
                    try {
                        const docIndex = this.dataList.findIndex(f => f.id === docId)
                        await this.$store.dispatch('setDocNewStage', {
                            docId,
                            newStage
                        })
                        if (this.userStage == 3 && newStage < 0)
                            this.dataList[docIndex].docAction.stageId = 1
                        else
                            this.dataList[docIndex].docAction.stageId += newStage
                        this.dataList[docIndex].docAction.update = true
                        this.$message('Успешная смена этапа')
                    }
                    catch{ }
                }
            },
            async changeDocUrgency(docId, urgencyVal) {
                try {
                    await this.$store.dispatch('setDocUrgency', {
                        docId,
                        urgencyVal
                    })
                }
                catch{ }
            },
            async downloadDocFile(docId, fileName) {
                try {
                    await this.$store.dispatch('downloadDocFile', {
                        docId,
                        fileName
                    })
                }
                catch{ }
            },
            async changeDocNormalInspection(docId, event) {
                try {
                    const docIndex = this.dataList.findIndex(f => f.id === docId)
                    await this.$store.dispatch('setDocNormalInspection', {
                        docId
                    })
                    this.dataList[docIndex].docAction.normalInspectionId = event.target.checked ? this.userId : 0
                    this.$message('Успешно сохранено')
                }
                catch{ }
            }
        },
        components: {
            Upload, Journal, Question
        }
    }

</script>
