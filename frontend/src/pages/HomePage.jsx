import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "./css/HomePage.css"; // Import your CSS file
import { signal } from "@preact/signals-react";
import {
  MDBContainer,
  MDBCol,
  MDBRow,
  MDBBtn,
  MDBIcon,
  MDBInput,
  MDBCheckbox,
} from "mdb-react-ui-kit";

const HomePage = () => {
  const [isOpen, setIsOpen] = useState(false);
  const toggleDropdown = () => {
    setIsOpen(!isOpen);
  };

  return (
    <>
      <div className=" text-center min-h-screen flex flex-col items-center justify-center bg-gray-100 shadow-md p-6 rounded-lg mx-auto">
        {/* Animated Logo */}
        <img
          src="../logo.png"
          alt="Logo"
          className="mb-4  border-indigo-500 p-2 animation-fade-in "
        />
        {/* Title and Description */}
        <div className="text-center">
          <h1 className="text-3xl font-semibold text-indigo-600 mb-2">
          Merhaba UserName, size nasıl yardımcı olabilirim?
          </h1>
        </div>

        {/* Action Buttons */}
        <div className="mt-6 space-x-4 text-center">
          <Link to="/InsuranceSelectionPage">
            <MDBBtn rounded className="mx-2" color="secondary">
              Yeni sigorta kasko yaptırmak istiyorum
            </MDBBtn>
          </Link>
        </div>
      </div>
    </>
  );
};

export default HomePage;
