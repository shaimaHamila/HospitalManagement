import { useEffect, useState } from "react";
import DrawerComponent from "../../components/atoms/drawer/DrawerComponent";
import DoctorDetails from "./content/Details/DoctorDetails";
import DoctorForm from "./content/Form/DoctorForm";
import { useSelector } from "react-redux";
import { Doctor } from "../../types/Dctor";
import { store } from "../../store/store";
import {
  addDoctor,
  deleteDoctor,
  fetchDoctors,
  selectDoctors,
  selectStatus,
  updateDoctor,
} from "../../features/doctor/doctorSlice";
import Doctors from "./template/Doctors";

const Doctorc: React.FC = () => {
  const doctors = useSelector(selectDoctors);
  const status = useSelector(selectStatus);
  const [isDrawerOpen, setIsDrawerOpen] = useState(false);
  const [doctorDetails, setDoctorDetails] = useState<Doctor>();
  const [doctorToUpdate, setDoctorToUpdate] = useState<Doctor>();
  const [drawerContent, setDrawerContent] = useState<"create" | "update" | "details">();
  const [drawerTitle, setDrawerTitle] = useState<string>("");
  useEffect(() => {
    store.dispatch(fetchDoctors());
  }, []);

  return (
    <>
      <Doctors
        doctors={doctors}
        status={status}
        handleFilterChange={(_filter) => {
          console.log("Filter doctor");
        }}
        handleEditDoctor={(doctor) => {
          setDoctorToUpdate(doctor);
          setDrawerContent("update");
          setDrawerTitle("Edit doctor");
          setIsDrawerOpen(true);
        }}
        handleDeleteDoctor={(id) => {
          store.dispatch(deleteDoctor(id));
        }}
        handleViewDoctor={(doctor) => {
          setDoctorDetails(doctor);
          setDrawerContent("details");
          setDrawerTitle("Doctor Details");
          setIsDrawerOpen(true);
        }}
        handleCreateDoctor={() => {
          setDrawerContent("create");
          setDrawerTitle("Create doctor");
          setIsDrawerOpen(true);
        }}
      />
      <DrawerComponent
        isOpen={isDrawerOpen}
        content={
          drawerContent === "create" || drawerContent === "update" ? (
            <DoctorForm
              onSubmit={(doctor) => {
                if (drawerContent === "create") store.dispatch(addDoctor(doctor));
                else if (drawerContent === "update") store.dispatch(updateDoctor(doctor));
                setIsDrawerOpen(false);
                //TODO add popup created successfuly
              }}
              doctor={drawerContent === "update" ? doctorToUpdate : undefined}
            />
          ) : (
            <DoctorDetails doctor={doctorDetails!} />
          )
        }
        handleClose={() => setIsDrawerOpen(false)}
        title={drawerTitle}
      />
    </>
  );
};
export default Doctorc;
