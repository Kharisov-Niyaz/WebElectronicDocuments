﻿<template>
    <div>
        <div class="page-title">
            <h3>Загрузка данных</h3>
        </div>

        <Loader v-if="loading" />

        <div v-else class="row">           
            <a class="waves-effect waves-light btn modal-trigger" href="#uploadDataModal">
                <i class="material-icons left">open_in_new</i>
                <span>Модальное окно</span>
            </a>
            <div id="uploadDataModal" class="modal modal-fixed-footer" ref="uploadDataModal">
                <div class="modal-content">
                    <label>Выберите файл</label>
                    <div class="file-field input-field">
                        <div class="btn" :class="{disabled : loadingSmall} ">
                            <i class="material-icons left">folder_open</i>
                            <span>Открыть</span>
                            <input type="file" name="files" ref="files" multiple @change="fileSelected" />
                        </div>

                        <div class="file-path-wrapper">
                            <input class="file-path validate" type="text"
                                   placeholder="Файлы" ref="filesText" />
                        </div>
                    </div>
                    <div>
                        <button class="btn waves-effect waves-light" @click="fileUpload" :class="{disabled : loadingSmall} ">
                            Загрузить
                            <i class="material-icons right">file_download</i>
                        </button>
                        <div class="progress" v-if="loadingSmall">
                            <div class="indeterminate"></div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="#!" class="modal-close waves-effect waves-green btn-flat">
                        <i class="material-icons center">close</i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data: () => ({
            loading: true,
            loadingSmall: false,
            uploadDataModal: null,
            fileSelectedList: []
        }),
        metaInfo() {
            return { title: 'Загрузка данных' }
        },
        mounted() {
            //TODO GET DATA LIST

            setTimeout(() => {
                this.uploadDataModal = M.Modal.init(this.$refs.uploadDataModal, {
                    dismissible: true
                });
            }, 0)          
            
            this.loading = false
        },
        methods: {
            async fileUpload() {
                if (!this.fileSelectedList.length) {
                    this.$error('Выберите файл для загрузки')
                    return
                }
                let formData = new FormData()
                for (const file of this.fileSelectedList) {
                    formData.append('files', file, file.name)
                }

                try {
                    this.loadingSmall = true
                    await this.$store.dispatch('uploadData', formData)
                    this.$message('Загрузка прошла успешно')
                }
                catch (e) { }
                finally {
                    this.fileSelectedList = []
                    this.$refs.files.value = ''
                    this.$refs.filesText.value = ''
                    this.loadingSmall = false
                }
            },
            fileSelected(event) {
                this.fileSelectedList = event.target.files
            }
        },
        beforeDestroy() {
            if (this.uploadDataModal && this.uploadDataModal.destroy) {
                this.uploadDataModal.destroy()
            }
        }
    }

</script>