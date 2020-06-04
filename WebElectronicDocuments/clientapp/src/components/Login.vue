<template>
    <form class="card auth-card" @submit.prevent="submitHandler">
        <div class="card-content">
            <span class="card-title center-align">Электронный документооборот</span>
            <div class="input-field">
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
                <input id="password"
                       type="password"
                       v-model.trim="password"
                       :class="{invalid: ($v.password.$dirty && !$v.password.required) || ($v.password.$dirty && !$v.password.minLength)}">
                <label for="password">Введите пароль</label>
                <small class="helper-text invalid"
                       v-if="$v.password.$dirty && !$v.password.required">Введите пароль</small>
                <small class="helper-text invalid"
                       v-else-if="$v.password.$dirty && !$v.password.minLength">Минимальное количество символов {{$v.password.$params.minLength.min}}</small>
            </div>
        </div>
        <div class="card-action">
            <div>
                <button class="btn waves-effect waves-light auth-submit" :class="{disabled : loading} " type="submit">
                    Авторизоваться
                    <i class="material-icons right">send</i>
                </button>
                <div class="progress" v-if="loading">
                    <div class="indeterminate"></div>
                </div>
            </div>

            <p class="center">
                Зарегистрироваться
                <router-link to="/register">Перейти</router-link>
            </p>
        </div>
    </form>
</template>

<script>
    import { email, required, minLength } from 'vuelidate/lib/validators'
    export default {
        name: 'login',
        metaInfo() {
            return {
                title: 'Авторизация'
            }
        },
        data: () => ({
            email: '',
            password: '',
            loading: false
        }),
        validations: {
            email: { email, required },
            password: { required, minLength: minLength(6) }
        },
        mounted() {

        },
        methods: {
            async submitHandler() {
                if (this.$v.$invalid) {
                    this.$v.$touch()
                    return
                }

                const formData = {
                    email: this.email,
                    password: this.password
                }

                try {
                    this.loading = true
                    await this.$store.dispatch('login', formData)
                    this.$router.push('/')
                } catch (e) { }
                finally {
                    this.loading = false
                }
            }
        }
    }
</script>

<style scoped>
</style>