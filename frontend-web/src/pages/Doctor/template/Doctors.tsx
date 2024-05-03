import { Button, Popconfirm, Space, Table, TableProps, Tooltip } from "antd";
import Input, { SearchProps } from "antd/es/input";
import { useEffect, useState } from "react";
import Title from "antd/es/typography/Title";
import { HiOutlineEye, HiOutlinePencilAlt, HiOutlinePlus, HiOutlineTrash } from "react-icons/hi";
import "./Doctors.scss";
import { DoctorsProps } from "./DoctorsProps";
import { Doctor } from "../../../types/Dctor";

const Doctors: React.FC<DoctorsProps> = ({
  doctors,
  status,
  handleViewDoctor,
  handleEditDoctor,
  handleDeleteDoctor,
  handleCreateDoctor,
}: DoctorsProps) => {
  const { Search } = Input;
  const onSearch: SearchProps["onSearch"] = (value, _e, info) => console.log(info?.source, value);

  const [tableContent, setTableContent] = useState<Doctor[]>([]);
  const [countDoctors, setcountDoctors] = useState(tableContent.length);

  useEffect(() => {
    // Extract specific fields from services and populate tableContent
    const tableContent = doctors.map((doctor) => ({
      id: doctor.id,
      firstName: doctor.firstName,
      lastName: doctor.lastName,
      birthday: doctor.birthday,
      address: doctor.address,
      serviceIds: doctor.serviceIds,
    }));
    setTableContent(tableContent);
    setcountDoctors(tableContent.length);
  }, [doctors]);

  const columns: TableProps<Doctor>["columns"] = [
    {
      title: "ID",
      dataIndex: "id",
      key: "id",
      width: 50,
    },
    {
      title: "Doctor First Name",
      dataIndex: "firstName",
      key: "firstName",
    },

    {
      title: "Phone Last name",
      dataIndex: "lastName",
      key: "lastName",
    },
    {
      title: "Doctor birthday",
      dataIndex: "birthday",
      key: "birthday",
    },
    {
      title: "Doctor address",
      dataIndex: "address",
      key: "address",
    },
    {
      title: "Service ID",
      dataIndex: "serviceIds",
      key: "serviceIds",
    },
    {
      title: "Action",
      key: "action",
      width: 160,
      render: (_text, record) => (
        <Space size='middle'>
          <Tooltip title='View'>
            <Button onClick={() => handleViewDoctor(record)} className='table--action-btn' icon={<HiOutlineEye />} />
          </Tooltip>
          <Tooltip title='Edit'>
            <Button
              onClick={() => handleEditDoctor(record)}
              className='table--action-btn'
              icon={<HiOutlinePencilAlt />}
            />
          </Tooltip>
          <Tooltip title='Delete'>
            <Popconfirm title='Sure to delete?' onConfirm={() => handleDeleteDoctor(record.id)}>
              <Button className='table--action-btn' icon={<HiOutlineTrash />} />
            </Popconfirm>
          </Tooltip>
        </Space>
      ),
    },
  ];

  return (
    <div className='service-container'>
      <div className='service-container--header'>
        <Title level={4}> Total Doctors number : {countDoctors}</Title>
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
              handleCreateDoctor();
            }}
            type='primary'
            icon={<HiOutlinePlus />}
          >
            Add a new Doctor
          </Button>
        </div>
      </div>
      <div className='service-container--table'>
        <Table
          loading={status == "loading"}
          columns={columns}
          dataSource={tableContent}
          rowKey='id'
          pagination={false}
          scroll={{ y: 380 }}
        />
      </div>
    </div>
  );
};
export default Doctors;
