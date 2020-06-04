<template>
    <nav class="navbar light-blue lighten-1">
        <div class="nav-wrapper">
            <div class="navbar-left">
                <a href="#" @click.prevent="$emit('click')">
                    <i class="material-icons black-text">dehaze</i>
                </a>
                <span class="black-text">{{date | date('datetime')}}</span>
            </div>

            <ul class="right hide-on-small-and-down">
                <li>
                    <a class="dropdown-trigger black-text" href="#" data-target="dropdown" ref="dropdown">
                        {{name}}
                        <i v-if="!loading" class="material-icons right">arrow_drop_down</i>
                    </a>

                    <ul v-if="!loading" id="dropdown" class="dropdown-content">
                        <li>
                            <router-link to="/profile" class="black-text">
                                <i class="material-icons">account_circle</i>
                                Профиль
                            </router-link>
                        </li>
                        <li class="divider" tabindex="-1"></li>
                        <li>
                            <a href="#" class="black-text" @click.prevent="logout">
                                <i class="material-icons">assignment_return</i>
                                Выход
                            </a>
                        </li>
                    </ul>
                    <ul v-else class="progress">
                        <li>
                            <div class="indeterminate"></div>
                        </li>
                    </ul>
                </li>

            </ul>           
        </div>
    </nav>

</template>


<script>
    export default {
        data: () => ({
            date: new Date(),
            interval: null,
            dropdown: null,
            loading: false
        }),
        methods: {
            async logout() {
                this.loading = true
                await this.$store.dispatch('logout')
                this.loading = false
                this.$router.push('/login')
            }
        },
        computed: {
            name() {
                return this.$store.getters.userInfo.name || 'undefind'
            }
        },
        mounted() {
            this.interval = setInterval(() => {
                this.date = new Date()
            }, 1000)
            this.dropdown = M.Dropdown.init(this.$refs.dropdown, {
                constrainWidth: false
            })
        },
        beforeDestroy() {
            clearInterval(this.interval)
            if (this.dropdown && this.dropdown.destroy) {
                this.dropdown.destroy()
            }
        }
    }</script>

<style scoped>
    body {
        font-weight: bold;
    }
</style>
