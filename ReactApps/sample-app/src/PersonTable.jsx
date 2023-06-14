import React from 'react';

const PersonTable = (props) => {
  return (
    <>
      <table className='table table-striped table-bordered table-sm'>
        <thead>
          <tr>
            <th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Gender</th>
            <th>IP Address</th>
          </tr>
        </thead>
        <tbody>
          {props.persons.map((p) => {
            return (
              <>
                <tr>
                  <td>{p.id}</td>
                  <td>{p.first_name}</td>
                  <td>{p.last_name}</td>
                  <td>{p.email}</td>
                  <td>{p.gender}</td>
                  <td>{p.ip_address}</td>
                </tr>
              </>
            );
          })}
        </tbody>
      </table>
    </>
  );
};

export default PersonTable;
