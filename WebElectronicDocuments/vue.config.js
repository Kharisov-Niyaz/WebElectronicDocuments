const fs = require("fs");
module.exports = {
    pages: {
        index: {
            entry: './clientapp/src/main.js'
        }
    },
    devServer: {
        host: 'localhost',
        https: {
            key: fs.readFileSync("./certs/localhost-key.pem"),
            cert: fs.readFileSync("./certs/localhost.pem")
        },
        overlay: {
            warnings: false,
            errors: false
        }
    }
}