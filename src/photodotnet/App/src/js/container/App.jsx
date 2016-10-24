import React, { Component } from 'react';

class App extends Component {
	constructor(props) {
		super(props);
	}

	render() {
		return (
			<div></div>
		);
	}
}

const mapStateToProps = (state) => {
	return state;
}

const mapDispatchToProps = (dispatch) => {

}

export default connect(mapStateToProps)(App);