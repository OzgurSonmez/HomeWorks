//rfc(snippet) : React Functional Component
import React, {useState} from "react";
import CartSummary from "./CartSummary";
import { Container, Menu } from "semantic-ui-react";
import SignedIn from "./SignedIn";
import SignedOut from "./SignedOut";
import { useNavigate } from "react-router-dom"
import { useSelector } from "react-redux";

export default function Navi() {
  const { cartItems } = useSelector(state => state.cart);
  const [isAuthenticated, setIsAuthenticated] = useState(true) //default giriş durumu : true

 const navigate = useNavigate() // useHistory yerine kullanıldı

  function handleSignOut() {
    setIsAuthenticated(false)
    navigate("/")
  }

  function handleSignIn() {
    setIsAuthenticated(true)
  }

  return (
    <div>
      <Menu inverted fixed="top">
        <Container>
          <Menu.Item name="home" />
          <Menu.Item name="messages" />

          <Menu.Menu position="right">
            {cartItems.length > 0 && <CartSummary/>} {/* Sepette ürün varsa sepeti göster */ }
            {isAuthenticated ? <SignedIn signOut={handleSignOut} /> : <SignedOut signIn={handleSignIn} />} {/* Giriş yapılıysa SignedIn, değilse SignedOut */}
          </Menu.Menu>
        </Container>
      </Menu>
    </div>
  );
}
