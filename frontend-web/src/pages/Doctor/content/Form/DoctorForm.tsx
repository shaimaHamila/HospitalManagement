import React, { useEffect } from "react";
import { Form, Input, Button, Select, DatePicker } from "antd";
import { store } from "../../../../store/store";
import { fetchServices, selectServices } from "../../../../features/service/serviceSlice";
import { useSelector } from "react-redux";
import { Doctor } from "../../../../types/Dctor";

interface DoctorFormProps {
  doctor?: Doctor;
  onSubmit: (values: Doctor) => void;
}

const DoctorForm: React.FC<DoctorFormProps> = ({ doctor, onSubmit }) => {
  const [form] = Form.useForm();
  const services = useSelector(selectServices);
  useEffect(() => {
    store.dispatch(fetchServices());
  }, []);

  // Set initial form values if service is provided (for updating)
  const initialValues = doctor ? { ...doctor } : {};
  // Handle form submission
  const handleSubmit = async (values: Doctor) => {
    onSubmit(values);
  };

  return (
    <Form form={form} initialValues={initialValues} onFinish={handleSubmit} layout='vertical'>
      {/* Hidden input field for id */}
      {doctor && (
        <Form.Item name='id' style={{ display: "none" }}>
          <Input type='hidden' />
        </Form.Item>
      )}
      <Form.Item
        label='Doctor First Name'
        name='firstName'
        rules={[{ required: true, message: "Please enter the doctor name" }]}
      >
        <Input />
      </Form.Item>
      <Form.Item
        label='Doctor Last Name'
        name='lastName'
        rules={[{ required: true, message: "Please enter the doctor name" }]}
      >
        <Input />
      </Form.Item>
      <Form.Item
        label='Doctor Address'
        name='address'
        rules={[{ required: true, message: "Please enter the doctor address" }]}
      >
        <Input />
      </Form.Item>
      {!doctor && (
        <Form.Item
          label='Doctor Birthday'
          name='birthday'
          rules={[{ required: true, message: "Please enter the doctor birthday" }]}
        >
          <DatePicker format='YYYY-MM-DD' />
        </Form.Item>
      )}

      <Form.Item
        label='Select Service'
        name='serviceIds'
        rules={[{ required: true, message: "Please select services" }]}
      >
        <Select mode='multiple'>
          {services.map((service) => (
            <Select.Option key={service.id} value={service.id}>
              {service.name}
            </Select.Option>
          ))}
        </Select>
      </Form.Item>
      <Form.Item>
        <Button type='primary' htmlType='submit'>
          {doctor ? "Update Doctor" : "Create Doctor"}
        </Button>
      </Form.Item>
    </Form>
  );
};

export default DoctorForm;
