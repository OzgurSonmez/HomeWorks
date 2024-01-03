import React from 'react'
import { Button, Menu } from 'semantic-ui-react'


//export default function SignedOut(props) { props kullanıldığında props.signIn }
// Object destructing : export default function SignedOut({signIn}) {... onClick={signIn} }
export default function SignedOut({signIn}) {
  return (
    <div>
        <Menu.Item>
            <Button onClick={signIn} primary >Giriş Yap</Button>
            <Button primary style={{marginLeft:"0.5em"}}>Kayıt Ol</Button>
        </Menu.Item>
        
    </div>
  )
}
