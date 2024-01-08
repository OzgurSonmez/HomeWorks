import React from "react";
import { useSelector, useDispatch } from "react-redux";
import Laptop from "./Laptop";
import { clearCart } from "../control/cartSlice";

function LaptopList() {
  const dispatch = useDispatch();

  const { cartItems, quantity, total } = useSelector((store) => store.cart);

  return (
    <>
      {quantity < 1 ? (
        <section>
          <header>
            <h2>Sepetim</h2>
            <h3>Boş</h3>
          </header>
        </section>
      ) : (
        <section>
          <header>
            <h2>Sepetim</h2>
            <div>
              {cartItems.map((item) => {
                return <Laptop key={item.id} {...item} />;
              })}
            </div>
            <footer>
              <div>
                <hr />
                <h4>
                  Toplam Tutar : <span>{total} ₺</span>
                </h4>
              </div>
              <button
                className="cartClearButton"
                onClick={() => dispatch(clearCart())}
              >
                Temizle
              </button>
            </footer>
          </header>
        </section>
      )}
    </>
  );
}

export default LaptopList;
