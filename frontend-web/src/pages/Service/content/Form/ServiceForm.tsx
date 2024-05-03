import React from "react";
import { Form, Input, Button } from "antd";
import { service } from "../../../../types/Service";

interface ServiceFormProps {
  service?: service;
  onSubmit: (values: service) => void;
}

const ServiceForm: React.FC<ServiceFormProps> = ({ service, onSubmit }) => {
  const [form] = Form.useForm();

  // Set initial form values if service is provided (for updating)
  const initialValues = service ? { ...service } : {};

  // Handle form submission
  const handleSubmit = async (values: service) => {
    onSubmit(values);
  };

  return (
    <Form form={form} initialValues={initialValues} onFinish={handleSubmit} layout='vertical'>
      {/* Hidden input field for id */}
      {service && (
        <Form.Item name='id' style={{ display: "none" }}>
          <Input type='hidden' />
        </Form.Item>
      )}
      <Form.Item label='Name' name='name' rules={[{ required: true, message: "Please enter the service name" }]}>
        <Input />
      </Form.Item>

      <Form.Item
        label='Description'
        name='description'
        rules={[{ required: true, message: "Please enter the description" }]}
      >
        <Input.TextArea />
      </Form.Item>
      <Form.Item>
        <Button type='primary' htmlType='submit'>
          {service ? "Update Service" : "Create Service"}
        </Button>
      </Form.Item>
    </Form>
  );
};

export default ServiceForm;
