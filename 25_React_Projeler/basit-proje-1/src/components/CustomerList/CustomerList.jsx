import { useState } from "react";
import CustomerItem from "../CustomerItem/CustomerItem";
import "./CustomerList.css";

const CustomerList = ({ customers, setCustomers }) => {
  const handleDelete = (item) => {
    setCustomers(customers.filter((customer) => customer.id !== item.id));
  };

  return (
    <ul className="customer-list">
      {customers.map((customer) => (
        <CustomerItem
          key={customer.id}
          customer={customer}
          handleDelete={handleDelete}
        />
      ))}
    </ul>
  );
};

export default CustomerList;
