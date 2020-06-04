<template>
    <div id="questionModal" class="modal modal-fixed-footer" ref="questionModal">
        <div class="modal-title center">
            <br />
            <i class="medium material-icons">error_outline</i>
        </div>
        <div>
            <div class="modal-content center">
                <h6 v-html="question.text"></h6>
            
                <div style='padding:25px'>
                    <div class="btn-group" role="group">
                        <a href="#!"
                           @click.prevent="questionClick(true)"
                           class="modal-close waves-effect waves-light btn">
                            <i class="medium material-icons left">done</i>
                            <span>Да</span>
                        </a>
                        <a href="#!"
                           @click.prevent="questionClick(false)"
                           class="modal-close waves-effect waves-light btn">
                            <i class="medium material-icons left">do_not_disturb</i>
                            <span>Нет</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        props: ['question'],
        data: () => ({
            questionModal: null
        }),
        mounted() {
            setTimeout(() => {
                this.questionModal = M.Modal.init(this.$refs.questionModal, {
                    dismissible: true
                });
            }, 0)
        },
        methods: {
            questionClick(chooseVal) {
                this.$emit('questionClick', chooseVal)
            }
        },
        beforeDestroy() {
            if (this.questionModal && this.questionModal.destroy) {
                this.questionModal.destroy()
            }
        }

    }
</script>