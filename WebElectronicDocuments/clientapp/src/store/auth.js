export default {
    state: {},
    mutations: {},
    actions: {
        async login({ dispatch, commit, getters }, { email, password }) {
            try {
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/auth/login/${email}/${password}`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'UserNotFound' }
                    }

                    commit('setInfo', json)

                    /**/
                    await dispatch('getStageList')
                    await dispatch('getAllUserList')
                    if (getters.userInfo.head && getters.userInfo.stageId == 1)
                        await dispatch('getUserList')                       
                    /**/
                }
                else {
                    let error = await response.json()
                    if (Object.keys(error).length)
                        throw { message: error.message }
                    else
                        throw { code: 'ServerError' }
                }

            } catch (e) {
                commit('setError', e)
                throw e
            }
        },
        async logout({ dispatch, commit, getters }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/auth/logout/${userId}`, {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    }
                })

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
                }
                else {
                    throw { code: 'ServerError' }
                }
                commit('clearInfo')
            } catch (e) {
                commit('setError', e)
                throw e
            }
        }
    }
}