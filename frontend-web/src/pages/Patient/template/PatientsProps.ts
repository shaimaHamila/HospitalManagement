import { Patient } from "../../../types/Patient";

export interface PatientsProps {
  patients: Patient[];
  status: "idle" | "loading" | "failed";
  search?: string;
  handleFilterChange: (filter: string) => void;
  handleEditPatient: (order: any) => void;
  handleDeletePatient: (order: any) => void;
  handleViewPatient: (order: any) => void;
  handleCreatePatient: () => void;
}
