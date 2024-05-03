import { service } from "../../../types/Service";

export interface ServicesProps {
  services: service[];
  status: "idle" | "loading" | "failed";
  search?: string;
  handleFilterChange: (filter: string) => void;
  handleEditService: (order: any) => void;
  handleDeleteService: (order: any) => void;
  handleViewService: (order: any) => void;
  handleCreateService: () => void;
}
