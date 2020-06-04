import Vue from 'vue'
import VuexRouter from 'vue-router'
import Store from './store/index.js'

Vue.use(VuexRouter)

const router = new VuexRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes: [
        {
            path: '/',
            name: 'home',
            meta: { layout: 'main', title: 'Home', auth: true, head: false },
            component: () => import('./components/Home.vue')
        },
        {
            path: '/login',
            name: 'login',
            meta: { layout: 'empty', title: "Login" },
            component: () => import('./components/Login.vue')
        },
        {
            path: '/journal',
            name: 'journal',
            meta: { layout: 'main', auth: true, head: false },
            component: () => import('./components/Journal.vue')
        },
        {
            path: '/loaddata',
            name: 'loaddata',
            meta: { layout: 'main', auth: true, head: false },
            component: () => import('./components/LoadData.vue')
        },
        {
            path: '/stagedata',
            name: 'stagedata',
            meta: { layout: 'main', auth: true, head: false },
            component: () => import('./components/StageData.vue')
        },
        {
            path: '/profile',
            name: 'profile',
            meta: { layout: 'main', auth: true, head: false },
            component: () => import('./components/Profile.vue')
        },
        {
            path: '/users',
            name: 'users',
            meta: { layout: 'main', auth: true, head: true },
            component: () => import('./components/Users.vue')
        },
        {
            path: "*",
            meta: { layout: 'main', title: 'Home', auth: true, head: false },
            component: () => import('./components/Home.vue')
        }
    ]
})

router.beforeEach((to, from, next) => {
    const currentUserId = Store.getters.userId
    const currentUserHead = Store.getters.userHead
    const requireAuth = to.matched.some(record => record.meta.auth)
    const requireHead = to.matched.some(record => record.meta.head)

    if (requireAuth && !currentUserId) {
        next('/login')
    } else {
        if (requireHead && currentUserHead)
            next()
        else if (requireHead && !currentUserHead)
            next('/')
        else
            next()
    }
})

export default router