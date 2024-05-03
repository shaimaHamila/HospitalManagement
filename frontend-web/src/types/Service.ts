import { Doctor } from "./Dctor";
import { Patient } from "./Patient";

export type service = {
  id: number;
  name: string;
  description: string;
  patients?: Patient;
  doctor?: Doctor[];
  // speciality: string;
};
