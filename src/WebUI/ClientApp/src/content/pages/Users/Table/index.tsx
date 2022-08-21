import { Card } from '@mui/material';
import { useEffect, useState } from 'react';

import UsersTable from './UsersTable';

import APICallWrapper from 'src/api/APIWrapper/APICallWrapper';
import { UserInfo } from 'src/models/user_info';
import apiUrls from 'src/api/apiUrls';


const Users = () => {

  const updateUserList = () => {

    setUsers(
      [
        { id: 'id1', name: "Defender", email: "email", createdDate: null, roles: ["Admin"] },
        { id: 'id2', name: "Defender 2", email: "email 2", createdDate: null, roles: ["Admin", "User"] },
      ]
    );

    // APICallWrapper(
    //   {
    //     url: apiUrls.usermanagement.getUsers,
    //     options: {
    //       method: 'GET'
    //     },
    //     onSuccess: async (response) => {
    //       let allUsers = await response.json();

    //       setUsers(allUsers);
    //     }
    //   }
    // )
  }

  const setNewUserList = (users: UserInfo[]) => {
    setUsers(users)
  }

  const [users, setUsers] = useState<UserInfo[]>([]);

  useEffect(() => {
    updateUserList();
  }, [])

  return (
    <Card>
      <UsersTable users={users} setNewUserList={setNewUserList} />
    </Card>
  );
}

export default Users;
