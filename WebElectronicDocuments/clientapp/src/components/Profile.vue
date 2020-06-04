<template>
    <div>
        <div class="page-title">
            <h3>Профиль пользователя</h3>
        </div>

        <Loader v-if="loading" />

        <div v-else class="row">
            <form class="form" @submit.prevent="submitHandler">

                <div class="input-field">
                    <i class="material-icons prefix">email</i>
                    <input id="email"
                           type="text"
                           v-model.trim="email"
                           :class="{invalid: ($v.email.$dirty && !$v.email.required) || ($v.email.$dirty && !$v.email.email)}">
                    <label for="email">Email</label>
                    <small class="helper-text invalid"
                           v-if="$v.email.$dirty && !$v.email.required">Введите Email</small>
                    <small class="helper-text invalid"
                           v-else-if="$v.email.$dirty && !$v.email.email">Введите кооректный Email</small>
                </div>

                <div class="input-field">
                    <i class="material-icons prefix">person</i>
                    <input id="password"
                           type="text"
                           v-model.trim="password"
                           :class="{invalid: ($v.password.$dirty && !$v.password.required) ||
                           ($v.password.$dirty && !$v.password.minLength) ||
                           ($v.password.$dirty && !$v.password.maxLength)}">
                    <label for="name">Пароль пользователя</label>
                    <small class="helper-text invalid"
                           v-if="$v.password.$dirty && !$v.password.required">Введите пароль пользователя</small>
                    <small class="helper-text invalid"
                           v-else-if="$v.password.$dirty && !$v.password.minLength">Минимальное количество символов {{$v.name.$params.minLength.min}}</small>
                    <small class="helper-text invalid"
                           v-else-if="$v.password.$dirty && !$v.password.maxLength">Максимальное количество символов {{$v.name.$params.maxLength.max}}</small>
                </div>


                <button class="btn waves-effect waves-light" type="submit">
                    Сохранить
                    <i class="material-icons right">send</i>
                </button>
            </form>
        </div>
    </div>
</template>
<script>
    import { mapGetters } from 'vuex'
    import { email, required, minLength, maxLength } from 'vuelidate/lib/validators'
    export default {
        data: () => ({
            loading: true,
            password: '',
            email: ''
        }),
        metaInfo() {
            return {
                title: 'Профиль пользователя'
            }
        },
        validations: {
            password: { required, minLength: minLength(6), maxLength: maxLength(30) },
            email: { email, required }
        },
        computed: {
            ...mapGetters(['userInfo'])
        },
        mounted() {
            this.password = this.userInfo.password
            this.email = this.userInfo.email
            setTimeout(() => {
                M.updateTextFields()
            })
            this.loading = false
        },
        methods: {
            async submitHandler() {
                if (this.$v.$invalid) {
                    this.$v.$touch()
                    return
                }

                try {                   
                    await this.$store.dispatch('setUserInfo', {
                        password: this.password,
                        email: this.email
                    })
                    this.$message('Изменения сохранены')
                } catch (e) { }
            }
        }
    }
</script>