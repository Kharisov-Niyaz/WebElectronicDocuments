export default {
    bind(el, binding, vnode) {
        M.Tooltip.init(el, {
            html: binding.value
        })
    },
    unbind(el) {
        const tooltip = M.Tooltip.getInstance(el)

        if (tooltip && tooltip.destroy) {
            tooltip.destroy()
        }
    }
}