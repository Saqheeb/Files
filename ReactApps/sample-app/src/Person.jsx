import React from 'react';

const Person = (props) => {
    return (
        <>
            <div>
                <li>First Name: { props.person.fname}</li>
                <li>Last Name : { props.person.lname}</li>
                <li>Email     : { props.person.email}</li>
            </div> 
        <hr/>
        </>
        
    )
}

export default Person