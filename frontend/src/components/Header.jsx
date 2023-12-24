import React, { useState } from 'react';
import {
  MDBNavbar,
  MDBNavbarNav,
  MDBNavbarItem,
  MDBNavbarLink,
  MDBNavbarToggler,
  MDBContainer,
  MDBCollapse,
  MDBIcon
} from 'mdb-react-ui-kit';

const Header = () => {
  return (
    <header >
      <MDBNavbar expand='lg' light bgColor='white' className='mx-5' >
        <MDBContainer fluid >
          

          
            <MDBNavbarNav className='justify-content-between' right>
              <MDBNavbarItem active>
                <MDBNavbarLink aria-current='page' href='HomePage'>
                  Home
                </MDBNavbarLink>
              </MDBNavbarItem>
              <MDBNavbarItem>
                <MDBNavbarLink href='#'>Features</MDBNavbarLink>
              </MDBNavbarItem>
              <MDBNavbarItem>
                <MDBNavbarLink href='#'>Pricing</MDBNavbarLink>
              </MDBNavbarItem>
              <MDBNavbarItem>
                <MDBNavbarLink href='ProfilePage'><i className="fas fa-user"></i></MDBNavbarLink>
              </MDBNavbarItem>
            </MDBNavbarNav>
        </MDBContainer>
      </MDBNavbar>
    </header>
  );
}

export default Header;
