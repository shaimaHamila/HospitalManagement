import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { RootState } from "../../store/store";
import api from "../../api/AxiosConfig";
import { service } from "../../types/Service";

interface serviceState {
  services: service[];
  status: "idle" | "loading" | "failed";
  error?: string;
  count: number;
}

const initialState: serviceState = {
  services: [],
  status: "idle",
  count: 0,
};

export const fetchServices = createAsyncThunk<service[]>("services/fetchServices", async () => {
  try {
    const response = await api.get("/Service");
    return response.data;
  } catch (error: any) {
    throw error;
  }
});

export const addService = createAsyncThunk<service, Partial<service>, { state: RootState }>(
  "services/addService",
  async (newService) => {
    return new Promise<service>((resolve, reject) => {
      api
        .post("/service", newService)
        .then((response) => {
          resolve(response.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

export const deleteService = createAsyncThunk<string, string, { state: RootState }>(
  "services/deleteService",
  async (serviceId) => {
    const prom = new Promise<string>((resolve, reject) => {
      api
        .delete(`/service/${serviceId}`)
        .then(() => {
          resolve(serviceId);
        })
        .catch((error) => {
          reject(error);
        });
    });
    return prom;
  },
);

export const updateService = createAsyncThunk<service, service, { state: RootState }>(
  "services/updateservice",
  async (updatedservice) => {
    let { id, ...newservice } = updatedservice;
    return new Promise<service>((resolve, reject) => {
      api
        .put("/service/" + id, newservice)
        .then((response) => {
          resolve(response.data.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

const serviceSlice = createSlice({
  name: "service",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchServices.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchServices.fulfilled, (state, action) => {
        state.services = action.payload;
        state.status = "idle";
      })
      .addCase(fetchServices.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(addService.pending, (state) => {
        state.status = "loading";
      })
      .addCase(addService.fulfilled, (state, action) => {
        state.status = "idle";
        // check if the service is already in the list
        const index = state.services.findIndex((service) => service.id === action.payload.id);
        if (index == -1) {
          state.services.unshift(action.payload);
          state.count++;
        }
      })
      .addCase(addService.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(deleteService.pending, (state) => {
        state.status = "loading";
      })
      .addCase(deleteService.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.services.findIndex((service) => service.id === parseInt(action.payload));
        if (index !== -1) {
          state.services.splice(index, 1);
          state.count--;
        }
      })
      .addCase(deleteService.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(updateService.pending, (state) => {
        state.status = "loading";
      })
      .addCase(updateService.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.services.findIndex((service) => service.id === action.payload.id);
        if (index !== -1) {
          // check if the service is different from the one in the list
          if (JSON.stringify(state.services[index]) !== JSON.stringify(action.payload)) {
            state.services[index] = action.payload;
          }
        }
      })
      .addCase(updateService.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      });
  },
});

export const getserviceState = (state: RootState) => state.service;

export const selectStatus = (state: RootState) => state.service.status;

export const selectServices = (state: RootState) => state.service.services;

export const selectError = (state: RootState) => state.service.error;

export default serviceSlice.reducer;
