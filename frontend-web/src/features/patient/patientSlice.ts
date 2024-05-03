import { Patient } from "./../../types/Patient";

import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { RootState } from "../../store/store";
import api from "../../api/AxiosConfig";

interface PatientState {
  patients: Patient[];
  status: "idle" | "loading" | "failed";
  error?: string;
  count: number;
}

const initialState: PatientState = {
  patients: [],
  status: "idle",
  count: 0,
};

export const fetchPatients = createAsyncThunk<{ patient: Patient[] }>("patients/fetchPatients", async () => {
  try {
    const response = await api.get("/Patient");

    return {
      patient: response.data,
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
          resolve(response.data);
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
    return new Promise<any>((resolve, reject) => {
      api
        .put("/Patient/" + updatedPatient.id, updatedPatient)
        .then((response) => {
          var newPatient: Patient = {
            id: response.data.id,
            userName: response.data.patientDto.userName,
            phone: response.data.patientDto.phone,
            serviceId: response.data.patientDto.serviceId,
          };

          resolve(newPatient);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

const patientSlice = createSlice({
  name: "patient",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchPatients.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchPatients.fulfilled, (state, action) => {
        state.patients = action.payload.patient;
        state.status = "idle";
      })
      .addCase(fetchPatients.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(addPatient.pending, (state) => {
        state.status = "loading";
      })
      .addCase(addPatient.fulfilled, (state, action) => {
        state.status = "idle";
        // check if the patient is already in the list
        const index = state.patients.findIndex((Patient) => Patient.id === action.payload.id);
        if (index == -1) {
          state.patients.unshift(action.payload);
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
        const index = state.patients.findIndex((Patient) => Patient.id === parseInt(action.payload));
        if (index !== -1) {
          state.patients.splice(index, 1);
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
        const index = state.patients.findIndex((Patient) => Patient.id === action.payload.id);
        if (index !== -1) {
          // check if the Patient is different from the one in the list
          if (JSON.stringify(state.patients[index]) !== JSON.stringify(action.payload.id)) {
            state.patients[index] = action.payload;
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

export const selectPatients = (state: RootState) => state.patient.patients;

export const selectError = (state: RootState) => state.patient.error;

export default patientSlice.reducer;
