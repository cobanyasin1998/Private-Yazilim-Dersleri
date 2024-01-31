import { useState } from "react";
import Header from "./components/Header";
import Products from "./components/Products";
import Cart from "./components/Cart";

function App() {
  const [cart, setCart] = useState([]);

  return (
    <h1 className="container mx-auto p-4">
      <Header />
      <Products cart={cart} setCart={setCart} />
      {/* <Cart cart={cart} /> */}
    </h1>
  );
}

export default App;
