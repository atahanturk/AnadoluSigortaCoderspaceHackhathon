import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "./css/HomePage.css"; // Import your CSS file
import { signal } from "@preact/signals-react";
import {MDBContainer, MDBCol, MDBRow, MDBBtn, MDBIcon, MDBInput, MDBCheckbox } from 'mdb-react-ui-kit';

const SubmissionGridPage = () => {
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
            ANADOLU SIGORTA - BEYTEPE BUDGIES
          </h1>
          <p className="text-gray-600 text-lg">
            Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nesciunt nihil quos voluptates sunt vel? Distinctio maiores odit iste ipsam et, aliquid vero mollitia non rerum? Ex odit impedit accusantium laboriosam!
          </p>
        </div>

        {/* Action Buttons */}
        <div className="mt-6 space-x-4 text-center">
          <Link to="/datagrid">
            <MDBBtn color="light" rippleColor="dark">A PAGE</MDBBtn>
          </Link>
          <Link to="/list">
            <MDBBtn color="dark">B PAGE</MDBBtn>
          </Link>
        </div>

        
      </div>
    </>
  );
};

export default SubmissionGridPage;
