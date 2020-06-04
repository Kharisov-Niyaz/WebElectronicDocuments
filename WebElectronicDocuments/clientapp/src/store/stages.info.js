export default {
    state: {
        stages: []
    },
    mutations: {
        setStages(state, stages) {
            state.stages = stages
        }
    },
    actions: {
        async setDocNewStage({ commit, getters }, { docId, newStage }) {
            try {
                let userId = getters.userId
                let userStage = getters.userInfo.stageId                
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/UpdateDocStage/${userId}/${userStage}/${docId}/${newStage}`,
                    {
                        method: 'POST'
                    })
                if (response.ok) { // если HTTP-статус в диапазоне 200-299

                    let json = await response.json();
                    if (!json) throw { code: 'ServerError' }
                }
                else throw { code: 'ServerError' }
            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        },
        async getStageList({ dispatch, commit, getters }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/GetStageList`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
                    commit('setStages', json)
                    return json
                }
                else {
                    throw { code: 'ServerError' }
                }
            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        }
    },
    getters: {
        stages: s => s.stages
    }
}