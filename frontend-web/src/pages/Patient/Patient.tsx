import { useEffect, useState } from "react";
import DrawerComponent from "../../components/atoms/drawer/DrawerComponent";
import { store } from "../../store/store";
import PatientDetails from "./content/Details/PatientDetails";
import PatientForm from "./content/Form/PatientForm";
import Patients from "./template/Patients";
import { useSelector } from "react-redux";
import {
  addPatient,
  deletePatient,
  fetchPatients,
  selectPatients,
  selectStatus,
  updatePatient,
} from "../../features/patient/patientSlice";
import { Patient } from "../../types/Patient";

const PatientC: React.FC = () => {
  const patients = useSelector(selectPatients);
  const status = useSelector(selectStatus);
  const [isDrawerOpen, setIsDrawerOpen] = useState(false);
  const [patientDetails, setPatientDetails] = useState<Patient>();
  const [patientToUpdate, setPatientToUpdate] = useState<Patient>();
  const [drawerContent, setDrawerContent] = useState<"create" | "update" | "details">();
  const [drawerTitle, setDrawerTitle] = useState<string>("");
  useEffect(() => {
    store.dispatch(fetchPatients());
  }, []);

  return (
    <>
      <Patients
        patients={patients}
        status={status}
        handleFilterChange={(_filter) => {
          console.log("Filter Patient");
        }}
        handleEditPatient={(patient) => {
          setPatientToUpdate(patient);
          setDrawerContent("update");
          setDrawerTitle("Edit patient");
          setIsDrawerOpen(true);
        }}
        handleDeletePatient={(id) => {
          store.dispatch(deletePatient(id));
        }}
        handleViewPatient={(patient) => {
          setPatientDetails(patient);
          setDrawerContent("details");
          setDrawerTitle("patient Details");
          setIsDrawerOpen(true);
        }}
        handleCreatePatient={() => {
          setDrawerContent("create");
          setDrawerTitle("Create patient");
          setIsDrawerOpen(true);
        }}
      />
      <DrawerComponent
        isOpen={isDrawerOpen}
        content={
          drawerContent === "create" || drawerContent === "update" ? (
            <PatientForm
              onSubmit={(patient) => {
                if (drawerContent === "create") store.dispatch(addPatient(patient));
                else if (drawerContent === "update") store.dispatch(updatePatient(patient));
                setIsDrawerOpen(false);
                //TODO add popup created successfuly
              }}
              patient={drawerContent === "update" ? patientToUpdate : undefined}
            />
          ) : (
            <PatientDetails patient={patientDetails!} />
          )
        }
        handleClose={() => setIsDrawerOpen(false)}
        title={drawerTitle}
      />
    </>
  );
};
export default PatientC;
