import React, { Component } from 'react';

class DemoC extends Component {
  constructor(props) {
    super(props);
    this.state = {
      counter: 0,
    };
    this.increment = this.increment.bind(this);

    console.log('Contructor');
  }

  increment() {
    this.setState((s, p) => {
      return {
        counter: s.counter + 1,
      };
    });
  }

  componentDidMount() {
    console.log('mount');
  }
  componentDidUpdate() {
    console.log('update');
  }

  componentWillUnmount() {
    console.log('Unmount');
  }

  render() {
    console.log('Render');
    return (
      <>
        <h2>
          Demo Class Component: {this.state.counter} :: {this.props.message}
        </h2>
        <hr />
        <button onClick={this.increment}>Increment</button>
      </>
    );
  }
}

export default DemoC;
