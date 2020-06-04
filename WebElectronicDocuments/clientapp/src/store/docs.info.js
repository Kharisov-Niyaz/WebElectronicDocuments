export default {
    state: {},
    mutations: {},
    actions: {
        async downloadDocFile({ commit, getters }, { docId, fileName }) {
            let userId = getters.userId
            try {
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/GetDocFile/${userId}/${docId}/${fileName}`)
                if (response.ok) { // если HTTP-статус в диапазоне 200-299                    
                    let file = await response.blob();
                    if (!file) throw { code: 'ServerError' }

                    let url = window.URL.createObjectURL(file)
                    let link = document.createElement('a')
                    link.href = url
                    link.setAttribute('download', fileName)
                    document.body.appendChild(link)
                    link.click()
                    link.remove()
                }
                else throw { code: 'ServerError' }
            }
            catch (e) {
                commit('setError', e)
                throw e
            }
        },
        async setDocNormalInspection({ commit, getters }, { docId }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/UpdateDocNormalInspection/${docId}/${userId}`,
                    {
                        method: 'POST'
                    })

                if (response.ok) { // если HTTP-статус в диапазоне 200-299    
                    let json = await response.json();
                    if (!json) throw { code: 'ServerError' }
                    console.log(json)
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
        async setDocUrgency({ commit, getters }, { docId, urgencyVal }) {
            try {
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/UpdateDocUrgency/${userId}/${docId}/${urgencyVal}`,
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
        async getDocsList({ dispatch, commit, getters }) {
            try {
                let userId = getters.userId
                let userStage = getters.userInfo.stageId
                let userHead = getters.userInfo.head
                let groupId = getters.userInfo.groupId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/GetDocsList/${userId}/${userStage}/${groupId}/${userHead}`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
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
        },
        async getSearchDocsList({ dispatch, commit, getters }, data) {
            try {
                let userId = getters.userId
                let searchValue = data.searchDoc
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/GetSearchDocsList/${userId}/${searchValue}`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
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
        },
        async getDocJournalList({ dispatch, commit, getters }, data) {
            try {
                let docId = data.docId
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/GetDocJournalList/${userId}/${docId}`)

                if (response.ok) { // если HTTP-статус в диапазоне 200-299
                    let json = await response.json();
                    if (!json) {
                        throw { code: 'ServerError' }
                    }
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
        },
        async uploadData({ dispatch, commit, getters }, data) {
            try {
                let formData = data.formData
                let docId = data.docId
                let userId = getters.userId
                let response = await fetch(`${process.env.VUE_APP_BACKEND_SERVER_URL}/api/docs/uploaddata/${userId}/${docId}`, {
                    method: 'POST',
                    body: formData
                })
                if (response.ok) { }
                else {
                    throw { code: 'ServerError' }
                }
            }
            catch{
                commit('setError', e)
                throw e
            }
        }
    },
    getters: {}
}