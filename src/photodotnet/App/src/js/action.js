import { SELECT_PHOTO } from './action.type.js';

export const selectPhoto = (selectId) => {
	return {
		type: SELECT_PHOTO,
		selectId
	}
}