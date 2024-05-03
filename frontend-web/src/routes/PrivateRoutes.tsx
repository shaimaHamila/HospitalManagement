import { Route, Routes, useLocation } from "react-router-dom";
import Service from "../pages/Service/Service";
import Home from "../pages/Home/Home";
import Doctor from "../pages/Doctor/Doctor";
import Patient from "../pages/Patient/Patient";
import Layout, { Content } from "antd/es/layout/layout";
import NavBar from "../components/NavBar/NavBar";
import SideMenu from "../components/SideMenu/SideMenu";
import { useEffect, useState } from "react";
import { MdOutlineSpaceDashboard } from "react-icons/md";
import { FaUserDoctor } from "react-icons/fa6";
import { MdOutlineSick } from "react-icons/md";
import { RiServiceLine } from "react-icons/ri";

const PrivateRouts = () => {
  const [pageName, setPageName] = useState<string>("");
  const [pageIcon, setPageIcon] = useState<any>(<></>);
  const location = useLocation();
  const getPageName = () => {
    let found = false;
    const path = location.pathname;
    menuItems.forEach((element) => {
      if (element.key === path) {
        setPageName(element.label + " Page");
        setPageIcon(element.icon);
        found = true;
      }
    });

    if (!found) {
      setPageName("");
      setPageIcon(<></>);
    }
  };

  useEffect(() => {
    getPageName();
  }, [location.pathname]);

  const handelLogOut = () => {
    localStorage.removeItem("accessToken");
    localStorage.removeItem("refreshToken");
    window.location.reload();
  };
  return (
    <>
      <Layout style={{ overflow: "auto", display: "flex", flexDirection: "row", flexWrap: "nowrap", height: "100vh" }}>
        <SideMenu menuItems={menuItems} logOut={handelLogOut}></SideMenu>

        <Layout>
          <NavBar userName={"Admin Name"} pageName={pageName} userImg='' pageIcon={pageIcon} />
          <Content
            style={{
              margin: "24px 16px",
              padding: 24,
              minHeight: 280,
            }}
          >
            <Routes>
              <Route path='/' element={<Home />}></Route>
              <Route path='/home' element={<Home />}></Route>
              <Route path='/service' element={<Service />}></Route>
              <Route path='/doctor' element={<Doctor />}></Route>
              <Route path='/patient' element={<Patient />}></Route>
            </Routes>
          </Content>
        </Layout>
      </Layout>
    </>
  );
};
export default PrivateRouts;
const menuItems = [
  { key: "/home", label: "Home", icon: <MdOutlineSpaceDashboard /> },
  { key: "/doctor", label: "Doctors List", icon: <FaUserDoctor /> },
  { key: "/patient", label: "Patients List", icon: <MdOutlineSick /> },
  { key: "/service", label: "Services List", icon: <RiServiceLine /> },
];
