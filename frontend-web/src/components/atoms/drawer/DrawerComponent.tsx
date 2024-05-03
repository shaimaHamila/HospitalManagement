import { Drawer } from "antd";
import DrawerComponentProps from "./DrawerComponentProps";

const DrawerComponent: React.FC<DrawerComponentProps> = ({ isOpen, handleClose, content, title }) => {
  return (
    <Drawer
      title={title}
      width={"80%"}
      open={isOpen}
      onClose={handleClose}
      destroyOnClose={true}
      styles={{
        body: {
          paddingBottom: 50,
        },
      }}
    >
      {content}
    </Drawer>
  );
};

export default DrawerComponent;
