import Vue from 'vue'
import Vuex from 'vuex'
import VuexPersistedState from 'vuex-persistedstate'
import VuexMutationsShared from 'vuex-shared-mutations'
import Auth from './auth.js'
import UserInfo from './user.info.js'
import DocsInfo from './docs.info.js'
import StagesInfo from './stages.info.js'

Vue.use(Vuex)

export default new Vuex.Store({
    plugins: [VuexMutationsShared({ predicate: ["setError", "clearError"] }),
    VuexPersistedState({ storage: window.localStorage })],
    state: {
        error: null
    },
    mutations: {
        setError(state, error) {
            state.error = error
        },
        clearError(state) {
            state.error = null
        }
    },
    actions: {

    },
    getters: {
        error: s => s.error
    },
    modules: {
        Auth, UserInfo, DocsInfo, StagesInfo
    }
})
