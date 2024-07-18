import axios from "axios";

const api = axios.create({
  baseURL: "http://localhost:7164/api",
});

export default api;
