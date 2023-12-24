import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import "./css/HomePage.css"; // Import your CSS file
import {
  MDBContainer,
  MDBBtn,
  MDBRow,
  MDBCol,
  MDBTable,
  MDBTableBody,
  MDBTableHead,
  MDBPagination,
  MDBPaginationItem,
  MDBPaginationLink,
} from "mdb-react-ui-kit";
import { Pagination } from "react-bootstrap";

const InsurancePolicyPage = () => {
  const data = [
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    { id: 1, name: "John Doe", email: "john.doe@example.com" },
    // Add more data as needed
  ];

  const [currentPage, setCurrentPage] = useState(1);

  const handlePageChange = (page) => {
    setCurrentPage(page);
  };

  const pageSize = 5; // Number of rows per page

  // Calculate the indexes of the current page
  const indexOfLastItem = currentPage * pageSize;
  const indexOfFirstItem = indexOfLastItem - pageSize;
  const currentData = data.slice(indexOfFirstItem, indexOfLastItem);

  return (
    <div>
      <MDBTable>
        <MDBTableHead>
          <tr>
            <th>Tarih</th>
            <th>Araç Üretim Tarihi</th>
            <th>Kayıtlı Olduğu İl</th>
            <th>Araba Modeli</th>
            <th>Plaka</th>
            <th>Yedek Araç Durumu</th>
          </tr>
        </MDBTableHead>
        <MDBTableBody>
          <tr>
            <td>10.09.2022</td>
            <td>10.09.2020</td>
            <td>Ankara</td>
            <td>Mercedes Benz</td>
            <td>06 SJW 0012</td>
            <td>Verilmedi</td>
          </tr>
          {/* Add more rows as needed */}
        </MDBTableBody>
      </MDBTable>
      <MDBPagination className="mt-3">
        {[...Array(Math.ceil(data.length / pageSize)).keys()].map((page) => (
          <MDBPaginationItem key={page + 1} active={page + 1 === currentPage}>
            <MDBPaginationLink onClick={() => handlePageChange(page + 1)}>
              <MDBBtn  >
                {page + 1}
              </MDBBtn>
            </MDBPaginationLink>
          </MDBPaginationItem>
        ))}
      </MDBPagination>
    </div>
  );
};

export default InsurancePolicyPage;
