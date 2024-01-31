import React from "react";
import { FiShoppingCart } from "react-icons/fi";

const CartIcon = () => {
  return (
    <div className="relative">
      <FiShoppingCart className="w-6 h-6" />
      <span className="bg-red-500 text-white flex w-5 h-5 justify-center items-center rounded-full absolute -top-2 -right-4 text-xs">
        0
      </span>
    </div>
  );
};

export default CartIcon;
