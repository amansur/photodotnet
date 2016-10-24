const path = require('path');
const webpack = require('webpack');

module.exports = {
	//devtool: 'source-map',
	context: path.join(__dirname, 'App', 'src'),
	entry: ['whatwg-fetch', './js/index.js'],
	output: {
		path: path.join(__dirname, 'App', 'build'),
		filename: '[name].bundle.js'
	},
	//plugins: [
	//  new webpack.optimize.OccurenceOrderPlugin(),
	//  new webpack.DefinePlugin({
	//  	'process.env': {
	//  		'NODE_ENV': JSON.stringify('production')
	//  	}
	//  }),
	//  new webpack.optimize.UglifyJsPlugin({
	//  	compressor: {
	//  		warnings: false
	//  	}
	//  })
	//],
	module: {
		loaders: [
			{
				text: /\.jsx?$/,
				include: path.join(__dirname, 'App', 'src', 'js'),
				loader: 'babel',
				query: {
					presets: ['es2015', 'react']
				}
			},
			{
				test: /\.scss/,
				include: path.join(__dirname, 'App', 'src', 'scss'),
				loaders: ['style', 'css', 'sass']
			},
			{
				test: /\.css$/,
				loader: 'style-loader!css-loader'
			},
			{
				test: /\.html/,
				loader: 'html'
			},
			{
				test: /\.(png|woff|woff2|eot|ttf|svg)$/,
				loader: 'url-loader?limit=100000'
			}
		]
	}
};