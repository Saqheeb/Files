import React from 'react';

// const Sample2 = (props) => {
//   return <h2>Sample Component: {props.c}</h2>;
// };

const Sample2 = (props) => {
  const clickHandler = () => {
    console.log('Local handler');
    props.comm('Message sent from the child ');
  };

  return (
    <>
      <button onClick={clickHandler}>Communicate</button>
      {props.children}
    </>
  );
};

export default Sample2;
