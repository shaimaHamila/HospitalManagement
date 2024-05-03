import { Doctor } from "../../../types/Dctor";

export interface DoctorsProps {
  doctors: Doctor[];
  status: "idle" | "loading" | "failed";
  search?: string;
  handleFilterChange: (filter: string) => void;
  handleEditDoctor: (doctor: any) => void;
  handleDeleteDoctor: (doctor: any) => void;
  handleViewDoctor: (doctor: any) => void;
  handleCreateDoctor: () => void;
}
