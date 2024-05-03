import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { RootState } from "../../store/store";
import { Doctor } from "../../types/Dctor";
import api from "../../api/AxiosConfig";

interface DoctorsState {
  doctors: Doctor[];
  status: "idle" | "loading" | "failed";
  error?: string;
  count: number;
}

const initialState: DoctorsState = {
  doctors: [],
  status: "idle",
  count: 0,
};

export const fetchDoctors = createAsyncThunk<{ doctors: Doctor[] }>("doctors/fetchDoctors", async () => {
  try {
    const response = await api.get("/doctor");

    return {
      doctors: response.data.data,
    };
  } catch (error: any) {
    throw error;
  }
});

export const addDoctor = createAsyncThunk<Doctor, Partial<Doctor>, { state: RootState }>(
  "doctors/addDoctor",
  async (newDoctor) => {
    return new Promise<Doctor>((resolve, reject) => {
      api
        .post("/doctor", newDoctor)
        .then((response) => {
          resolve(response.data.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

export const deleteDoctor = createAsyncThunk<string, string, { state: RootState }>(
  "doctors/deleteDoctor",
  async (doctorId) => {
    const prom = new Promise<string>((resolve, reject) => {
      api
        .delete(`/doctor/${doctorId}`)
        .then(() => {
          resolve(doctorId);
        })
        .catch((error) => {
          reject(error);
        });
    });
    return prom;
  },
);

export const updateDoctor = createAsyncThunk<Doctor, Doctor, { state: RootState }>(
  "doctors/updateDoctor",
  async (updatedDoctor) => {
    let { id, ...newDoctor } = updatedDoctor;
    return new Promise<Doctor>((resolve, reject) => {
      api
        .patch("/doctor/" + id, newDoctor)
        .then((response) => {
          resolve(response.data.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
);

const doctorSlice = createSlice({
  name: "doctors",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchDoctors.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchDoctors.fulfilled, (state, action) => {
        state.doctors = action.payload.doctors;
        state.status = "idle";
      })
      .addCase(fetchDoctors.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(addDoctor.pending, (state) => {
        state.status = "loading";
      })
      .addCase(addDoctor.fulfilled, (state, action) => {
        state.status = "idle";
        // check if the doctors is already in the list
        const index = state.doctors.findIndex((doctor) => doctor.id === action.payload.id);
        if (index == -1) {
          state.doctors.unshift(action.payload);
          state.count++;
        }
      })
      .addCase(addDoctor.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(deleteDoctor.pending, (state) => {
        state.status = "loading";
      })
      .addCase(deleteDoctor.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.doctors.findIndex((doctor) => doctor.id === parseInt(action.payload));
        if (index !== -1) {
          state.doctors.splice(index, 1);
          state.count--;
        }
      })
      .addCase(deleteDoctor.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      })
      .addCase(updateDoctor.pending, (state) => {
        state.status = "loading";
      })
      .addCase(updateDoctor.fulfilled, (state, action) => {
        state.status = "idle";
        const index = state.doctors.findIndex((doctor) => doctor.id === action.payload.id);
        if (index !== -1) {
          // check if the doctor is different from the one in the list
          if (JSON.stringify(state.doctors[index]) !== JSON.stringify(action.payload)) {
            state.doctors[index] = action.payload;
          }
        }
      })
      .addCase(updateDoctor.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.error.message;
      });
  },
});

export const getDoctorState = (state: RootState) => state.doctor;

export const selectStatus = (state: RootState) => state.doctor.status;

export const selectError = (state: RootState) => state.doctor.error;

export default doctorSlice.reducer;
