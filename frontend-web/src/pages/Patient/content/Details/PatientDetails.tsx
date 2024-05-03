import React, { useEffect } from "react";
import { Patient } from "../../../../types/Patient";
import { useSelector } from "react-redux";
import { getServiceById, selectService } from "../../../../features/service/serviceSlice";
import { store } from "../../../../store/store";
interface PatientDetailsProps {
  patient: Patient;
}
const ServiceDetails: React.FC<PatientDetailsProps> = ({ patient }) => {
  if (patient.serviceId) {
    patient.service = useSelector(selectService);

    useEffect(() => {
      store.dispatch(getServiceById(patient.serviceId!));
    }, []);
  }

  return (
    <>
      <p>
        <strong>Patient ID:</strong> {patient.id}
      </p>
      <p>
        <strong>Patient Name:</strong> {patient.userName}
      </p>

      {patient.service && (
        <div>
          <h3>Service details:</h3>
          <p>
            <strong>Service ID:</strong> {patient.service.id}
          </p>
          <p>
            <strong>Service Name:</strong> {patient.service.name}
          </p>
          <p>
            <strong>Service Description:</strong> {patient.service.description}
          </p>
        </div>
      )}
    </>
  );
};

export default ServiceDetails;
