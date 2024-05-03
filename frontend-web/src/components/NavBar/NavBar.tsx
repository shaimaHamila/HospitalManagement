import { Header } from "antd/es/layout/layout";
import "./NavBar.scss";
import { Avatar } from "antd";
import React from "react";
import { FaUser } from "react-icons/fa";

interface NavBarProps {
  userImg?: string;
  userName: string;
  pageName: string;
  pageIcon?: React.ReactNode;
}

const NavBar: React.FC<NavBarProps> = ({ userImg, userName, pageName, pageIcon }: NavBarProps) => {
  return (
    <Header className='header-container'>
      <div>
        <div className='header--page-label'>
          <span className='header--page-label-icon'>{pageIcon}</span>

          <h4 className='header--page-label--title'>{pageName}</h4>
        </div>
      </div>
      {/* <Link to='/profile'> */}
      <div className='header--user'>
        <h3 className='header--user-name'>{userName}</h3>
        {userImg ? (
          <Avatar src={userImg} size={34} style={{ backgroundColor: "#fde3cf", color: "#f56a00" }}></Avatar>
        ) : (
          <Avatar icon={<FaUser />} size={34} style={{ backgroundColor: "#fde3cf", color: "#f56a00" }}></Avatar>
        )}
      </div>
      {/* </Link> */}
    </Header>
  );
};

export default NavBar;
