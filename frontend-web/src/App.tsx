import PrivateRoutes from "./routes/PrivateRoutes";

function App() {
  console.log(import.meta.env.VITE_ENVIRONMENT);
  return (
    <>
      <PrivateRoutes />
    </>
  );
}

export default App;
