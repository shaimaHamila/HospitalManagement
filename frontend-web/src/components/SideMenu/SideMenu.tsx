import { Button, Menu } from "antd";
import { AiOutlineMenuUnfold, AiOutlineMenuFold } from "react-icons/ai";
import { useLocation, useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import "./SideMenu.scss";
import { TbLogout } from "react-icons/tb";

type MenuItem = {
  key: React.Key;
  label: React.ReactNode;
  icon?: React.ReactNode;
  children?: MenuItem[];
  type?: "group";
};

interface SideMenuProps {
  menuItems: MenuItem[];
  logOut: () => void;
}
const SideMenu: React.FC<SideMenuProps> = ({ menuItems, logOut }: SideMenuProps) => {
  const navigate = useNavigate();
  const location = useLocation();
  const [collapsed, setCollapsed] = useState(false);
  const handleCollapse = () => {
    setCollapsed(!collapsed);
  };

  useEffect(() => {});

  return (
    <div className='side-menu--container'>
      <div className='side-menu'>
        <div className='side-menu--header'>
          <Button type='text' className='side-menu--header-collapse-btn' size={"large"} onClick={handleCollapse}>
            {collapsed ? <AiOutlineMenuUnfold /> : <AiOutlineMenuFold />}
          </Button>
        </div>

        <Menu
          defaultSelectedKeys={location.pathname == "/" ? ["/home"] : [location.pathname]}
          mode='inline'
          onClick={(item) => {
            navigate(item.key?.toString());
          }}
          inlineCollapsed={collapsed}
          items={menuItems}
          className='side-menu--menu'
        />
      </div>
      <Button onClick={logOut} className='side-menu--logout' size={"large"}>
        <TbLogout /> <span style={{ fontSize: "1rem" }}>{collapsed ? "" : "Logout"}</span>
      </Button>
    </div>
  );
};
export default SideMenu;
