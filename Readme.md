## Hospital Management System

The Hospital Management System is a project developed for managing hospital operations efficiently. It consists of a backend API built with ASP.NET Core EF 8, following the principles of Clean Architecture, a web frontend developed using React TypeScript, and a desktop frontend built with Windows Forms .NET.

### Features

- CRUD operations for doctors
- CRUD operations for patients
- CRUD operations for services
- Relationship between doctors and services (many-to-many)
- Relationship between services and patients (one-to-many)

### Technologies Used

#### Backend (APIs)

- ASP.NET Core with Clean Architecture
- Entity Framework Core 8

#### Frontend (Web)

- React with TypeScript
- Axios for API requests
- Redux Toolkit for state management
- Ant Design (Antd) for UI components

#### Frontend (Desktop)

- Windows Forms .NET

## Getting Started

#### Setting up the Backend:

2. Open the backend directory in visual studio
3. Create a SQL Server database named "HospitalManagement".
4. Update the database connection in `api/appsettings.json` and `Data/ApplicationDbContext.cs`
5. Update the database with Initial migration file:
   ` update-database`
6. To run `Seed.cs` file in the terminal run ` dotnet run seeddata`

#### Setting up the Frontend (Web):

Open the frontend-web directory. `cd frontend-web`
Install dependencies:
`npm install`
Run the development server:
`npm run dev`
Or using docker:
`docker compose up`

#### Running the Desktop App:

Open the AppDesktop directory.
Run the application in Visual Studio.

## Contributing

    If you find any bugs or would like to optimize the code, feel free to contribute. Pull requests are welcome!


## Project Screenshots
![Screenshot 2024-07-18 123447](https://github.com/user-attachments/assets/d3dce57d-29a5-4774-87b8-383db5565f5b)
<img width="561" alt="Services_managment" src="https://github.com/user-attachments/assets/efd2b663-b4a6-4042-9683-25c358e8b590">
<img width="563" alt="patient_managment" src="https://github.com/user-attachments/assets/4c114898-6d85-408a-aed9-e6906ab7a04d">
<img width="872" alt="HospitalManagement_swagger" src="https://github.com/user-attachments/assets/736e5268-7094-4550-8176-f45b96feac70">
<img width="569" alt="edit_doctor" src="https://github.com/user-attachments/assets/198b0399-ace2-4c54-bc31-b270798395f7">
<img width="615" alt="doctors_managment" src="https://github.com/user-attachments/assets/dbb4ff38-ad75-44f4-99ac-c4b95c1caf89">
<img width="614" alt="doctor_details" src="https://github.com/user-attachments/assets/9b85f401-79bf-47a3-a107-8c23e3e015cd">


