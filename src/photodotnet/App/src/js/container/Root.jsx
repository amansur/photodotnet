import React, { Component } from 'react';
import { Provider } from 'react-redux';
import ConfigureStore from '../configureStore.js';
import App from './App.jsx';

const store = ConfigureStore();

export default class Root extends Component {
	render() {
		return (
			<Provider store={store}>
				<App />
			</Provider>
		);
	}
}