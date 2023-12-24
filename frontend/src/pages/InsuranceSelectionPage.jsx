import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "./css/HomePage.css"; // Import your CSS file
import { MDBContainer, MDBCol, MDBRow } from "mdb-react-ui-kit";

const InsuranceSelectionPage = () => {
  const [isOpen, setIsOpen] = useState(false);
  const toggleDropdown = () => {
    setIsOpen(!isOpen);
  };

  return (
    <MDBContainer>
      <MDBRow className="text-center min-h-screen d-flex items-center justify-around bg-gray-100 shadow-md p-6 rounded-lg mx-auto">
        {/* Animated Logo */}
        <MDBCol size="auto" className="mb-4">
          <a href="/HomePolicyRequestPage">
            <img
              src="https://prefabrikevfiyatlari.com/cdn/shop/products/105m2_934x700.jpg?v=1632922782"
              alt="Logo"
              className="border-indigo-500 p-2 animation-fade-in"
              style={{ width: "30vw" }}
            />
            <div>Konut Sigortası</div>
          </a>
        </MDBCol>
        <MDBCol size="auto" className="mb-4">
          <a href="/PetPolicyRequestPage">
            <img
              src="https://www.dogansigorta.com/img/images/pati.jpg"
              alt="Logo"
              className="border-indigo-500 p-2 animation-fade-in"
              style={{ width: "30vw" }}
            />
            <div>Pet Sigortası</div>
          </a>
        </MDBCol>
        <MDBCol size="auto" className="mb-4">
          <a href="/HealthPolicyRequestPage">
            <img
              src="https://arabam-blog.mncdn.com/wp-content/uploads/2022/12/best-luxury-car-brands-bugatti-2022-luxe-digital.jpg"
              alt="Logo"
              className="border-indigo-500 p-2 animation-fade-in"
              style={{ width: "30vw" }}
            />
            <div>Sağlık Sigortası</div>
          </a>
        </MDBCol>

        {/* Title and Description */}
        <div className="text-center">
          <h1 className="text-3xl font-semibold text-indigo-600 mb-2">
            Merhaba UserName, size nasıl yardımcı olabilirim?
          </h1>
        </div>
      </MDBRow>
    </MDBContainer>
  );
};

export default InsuranceSelectionPage;
