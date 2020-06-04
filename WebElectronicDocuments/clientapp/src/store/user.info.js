export default {
    state: {
        userInfo: {},
        users: [],
        usersAll:[]
    },
    mutations: {
        setInfo(state, info) {
            state.userInfo = info
        },
        setUsers(state, users) {
            state.users = users
        },
        setUsersAll(state, usersAll) {
            state.usersAll = usersAll
        },
        clearInfo(state) {
            window.localStorage.clear()
            state.userInfo = {}
            state.users = []
            state.usersAll = []
        }
    },
    actions: {
        async setUserInfo({ dispatch, commit, getters }, toUpdate) {
            const updateData = { ...getters.userInfo, ...toUpdate }
            try {
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/user/UpdateUser`,
                    {
                        method: 'POST',
                        headers: {
                            'Accept': 'application/json',
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(updateData)
                    })
                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) throw { code: 'ServerError' }
                    commit('setInfo', updateData)
                }
                else {
                    let error = await response.json()
                    if (Object.keys(error).length)
                        throw { message: error.message }
                    else
                        throw { code: 'ServerError' }
                }

            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        },
        async getUserJournalList({ dispatch, commit, getters }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/user/GetUserJournalList/${userId}`)
                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
                    return json
                }
                else throw { code: 'ServerError' }

            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        },
        async getUserList({ commit, getters }) {
            try {
                let groupId = getters.userInfo.groupId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/user/GetUserList/${groupId}`)
                
                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) throw { code: 'ServerError' }                    
                    commit('setUsers', json)
                }
                else throw { code: 'ServerError' }
            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        },        
        async getAllUserList({ commit, getters }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/user/GetAllUserList`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) throw { code: 'ServerError' }
                    commit('setUsersAll', json)
                }
                else throw { code: 'ServerError' }
            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        }
    },
    getters: {
        userInfo: state => state.userInfo,
        userId: state => state.userInfo.id,
        userHead: state => state.userInfo.head,
        users: state => state.users,
        usersAll: state => state.usersAll
    }
}