import { createStore, applyMiddleware } from 'redux';
import Thunk from 'redux-thunk';
import { rootReducer } from './reducer.js';

function configureStore(preloadedState) {
	return createStore(
		rootReducer,
		preloadedState,
		applyMiddleware(Thunk));
}

export default configureStore;