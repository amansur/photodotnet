import combineReducers from 'redux';
import { SELECT_PHOTO } from './action.type.js';

const selectPhoto = (state = {}, action) => {
	switch (action.type) {
		case SELECT_PHOTO:
			return Object.assign({}, state, { id: selectId });
	}
}