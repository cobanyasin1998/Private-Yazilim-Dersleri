import CustomerForm from "./components/CustomerForm/CustomerForm";
import CustomerList from "./components/CustomerList/CustomerList";
import "./App.css";
import { useState } from "react";
function App() {
  const [customers, setCustomers] = useState([]);

  const addNewCustomer = (newCustomer) => {
    //setCustomers([...customers, newCustomer]);
    setCustomers((prevCustomers) => {
      return [newCustomer, ...prevCustomers];
    });
  };
  return (
    <div className="App">
      <>
        <h1>Customer Manage System</h1>
        <CustomerForm addNewCustomer={addNewCustomer} />
        {customers.length === 0 && (
          <p className="no-customer">No customer found</p>
        )}
        <CustomerList customers={customers} setCustomers={setCustomers} />
      </>
    </div>
  );
}

export default App;
