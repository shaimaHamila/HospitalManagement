import { service } from "./Service";

export type Patient = {
  id: number;
  userName: string;
  phone: string;
  serviceId?: number;
  service?: service;
};
