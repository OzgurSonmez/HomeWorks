import "./App.css";
import Laptop from "./components/Laptop";
import LaptopList from "./components/LaptopList";
import Navbar from "./components/Navbar";
import { useEffect } from "react";
import { calculateTotal } from "./control/cartSlice";
import { useSelector, useDispatch } from "react-redux";

function App() {
  const { cartItems } = useSelector((store) => store.cart);
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(calculateTotal());
  }, [cartItems]);

  return (
    <div className="App">
      <Navbar />
      <LaptopList />
    </div>
  );
}

export default App;
