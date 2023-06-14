import React, { useState, useEffect } from 'react';
import './Demo.css';

const Demo2 = (props) => {
  const [counter, setCounter] = useState(0);

  useEffect(() => {
    console.log('Mounting...');

    return () => {
      console.log('Unmounting....');
    };
  }, []);
  console.log('render');

  useEffect(() => {
    console.log('Counter Updated');
    console.log('After', counter);
  }, [counter]);

  const increment = () => {
    console.log('Before', counter);
    setCounter((c) => c + 1);
  };

  //Inline CSS Example
  //   const headerStyle = {
  //     color: 'Blue',
  //     fontSize: '3rem',
  //     backgroundColor: 'Red',
  //   };

  return (
    <>
      <h2 className='blue-text'>Demo Function Component: {counter}</h2>
      <button className='btn btn-primary' onClick={increment}>
        Increment
      </button>
    </>
  );
};

export default Demo2;
