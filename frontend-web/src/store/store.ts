import { configureStore } from "@reduxjs/toolkit";
import userSlice from "../features/user/usersSlice";
import doctorSlice from "../features/doctor/doctorSlice";
import patientSlice from "../features/patient/patientSlice";
import serviceSlice from "../features/service/serviceSlice";
// ...

export const store = configureStore({
  reducer: {
    user: userSlice,
    doctor: doctorSlice,
    patient: patientSlice,
    service: serviceSlice,
  },
});

// Infer the `RootState` and `AppDispatch` types from the store itself
export type RootState = ReturnType<typeof store.getState>;
// Inferred type: {posts: PostsState, comments: CommentsState, users: UsersState}
export type AppDispatch = typeof store.dispatch;
