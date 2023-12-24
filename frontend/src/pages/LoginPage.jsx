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

const LoginPage = () => {
  const navigate = useNavigate();

  const [formData, setFormData] = useState({
    tcNo: "",
    password: ""
  });

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

      xhr.open("POST", "https://localhost:7151/api/User/login");
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
      <MDBRow>
        <MDBCol col="10" md="6">
          <img
            src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.webp"
            className="img-fluid"
            alt="Sample image"
          />
        </MDBCol>

        <MDBCol col="4" md="6">
          <MDBInput
            wrapperClass="mb-4"
            label="Tc Kimlik Numarası"
            id="formControlLg"
            type="int"
            size="lg"
            name="tcNo"
            onChange={handleChange}
          />
          <MDBInput
            wrapperClass="mb-4"
            label="Password"
            id="formControlLg"
            type="password"
            size="lg"
            name="password"
            onChange={handleChange}
          />

          <div className="text-center text-md-start mt-4 pt-2">
            <MDBBtn className="mb-0 px-5" size="lg" onClick={handleSubmit}>
              Login
            </MDBBtn>
            <p className="small fw-bold mt-2 pt-1 mb-2">
              Don't have an account?{" "}
              <a href="RegisterPage" className="link-danger">
                Register
              </a>
            </p>
          </div>
        </MDBCol>
      </MDBRow>
      <br></br>
      <br></br>
      <br></br>
      <br></br>
      <br></br>
    </MDBContainer>
  );
};

export default LoginPage;
