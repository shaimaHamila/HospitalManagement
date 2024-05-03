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
        <strong>Description:</strong> {service.description}
      </p>
      {service.doctor && (
        <div>
          <strong>Doctors:</strong>
          <ul>
            {service.doctor.map((doctor, index) => (
              <li key={index}>
                <strong>First Name:</strong> {doctor.firstName}, <strong>Last Name:</strong> {doctor.lastName}
              </li>
            ))}
          </ul>
        </div>
      )}
    </>
  );
};

export default ServiceDetails;
