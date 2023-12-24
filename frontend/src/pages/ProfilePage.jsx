import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "./css/HomePage.css"; // Import your CSS file
import { MDBContainer, MDBBtn, MDBRow, MDBCol } from "mdb-react-ui-kit";

const ProfilePage = () => {
  const [isOpen, setIsOpen] = useState(false);
  const toggleDropdown = () => {
    setIsOpen(!isOpen);
  };

  return (
    <MDBContainer className="my-4">
      <MDBRow className="justify-content-center align-items-center bg-gray-100 shadow-md p-6 rounded-lg mx-auto space-x-4">
        {/* First Card */}
        <MDBCol size="auto">
          <div className="card" style={{ width: "18rem" }}>
            <img
              src="https://mdbcdn.b-cdn.net/img/new/standard/city/062.webp"
              className="card-img-top"
              alt="Chicago Skyscrapers"
            />
            <div className="card-body">
              <h5 className="card-title">USER CARD</h5>
              <p className="card-text">You can see your info below</p>
            </div>
            <ul className="list-group list-group-light list-group-small">
              <li className="list-group-item px-4">Adı: UserName</li>
              <li className="list-group-item px-4">Soyadı: Surname</li>
              <li className="list-group-item px-4">E Posta: a@gmail.com</li>
              <li className="list-group-item px-4">E Posta: a@gmail.com</li>
              <li className="list-group-item px-4">T.C.: 10101010101</li>
              <li className="list-group-item px-4">Telefon No: 6666666666</li>
              <li className="list-group-item px-4">Açık Adres: Beytepe</li>
            </ul>
            <div className="card-body">
              <Link to="/datagrid">
                <MDBBtn color="light" rippleColor="dark">
                  Edit Profile
                </MDBBtn>
              </Link>
              <Link to="/list">
                <MDBBtn color="dark">Delete Profile</MDBBtn>
              </Link>
            </div>
          </div>
        </MDBCol>

        {/* Second Card */}
        <MDBCol size="auto">
          <div className="card" style={{ width: "18rem" }}>
            <img
              src="http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcQEUjp0Fy74ZRBuYcH7bOZHtB-2AWbTThYHo_2A9eTJuolJPX2hnikLyPfEMka4YQzFW-wtpoSqrq4YiPDFS3s"
              className="card-img-top"
              alt="User Car"
            />
            <div className="card-body">
              <h5 className="card-title">Your Car</h5>
              <p className="card-text">You can see your car info below</p>
            </div>
            <ul className="list-group list-group-light list-group-small">
              <li className="list-group-item px-4">Marka ve Model: Ferrari</li>
              <li className="list-group-item px-4">Plaka Kodu: Surname</li>
              <li className="list-group-item px-4">Ruhsat Numarası: a@gmail.com</li>
              <li className="list-group-item px-4">Yılı: a@gmail.com</li>
            </ul>
          </div>
        </MDBCol>

        {/* Action Buttons */}
        <div className="mt-6 space-x-4 text-center">
          <Link to="/DamageRecordPage">
            <MDBBtn color="primary" rippleColor="dark">
              Hasar Kayıtlarım
            </MDBBtn>
          </Link>
          <Link to="/PoliciesPage">
            <MDBBtn color="secondary">Poliçelerimi Göster</MDBBtn>
          </Link>
        </div>
      </MDBRow>
    </MDBContainer>
  );
};

export default ProfilePage;
