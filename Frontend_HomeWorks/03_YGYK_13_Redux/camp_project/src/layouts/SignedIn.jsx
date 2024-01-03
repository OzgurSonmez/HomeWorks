import React from "react";
import { Menu, Image, Dropdown } from "semantic-ui-react";

//export default function SignedIn(props) { props kullanıldığında props.signOut }
// Object destructing : export default function SignedIn({signOut}) {... onClick={signOut} }
export default function SignedIn({signOut}) {
  return (
    <div>
      <Menu.Item>
        <Image
          avatar
          spaced="right"
          src="https://www.pngall.com/wp-content/uploads/12/Avatar-Profile-Vector.png"
        />
        <Dropdown pointing="top right" text="Özgür">
          <Dropdown.Menu>
            <Dropdown.Item text="Bilgilerim" icon="info" />
            <Dropdown.Item onClick={signOut} text="Çıkış Yap" icon="sign-out" />
          </Dropdown.Menu>
        </Dropdown>
      </Menu.Item>
    </div>
  );
}
