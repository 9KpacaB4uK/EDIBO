import React, { Component } from 'react';
import './App.css';

class App extends Component {
  state = {
    count: 0
  }

  plus = () => {
    this.setState({
      count: this.state.count + 1
    })
  }
  minus = () => {
    this.setState({
      count: this.state.count - 1
    })
  }
  reset = () => {
    this.setState({
      count: this.state.count = 0
    })
  }

  render () {
    return <div id="mainDiv">
      <h1>{this.state.count}</h1>
      <button onClick={this.plus}>+</button>
      <button onClick={this.reset}>reset</button>
      <button onClick={this.minus}>-</button>
    </div>
  }
}
export default App;