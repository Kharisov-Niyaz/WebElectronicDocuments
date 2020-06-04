const path = require('path');
const webpack = require('webpack');
const Dotenv = require('dotenv-webpack');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const HtmlWebpackPlugin = require('html-webpack-plugin')
const CopyWebpackPlugin = require('copy-webpack-plugin')
const OptimizeCssAssetsWebpackPlugin = require('optimize-css-assets-webpack-plugin')
const TerserWebpackPlugin = require('terser-webpack-plugin')
const isDev = process.env.NODE_ENV === 'development';
const isProd = !isDev
const optimization = () => {
    const config = {
        splitChunks: {
            chunks: 'all'
        }
    }

    if (isProd) {
        config.minimize = true,
            config.minimizer = [
                new OptimizeCssAssetsWebpackPlugin({}),
                new TerserWebpackPlugin()
            ]
    }
    return config
}

module.exports = {
    mode: 'production' /*'development'*/,
    entry: { main: ['@babel/polyfill', './clientapp/src/main.js'] },
    output: {
        path: path.resolve(__dirname + '/clientapp/public', 'dist'),
        filename: '[name].[contenthash].js'
    },
    plugins: [
        new webpack.HotModuleReplacementPlugin()
    ],
    module: {
        rules: [
            {
                test: /\.vue$/,
                exclude: /node_modules/,
                loader: "vue-loader"/*,
                options: {
                    loader: {
                        css: 'vue-style-loader!css-loader'
                    }
                }*/
            },
            {
                test: /\.js$/,
                exclude: /node_modules/,
                loader: {
                    loader: "babel-loader",
                    options: {
                        presets: [
                            '@babel/preset-env'
                        ],
                        plugins: [
                            '@babel/plugin-proposal-class-properties'
                        ]
                    }
                }
            },
            {
                test: /\.css$/,
                /*use: [
                    'style-loader',
                    MiniCssExtractPlugin.loader,
                    {
                        loader: 'css-loader',
                        options: {  }
                    }
                ],*/
                use: [
                    isDev ? { loader: 'vue-style-loader' } : { loader: MiniCssExtractPlugin.loader },
                    { loader: 'css-loader' },
                    {
                        loader: "postcss-loader",
                        options: {
                            sourceMap: isDev, // 
                            config: {
                                path: "./postcss.config"
                            }
                        }
                    }
                ]
            },
            {
                test: /\.scss$/,
                use: [
                    isDev ? { loader: 'vue-style-loader' } : { loader: MiniCssExtractPlugin.loader }, // Для разделения в два отдельных файла css и js
                    {
                        loader: "css-loader",
                        options: {
                            sourceMap: isDev // 
                        }
                    },
                    {
                        loader: "postcss-loader",
                        options: {
                            sourceMap: isDev, // 
                            config: {
                                path: "./postcss.config"
                            }
                        }
                    },
                    {
                        loader: "sass-loader",
                        options: {
                            sourceMap: isDev // 
                        }
                    }
                ],
                exclude: '/node_modules/' // Исключаем папку, чтобы устранить лишнюю фильтрацию
            },
            {
                test: /\.(png|jpg|gif|jpeg|ico)$/,
                loader: "file-loader"
            }
        ]
    },
    devtool: isDev ? 'source-map' : '',
    devServer: {
        contentBase: './clientapp/public/dist',
        port: 4200,
        hot: isDev
    },
    optimization: optimization(),
    plugins: [
        new CleanWebpackPlugin(),
        new VueLoaderPlugin(),
        ...([
            new MiniCssExtractPlugin({
                filename: '[name].[contenthash].css',
                chunkFilename: '[name].[contenthash].css',
            }),
        ]),
        new HtmlWebpackPlugin({
            template: path.resolve(__dirname, './clientapp/src/index.html'),
            minify: {
                collapseWhitespace: isProd
            }
        }),
        new CopyWebpackPlugin([
            {
                from: path.resolve(__dirname, './clientapp/src/assets/favicon.ico'),
                to: path.resolve(__dirname, './clientapp/public/dist/favicon.ico')
            },
            {
                from: path.resolve(__dirname, './clientapp/src/assets'),
                to: path.resolve(__dirname, './clientapp/public/dist/assets')
            }]),
        new Dotenv({
            path: './.env'
        })
    ]
}