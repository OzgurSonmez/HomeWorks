import React from "react";
import { LuShoppingBasket } from "react-icons/lu";
import "./Navbar.css";
import { useSelector } from "react-redux";

function Navbar() {
  const { quantity } = useSelector((store) => store.cart);
  console.log(useSelector((store) => store.cart));
  return (
    <nav>
      <div className="navbar-container">
        <h3>Laptop Shop</h3>
        <div className="cart-container">
          <LuShoppingBasket />
          <span>{quantity}</span>
        </div>
      </div>
    </nav>
  );
}

export default Navbar;
