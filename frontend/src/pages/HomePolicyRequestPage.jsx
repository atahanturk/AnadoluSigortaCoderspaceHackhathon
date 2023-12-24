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
    customerTcNo: "",
    homeType: true,
    homeAge: true,
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

      xhr.open("POST", "https://localhost:7151/api/policies/home/request");
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
        navigate("/HomePage");
        
      })
      .catch((error) => console.warn("Error:", error));
  }

  return (
    <MDBContainer fluid className="p-3 my-5 h-auto">
      <MDBRow className="d-flex justify-content-center">
        <MDBCol col="4" md="4">
          <MDBInput
            wrapperClass="mb-4"
            label="Tc Kimlik Numarası"
            id="formControlLg"
            type="int"
            name="customerTcNo"
            onChange={handleChange}
            size="lg"
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Sigara Durumu"
            id="formControlLg"
            type="string"
            size="lg"
            name="homeType"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Genetik Hastalık Durumu"
            id="formControlLg"
            type="int"
            size="lg"
            name="homeAge"
            onChange={handleChange}
          />

      
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
