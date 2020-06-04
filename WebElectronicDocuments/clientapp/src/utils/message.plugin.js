export default {
	install(Vue) {
		Vue.prototype.$message = function (html) {
			const Icon = '<i class="material-icons left">done</i>';
			M.toast({
				html: Icon + html,
				classes: 'green darken-3'
			})
		}

		Vue.prototype.$error = function (html) {
			const Icon = '<i class="material-icons left">error</i>';
			M.toast({
				html: Icon + html,
				classes: 'red darken-3'
			})
		}
	}
}
