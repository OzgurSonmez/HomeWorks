import React from "react";
import { MdOutlineNavigateBefore, MdOutlineNavigateNext } from "react-icons/md";
import "./Laptop.css";
import { useDispatch } from "react-redux";
import { removeItem, increase, decrease } from "../control/cartSlice";

function Laptop({ id, title, price, img, quantity }) {
  const dispatch = useDispatch();

  return (
    <div className="laptop-container">
      <div className="laptop-photo">
        <img src={img}></img>
      </div>
      <div className="content">
        <span className="title"> {title} </span>
        <span className="price"> {price} </span>
        <div className="laptop-quantity">
          <button
            className="cartQuantityButton"
            onClick={() => dispatch(decrease(id))}
          >
            <MdOutlineNavigateBefore />
          </button>

          <span className="quantity"> {quantity} </span>
          <button
            className="cartQuantityButton"
            onClick={() => dispatch(increase(id))}
          >
            <MdOutlineNavigateNext />
          </button>
        </div>
      </div>
      <button
        className="cartDeleteButton"
        onClick={() => dispatch(removeItem(id))}
      >
        Sil
      </button>
    </div>
  );
}

export default Laptop;
