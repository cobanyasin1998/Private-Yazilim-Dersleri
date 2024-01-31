import React from "react";
import CartIcon from "./CartIcon";
const Header = () => {
  return (
    <div className="flex justify-between items-center mb-6">
      <h1 className="text-2xl font-semibold">
        React ve Tailwind CSS Sepet Uygulaması
      </h1>
      <CartIcon />
      <div></div>
    </div>
  );
};

export default Header;
