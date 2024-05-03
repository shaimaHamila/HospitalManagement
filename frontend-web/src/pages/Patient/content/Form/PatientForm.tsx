import React, { useEffect } from "react";
import { Form, Input, Button, Select } from "antd";
import { Patient } from "../../../../types/Patient";
import { store } from "../../../../store/store";
import { fetchServices, selectServices } from "../../../../features/service/serviceSlice";
import { useSelector } from "react-redux";

interface ServiceFormProps {
  patient?: Patient;
  onSubmit: (values: Patient) => void;
}

const PatientForm: React.FC<ServiceFormProps> = ({ patient, onSubmit }) => {
  const [form] = Form.useForm();
  const services = useSelector(selectServices);

  useEffect(() => {
    store.dispatch(fetchServices());
  }, []);

  // Set initial form values if service is provided (for updating)
  const initialValues = patient ? { ...patient } : {};
  // Handle form submission
  const handleSubmit = async (values: Patient) => {
    onSubmit(values);
  };

  return (
    <Form form={form} initialValues={initialValues} onFinish={handleSubmit} layout='vertical'>
      {/* Hidden input field for id */}
      {patient && (
        <Form.Item name='id' style={{ display: "none" }}>
          <Input type='hidden' />
        </Form.Item>
      )}
      <Form.Item
        label='Patient Name'
        name='userName'
        rules={[{ required: true, message: "Please enter the patient name" }]}
      >
        <Input />
      </Form.Item>
      <Form.Item
        label='Patient phone number'
        name='phone'
        rules={[{ required: true, message: "Please enter the patient phone" }]}
      >
        <Input type='number' />
      </Form.Item>

      <Form.Item
        label='Select Service'
        name='serviceId'
        rules={[{ required: true, message: "Please select a service" }]}
      >
        <Select defaultValue={patient ? patient.serviceId : undefined}>
          {services.map((service) => (
            <Select.Option key={service.id} value={service.id}>
              {service.name}
            </Select.Option>
          ))}
        </Select>
      </Form.Item>
      <Form.Item>
        <Button type='primary' htmlType='submit'>
          {patient ? "Update Patient" : "Create Patient"}
        </Button>
      </Form.Item>
    </Form>
  );
};

export default PatientForm;
