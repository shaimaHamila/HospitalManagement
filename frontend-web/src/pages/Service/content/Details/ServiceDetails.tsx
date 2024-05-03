import React from "react";
import { service } from "../../../../types/Service";
interface ServiceDetailsProps {
  service: service;
}
const ServiceDetails: React.FC<ServiceDetailsProps> = ({ service }) => {
  return (
    <>
      <p>
        <strong>ID:</strong> {service.id}
      </p>
      <p>
        <strong>Name:</strong> {service.name}
      </p>
      <p>
        <strong>Speciality:</strong> {service.speciality}
      </p>
      {service.contactNumber && (
        <p>
          <strong>Contact Number:</strong> {service.contactNumber}
        </p>
      )}
      <p>
        <strong>Description:</strong> {service.description}
      </p>
      {service.doctor && (
        <div>
          <strong>Doctors:</strong>
          <ul>
            {service.doctor.map((doctor, index) => (
              <li key={index}>
                <strong>Name:</strong> {doctor.name}, <strong>Speciality:</strong> {doctor.speciality}
              </li>
            ))}
          </ul>
        </div>
      )}
    </>
  );
};

export default ServiceDetails;
