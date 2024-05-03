import { Patient } from "./../../types/Patient";

import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { RootState } from "../../store/store";
import api from "../../api/AxiosConfig";

interface PatientState {
  patient: Patient[];
  status: "idle" | "loading" | "failed";
  error?: string;
  count: number;
}

const initialState: PatientState = {
  patient: [],
  status: "idle",
  count: 0,
};

export const fetchPatient = createAsyncThunk<{ patient: Patient[] }>("patients/fetchPatient", async () => {
  try {
    const response = await api.get("/Patient");

    return {
      patient: response.data.data,
    };
  } catch (error: any) {
    throw error;
  }
});

export const addPatient = createAsyncThunk<Patient, Partial<Patient>, { state: RootState }>(
  "patients/addPatient",
  async (newPatient) => {
    return new Promise<Patient>((resolve, reject) => {
      api
        .post("/Patient", newPatient)
        .then((response) => {
          resolve(response.data.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

export const deletePatient = createAsyncThunk<string, string, { state: RootState }>(
  "patients/deletePatient",
  async (PatientId) => {
    const prom = new Promise<string>((resolve, reject) => {
      api
        .delete(`/Patient/${PatientId}`)
        .then(() => {
          resolve(PatientId);
        })
        .catch((error) => {
          reject(error);
        });
    });
    return prom;
  },
);

export const updatePatient = createAsyncThunk<Patient, Patient, { state: RootState }>(
  "patients/updatePatient",
  async (updatedPatient) => {
    let { id, ...newPatient } = updatedPatient;
    return new Promise<Patient>((resolve, reject) => {
      api
        .patch("/Patient/" + id, newPatient)
        .then((response) => {
          resolve(response.data.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

const patientlice = createSlice({
  name: "patient",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchPatient.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchPatient.fulfilled, (state, action) => {
        state.patient = action.payload.patient;
        state.status = "idle";
      })
      .addCase(fetchPatient.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(addPatient.pending, (state) => {
        state.status = "loading";
      })
      .addCase(addPatient.fulfilled, (state, action) => {
        state.status = "idle";
        // check if the patient is already in the list
        const index = state.patient.findIndex((Patient) => Patient.id === action.payload.id);
        if (index == -1) {
          state.patient.unshift(action.payload);
          state.count++;
        }
      })
      .addCase(addPatient.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(deletePatient.pending, (state) => {
        state.status = "loading";
      })
      .addCase(deletePatient.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.patient.findIndex((Patient) => Patient.id === parseInt(action.payload));
        if (index !== -1) {
          state.patient.splice(index, 1);
          state.count--;
        }
      })
      .addCase(deletePatient.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(updatePatient.pending, (state) => {
        state.status = "loading";
      })
      .addCase(updatePatient.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.patient.findIndex((Patient) => Patient.id === action.payload.id);
        if (index !== -1) {
          // check if the Patient is different from the one in the list
          if (JSON.stringify(state.patient[index]) !== JSON.stringify(action.payload)) {
            state.patient[index] = action.payload;
          }
        }
      })
      .addCase(updatePatient.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      });
  },
});

export const getPatientState = (state: RootState) => state.patient;

export const selectStatus = (state: RootState) => state.patient.status;

export const selectError = (state: RootState) => state.patient.error;

export default patientlice.reducer;
