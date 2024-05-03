import { Button, Popconfirm, Space, Table, TableProps, Tooltip } from "antd";
import Input, { SearchProps } from "antd/es/input";
import { useEffect, useState } from "react";
import { ServicesProps } from "./ServicesProps";
import { service } from "../../../types/Service";
import Title from "antd/es/typography/Title";
import { HiOutlineEye, HiOutlinePencilAlt, HiOutlinePlus, HiOutlineTrash } from "react-icons/hi";
import "./Services.scss";

const Services: React.FC<ServicesProps> = ({
  services,
  status,
  handleViewService,
  handleEditService,
  handleDeleteService,
  handleCreateService,
}: ServicesProps) => {
  const { Search } = Input;
  const onSearch: SearchProps["onSearch"] = (value, _e, info) => console.log(info?.source, value);

  const [tableContent, setTableContent] = useState<service[]>([]);
  const [countServices, setcountServices] = useState(tableContent.length);
  useEffect(() => {
    // Extract specific fields from services and populate tableContent
    const tableContent = services.map((service) => ({
      id: service.id,
      name: service.name,
      description: service.description,
      speciality: service.speciality,
      contactNumber: service.contactNumber,
    }));
    setTableContent(tableContent);
    setcountServices(tableContent.length);
  }, [services]);

  const columns: TableProps<service>["columns"] = [
    {
      title: "",
      dataIndex: "id",
      key: "id",
      width: 50,
    },
    {
      title: "Service Name",
      dataIndex: "name",
      key: "name",
      render: (text) => <div style={{ display: "flex", gap: "6px" }}>{text}</div>,
    },
    {
      title: "Speciality",
      dataIndex: "speciality",
      key: "speciality",
    },
    {
      title: "Contact Number",
      dataIndex: "contactNumber",
      key: "contactNumber",
    },
    {
      title: "Description",
      dataIndex: "description",
      key: "description",
    },
    {
      title: "Action",
      key: "action",
      width: 160,
      render: (_text, record) => (
        <Space size='middle'>
          <Tooltip title='View'>
            <Button onClick={() => handleViewService(record)} className='table--action-btn' icon={<HiOutlineEye />} />
          </Tooltip>
          <Tooltip title='Edit'>
            <Button
              onClick={() => handleEditService(record)}
              className='table--action-btn'
              icon={<HiOutlinePencilAlt />}
            />
          </Tooltip>
          <Tooltip title='Delete'>
            <Popconfirm title='Sure to delete?' onConfirm={() => handleDeleteService(record.id)}>
              <Button className='table--action-btn' icon={<HiOutlineTrash />} />
            </Popconfirm>
          </Tooltip>
        </Space>
      ),
    },
  ];

  //To remove and get the data from the backend services
  const data: service[] = [
    {
      id: 1,
      name: "test1",
      speciality: "Salah Ben salah",
      contactNumber: 22016583,
      description: "Jan 1, 2024 12:13",
    },
    {
      id: 2,
      name: "test",
      speciality: "Salah Ben salah",
      contactNumber: 22016583,
      description: "Jan 1, 2024 12:13",
    },
    {
      id: 3,
      name: "Tast",
      speciality: "Salah Ben salah",
      contactNumber: 22016583,
      description: "Jan 1, 2024 12:13",
    },
  ];

  return (
    <div className='service-container'>
      <div className='service-container--header'>
        <Title level={4}> Total Services number: {countServices}</Title>
        <div className='service-container--header-actions'>
          <Search
            className='service-container--header-actions-search'
            placeholder='input search text'
            allowClear
            onSearch={onSearch}
            style={{ width: 200 }}
          />
          <Button
            onClick={() => {
              handleCreateService();
            }}
            type='primary'
            icon={<HiOutlinePlus />}
          >
            Add a new service
          </Button>
        </div>
      </div>
      <div className='service-container--table'>
        <Table
          loading={status == "loading"}
          columns={columns}
          dataSource={data}
          rowKey='id'
          pagination={false}
          // scroll={{ y: 500 }}
        />
      </div>
    </div>
  );
};
export default Services;
