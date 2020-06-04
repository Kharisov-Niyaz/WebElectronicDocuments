<template>
    <ul class="sidenav app-sidenav" :class="{open: value}">
        <router-link v-for="link in links"
                     :key="link.url"
                     tag="li"
                     active-class="active"
                     :to="link.url"
                     :exact="link.exact">

            <a v-if="!link.isHead || link.isHead == head" href="#" class="waves-effect waves-light-blue pointer">
                <i class="material-icons left">{{link.icon}}</i>{{link.title}}
            </a>
        </router-link>
    </ul>
</template>

<script>
    export default {
        props: ['value'],
        data: () => ({
            links: [
                { title: 'Задачи', url: '/', exact: true, icon: 'view_list', isHead: false },
                { title: 'Журнал', url: '/journal', icon: 'art_track', isHead: false },
                { title: 'Сотрудники', url: '/users', icon: 'people', isHead: true }
            ],
            head: false
        }),
        mounted() {
            this.head = this.$store.getters.userHead
        }
    }</script>



