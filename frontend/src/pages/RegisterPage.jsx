import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import {
  MDBContainer,
  MDBCol,
  MDBRow,
  MDBBtn,
  MDBIcon,
  MDBInput,
  MDBCheckbox,
} from "mdb-react-ui-kit";

const RegisterPage = () => {
  const [formData, setFormData] = useState({
    email: "",
    name: "",
    password: "",
    surname: "",
    tcNo: "",
    city: "",
    address: "",
    gender: "",
    healthPolicies: [],
    homePolicies: [],
    petPolicies: [],
  });
  const navigate = useNavigate();

  function getResponse() {
    var xhr = new XMLHttpRequest();

    return new Promise((resolve, reject) => {
      xhr.onreadystatechange = (e) => {
        if (xhr.readyState !== 4) {
          return;
        }

        if (xhr.status === 200) {
          resolve(xhr.responseText);
        } else {
          reject("request_error");
        }
      };

      xhr.open("POST", "https://localhost:7151/api/User/register");
      xhr.setRequestHeader("Content-Type", "application/json"); // Set Content-Type header
      xhr.send(JSON.stringify(formData));
    });
  }

  const handleChange = (e) => {
    const { name, value } = e.target;

    setFormData((prevData) => ({ ...prevData, [name]: value }));
  };

  function handleSubmit(e) {
    e.preventDefault();

    getResponse()
      .then((res) => {
        console.log("SUCCESS", res);
        // If you want to navigate to another page after successful registration, use the appropriate navigation logic here
        navigate("/");
        
      })
      .catch((error) => console.warn("Error:", error));
  }

  return (
    <MDBContainer fluid className="p-3 my-5 h-auto">
      <MDBRow className="d-flex justify-content-center">
        <MDBCol col="4" md="4">
          <MDBInput
            wrapperClass="mb-4"
            label="Email adresi"
            id="formControlLg"
            type="email"
            name="email"
            onChange={handleChange}
            size="lg"
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Kullanıcı Adı"
            id="formControlLg"
            type="string"
            size="lg"
            name="name"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="TC Kimlik Numarası"
            id="formControlLg"
            type="int"
            size="lg"
            name="tcNo"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Soyadı"
            id="formControlLg"
            type="string"
            size="lg"
            name="surname"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Şehir"
            id="formControlLg"
            type="strinng"
            size="lg"
            name="city"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Adres"
            id="formControlLg"
            type="string"
            size="lg"
            name="address"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Cinsiyet"
            id="formControlLg"
            type="string"
            size="lg"
            name="gender"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Parola"
            id="formControlLg"
            type="password"
            size="lg"
            name="password"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Parola Onay"
            id="formControlLg"
            type="password"
            size="lg"
            name="passwordConfirmation"
            onChange={handleChange}
          />

          <div className="d-flex flex-row align-items-center justify-content-center">
            <p className="lead fw-normal mb-0 me-3"> Register with</p>
            <MDBBtn floating size="md" tag="a" className="me-2">
              <MDBIcon fab icon="google" />
            </MDBBtn>
          </div>
          <div className="mt-3 d-flex flex-row align-items-center justify-content-center">
            <MDBBtn className="mb-0 px-5" size="lg" onClick={handleSubmit}>
              Register
            </MDBBtn>
          </div>
        </MDBCol>
      </MDBRow>

      <br></br>
      <br></br>
      <br></br>
      <br></br>
      <br></br>
      <br></br>
    </MDBContainer>
  );
};

export default RegisterPage;
