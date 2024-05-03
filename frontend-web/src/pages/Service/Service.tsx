import { useSelector } from "react-redux";
import Services from "./template/Services";
import {
  addService,
  deleteService,
  fetchServices,
  selectServices,
  selectStatus,
  updateService,
} from "../../features/service/serviceSlice";
import { store } from "../../store/store";
import { useEffect, useState } from "react";
import ServiceDetails from "./content/Details/ServiceDetails";
import { service } from "../../types/Service";
import ServiceForm from "./content/Form/ServiceForm";
import DrawerComponent from "../../components/atoms/drawer/DrawerComponent";

const Service: React.FC = () => {
  const services = useSelector(selectServices);
  const status = useSelector(selectStatus);
  const [isDrawerOpen, setIsDrawerOpen] = useState(false);
  const [serviceDetails, setServiceDetails] = useState<service>();
  const [serviceToUpdate, setServiceToUpdate] = useState<service>();
  const [drawerContent, setDrawerContent] = useState<"create" | "update" | "details">();
  const [drawerTitle, setDrawerTitle] = useState<string>("");
  useEffect(() => {
    store.dispatch(fetchServices());
    console.log("Fetching Services", services);
  }, []);

  return (
    <>
      <Services
        services={services}
        status={status}
        handleFilterChange={(_filter) => {
          console.log("Filter Service");
        }}
        handleEditService={(service) => {
          setServiceToUpdate(service);
          setDrawerContent("update");
          setDrawerTitle("Edit Service");
          setIsDrawerOpen(true);
          console.log("Edit Service");
        }}
        handleDeleteService={(id) => {
          store.dispatch(deleteService(id));
        }}
        handleViewService={(service) => {
          setServiceDetails(service);
          setDrawerContent("details");
          setDrawerTitle("Service Details");
          setIsDrawerOpen(true);
          // console.log("View service", service);
        }}
        handleCreateService={() => {
          setDrawerContent("create");
          setDrawerTitle("Create Service");
          setIsDrawerOpen(true);
          console.log("Create Service");
        }}
      />
      <DrawerComponent
        isOpen={isDrawerOpen}
        content={
          drawerContent === "create" || drawerContent === "update" ? (
            <ServiceForm
              onSubmit={(service) => {
                if (drawerContent === "create") store.dispatch(addService(service));
                else if (drawerContent === "update") store.dispatch(updateService(service));
                setIsDrawerOpen(false);
                //TODO add popup created successfuly
                console.log("onSubmit orderrrrrrrrrrrrr", service);
                console.log("drawerContent drawerContent", drawerContent);
              }}
              service={drawerContent === "update" ? serviceToUpdate : undefined}
            />
          ) : (
            <ServiceDetails service={serviceDetails!} />
          )
        }
        handleClose={() => setIsDrawerOpen(false)}
        title={drawerTitle}
      />
    </>
  );
};
export default Service;
