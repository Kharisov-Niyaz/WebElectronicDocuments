import Vue from 'vue'
import VueMeta from 'vue-meta'
import Vuelidate from 'vuelidate'
import Paginate from 'vuejs-paginate'
import VueNativeNotification from 'vue-native-notification'
//import VueDocPreview from 'vue-doc-preview'
import MessagePlugin from './utils/message.plugin.js'
import App from './App.vue'
import Router from './Router.js'
import Store from './store'
import Loader from './components/app/Loader.vue'
import DateFilter from './filters/date.filter.js'
import TooltipDirective from './directives/tooltip.directive.js'

import 'materialize-css/dist/js/materialize.min'

Vue.config.productionTip = false
Vue.use(VueNativeNotification, {
    // Automatic permission request before
    // showing notification (default: true)
    requestOnNotify: true
})
Vue.use(MessagePlugin)
Vue.use(VueMeta)
Vue.use(Vuelidate)
Vue.filter('date', DateFilter)
Vue.directive('tooltip', TooltipDirective)
Vue.component('Loader', Loader)
Vue.component('Paginate', Paginate)
//Vue.component('VueDocPreview', VueDocPreview)

new Vue({
    router: Router,
    store: Store,
    render: h => h(App),
}).$mount('#app')
