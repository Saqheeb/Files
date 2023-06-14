import React, { useState } from 'react';
// import Sample2 from './Sample2';
// import Sample from './Sample';
// import { MyButton } from './Sample';
// import Person from './Person';

// import { personData } from './data';
// import PersonTable from './PersonTable';
// import Demo from './Demo';
// import Demo2 from './Demo2';

/*
const App = (props) => {
  class People {
    constructor(fname, lname, email) {
      this.fname = fname;
      this.lname = lname;
      this.email = email;
    }
  }

  const mul = (m, n) => {
    return m * n;
  };

  const a = 9;
  const colors = ['Red', 'Green', 'Blue'];
  const jsxList = colors.map((s) => <li>{s}</li>);

  const cities = [
    'Bengaluru',
    'Mangalore',
    'Panaji',
    'Mysuru',
    'Shimoga',
    'Sagar',
  ];
  const cityList = cities.map((s) => <li>{s}</li>);

  const p1 = new People('Saqheeb', 'Mohammed', 'mohdsaqheeb7@gmail.com');
  const p2 = new People('Shaghil', 'Mohammed', 'shaggy@gmail.com');

  const people = [];
  people.push(p1);
  people.push(p2);

  const peopleList = people.map((p) => {
    return (
      <>
        <Person person={p} />
      </>
    );
  });

  return (
    <>
      <h1 title={mul(7, 9)}>
        Hello, Your Score:{mul(7, 8)} {a}
      </h1>
      {mul(1, 7) > 100 ? <Sample /> : undefined}
      <ul>{jsxList}</ul>
      <MyButton />
      <ul>{cityList}</ul>
      <MyButton />
      <ul>{peopleList}</ul>
      <MyButton />
    </>
  );
};
*/

// const App = (props) => {
//   return (
//     <>
//       <h2>Hello People</h2>
//       <hr />
//       <PersonTable persons={personData} />
//     </>
//   );
// };

// const App = (props) => {
//   const [counter, setCounter] = useState(0);

//   const handleClick = () => {
//     setCounter(counter + 1);
//   };

//   return (
//     <>
//       <div className='container p-3'>
//         <h2>Hello Click: {counter}</h2>
//         <hr />

//         <button onClick={handleClick}>Hit Me!!!</button>
//       </div>
//     </>
//   );
// };

//Parent(App.jsx) to Child Component(Sample2.jsx) Component Communication happens using props
/*
const App = (props) => {
  const [counter, setCounter] = useState(0);

  const handleClickIncrement = () => {
    if (counter < 20) {
      console.log('Before: ' + counter);
      setCounter((c) => {
        return c + 1;
      });
      console.log('After: ' + counter);
    }

    return;
  };
  const handleClickDecrement = () => {
    if (counter > 0) setCounter(counter - 1);
    return;
  };

  return (
    <>
      <h1>Counter {counter}</h1>
      <button onClick={handleClickIncrement}>Increment</button>
      <button onClick={handleClickDecrement}>Decrement</button>
      <hr />

      <Sample2 c={counter} />
    </>
  );
};*/
/*
//Child Component(Sample2.jsx) to Parent(App.jsx) Component Communication
const App = () => {
  const handleChildEvent = (p) => {
    console.log('App Component receives: ', p);
  };

  return (
    <>
      <div className='container p-3'>
        <h2>Hello React</h2>
        <hr />
        <Sample2 comm={handleChildEvent}>
          <h2>Here is the Content projected</h2>
          <p>This is a paragraph</p>
        </Sample2>
      </div>
    </>
  );
};
*/

/*
const App = () => {
  const [show, setShow] = useState(false);

  const toggleShow = () => {
    setShow((c) => !c);
  };
  return (
    <>
      <div className='container p-3'>
        <h1>ReactJs Practice</h1>
        <hr />
        // { <Demo message={'Yo Homie'} /> }
        <button className='btn btn-info' onClick={toggleShow}>
          Toggle
        </button>
        {show ? <Demo2 /> : null}
      </div>
    </>
  );
};
*/

/*
//Form Example
const App = () => {
  const [message, setMessage] = useState('default');

  const handleInput = (e) => {
    setMessage((m) => e.target.value);
  };

  return (
    <>
      <div className='container p-3'>
        <h2>ReactJs Practice : {message}</h2>
        <hr />
        <input
          type='text'
          className='form-controller'
          onInput={handleInput}
          value={message}
        />
      </div>
    </>
  );
};
*/

const App = () => {
  const [userName, setuserName] = useState('default');
  const [password, setpassword] = useState('default');

  const nameChange = (e) => {
    setuserName((userName) => e.target.value);
  };

  const passwordChange = (e) => {
    setpassword((password) => e.target.value);
  };

  const clickHandler = (e) => {
    const jsonData = {
      userName,
      password,
    };
  };

  return (
    <>
      <div className='container-p3'>
        <h1>Login User</h1>
        <label>
          <span className='text'>User Name:</span>
          <input
            type='text'
            name='userNametxt'
            className='form-control'
            onInput={nameChange}
          />
        </label>
        <br />
        <label>
          <span className='text'>Password:</span>
          <input
            type='password'
            name='passwordtxt'
            className='form-control'
            onInput={passwordChange}
          />
        </label>
        <br />
        <button type='submit' onClick={clickHandler}>
          Submit
        </button>
      </div>
      <div>
        <pre>{JSON.stringify(jsonData, null, 2)}</pre>
      </div>
    </>
  );
};

export default App;
