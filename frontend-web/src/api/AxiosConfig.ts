import axios from "axios";

const api = axios.create({
  baseURL: "https://localhost:7164/api",
});

export default api;
