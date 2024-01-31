import React from "react";

const Cart = ({ cart }) => {
  if (cart.length === 0) {
    return (
      <div className="border ml-auto w-72 p-4 mt-2 rounded-lg shadow-lg">
        <h2 className="text-2xl font-semibold mb-4">Sepet </h2>
        <p className="text-xl">Sepetiniz boş.</p>
      </div>
    );
  } else {
    return (
      <div className="border ml-auto w-72 p-4 mt-2 rounded-lg shadow-lg">
        <h2 className="text-2xl font-semibold mb-4">Sepet </h2>
        <>
          <ul>
            {cart.map((prd) => (
              <li className="mt-2 flex justify-between" key={prd.id}>
                <span>{prd.name}</span>
                <span>{prd.price} TL</span>
              </li>
            ))}
          </ul>
          <hr className="my-4" />
          <p className="font-semibold text-xl mt-2">Toplam: 100TL</p>
          <button className="bg-red-500 text-white rounded px-2 py-2 w-full hover:bg-red-600 transition-all mt-4">
            Sepeti Boşalt
          </button>
        </>
      </div>
    );
  }
};

export default Cart;
