export default interface DrawerComponentProps {
  /**
   * Is the modal open?
   * @default false
   * */
  isOpen: boolean;

  /**
   * Function to close the modal
   * */
  handleClose: () => void;
  /**
   * The title of the modal
   * */
  title: string;

  /**
   * The content of the modal
   * */
  content: React.ReactNode;
}
