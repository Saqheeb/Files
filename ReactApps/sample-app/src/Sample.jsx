import React from 'react';

const Sample = (props) => {
  return <h2>Sample Component: {props.c}</h2>;
};

const MyButton = () => {
  return <button>Hit Me!!</button>;
};

export default Sample;
export { MyButton };
