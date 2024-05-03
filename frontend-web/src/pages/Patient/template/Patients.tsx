import { Button, Popconfirm, Space, Table, TableProps, Tooltip } from "antd";
import Input, { SearchProps } from "antd/es/input";
import { useEffect, useState } from "react";
import { PatientsProps } from "./PatientsProps";
import Title from "antd/es/typography/Title";
import { HiOutlineEye, HiOutlinePencilAlt, HiOutlinePlus, HiOutlineTrash } from "react-icons/hi";
import "./Patients.scss";
import { Patient } from "../../../types/Patient";

const Patients: React.FC<PatientsProps> = ({
  patients,
  status,
  handleViewPatient,
  handleEditPatient,
  handleDeletePatient,
  handleCreatePatient,
}: PatientsProps) => {
  const { Search } = Input;
  const onSearch: SearchProps["onSearch"] = (value, _e, info) => console.log(info?.source, value);

  const [tableContent, setTableContent] = useState<Patient[]>([]);
  const [countPatients, setcountPatients] = useState(tableContent.length);

  useEffect(() => {
    // Extract specific fields from services and populate tableContent
    const tableContent = patients.map((patient) => ({
      id: patient.id,
      userName: patient.userName,
      phone: patient.phone,
      serviceId: patient.serviceId,
    }));
    setTableContent(tableContent);
    setcountPatients(tableContent.length);
  }, [patients]);

  const columns: TableProps<Patient>["columns"] = [
    {
      title: "ID",
      dataIndex: "id",
      key: "id",
      width: 50,
    },
    {
      title: "Patient Name",
      dataIndex: "userName",
      key: "userName",
    },

    {
      title: "Phone number",
      dataIndex: "phone",
      key: "phone",
    },
    {
      title: "Service ID",
      dataIndex: "serviceId",
      key: "serviceId",
    },
    {
      title: "Action",
      key: "action",
      width: 160,
      render: (_text, record) => (
        <Space size='middle'>
          <Tooltip title='View'>
            <Button onClick={() => handleViewPatient(record)} className='table--action-btn' icon={<HiOutlineEye />} />
          </Tooltip>
          <Tooltip title='Edit'>
            <Button
              onClick={() => handleEditPatient(record)}
              className='table--action-btn'
              icon={<HiOutlinePencilAlt />}
            />
          </Tooltip>
          <Tooltip title='Delete'>
            <Popconfirm title='Sure to delete?' onConfirm={() => handleDeletePatient(record.id)}>
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
        <Title level={4}> Total Patients number : {countPatients}</Title>
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
              handleCreatePatient();
            }}
            type='primary'
            icon={<HiOutlinePlus />}
          >
            Add a new Patient
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
export default Patients;
