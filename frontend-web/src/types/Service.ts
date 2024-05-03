import { Doctor } from "./Dctor";

export type service = {
  id: number;
  name: string;
  description: string;
  speciality: string;
  contactNumber?: number;
  doctor?: Doctor[];
};
