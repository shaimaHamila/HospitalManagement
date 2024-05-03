import { Doctor } from "../../../../types/Dctor";
interface doctorDetailsProps {
  doctor: Doctor;
}
const DoctorDetails: React.FC<doctorDetailsProps> = ({ doctor }) => {
  return (
    <>
      <p>
        <strong>Doctor ID:</strong> {doctor.id}
      </p>
      <p>
        <strong>Doctor First Name:</strong> {doctor.firstName}
      </p>
      <p>
        <strong>Doctor Last Name:</strong> {doctor.firstName}
      </p>
      <p>
        <strong>Doctor Birthday:</strong> {doctor.birthday}
      </p>
      <p>
        <strong>Address:</strong> {doctor.address}
      </p>
    </>
  );
};

export default DoctorDetails;
