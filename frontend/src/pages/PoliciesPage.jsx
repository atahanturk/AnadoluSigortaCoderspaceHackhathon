import React, { useState, useEffect } from "react";
import {
  MDBTable,
  MDBTableHead,
  MDBTableBody,
  MDBPagination,
  MDBPaginationItem,
  MDBPaginationLink,
  MDBBtn,
} from "mdb-react-ui-kit";
import { useNavigate } from "react-router-dom";

const PoliciesPage = () => {
  const [data, setData] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    // Fetch data from the API
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://localhost:7151/api/user/1/policies"
        );
        if (!response.ok) {
          throw new Error("Failed to fetch data");
        }
        const result = await response.json();
        setData([result]); // Update the state with the fetched data
        console.log(result.healthPolicies);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []); // Empty dependency array ensures the effect runs only once on component mount

  // Calculate the indexes of the current page

  const currentData = data;

  return (
    <div>
      <MDBTable>
        <MDBTableHead>
          <tr>
            <th>INFO</th>
            <th>INFO</th>
            <th>INFO</th>
            <th>INFO</th>
          </tr>
        </MDBTableHead>
        <MDBTableBody>
          {currentData.length > 0 && (
            <MDBTableBody>
              {currentData[0].healthPolicies.map((item) => (
                <tr key={item.id}>
                  {/* Make sure to use a unique key for each row */}
                  <td>{item.customerTcNo}</td>
                  <td>{item.smokingStatus}</td>
                  <td>{item.geneticDisease}</td>
                  <td>{item.geneticDisease}</td>
                </tr>
              ))}
              {currentData[0].homePolicies.map((item) => (
                <tr key={item.id}>
                  {/* Make sure to use a unique key for each row */}
                  <td>{item.customerTcNo}</td>
                  <td>{item.homeType}</td>
                  <td>{item.homeAge}</td>
                  <td>{item.homeAge}</td>
                </tr>
              ))}
              {currentData[0].petPolicies.map((item) => (
                <tr key={item.id}>
                  {/* Make sure to use a unique key for each row */}
                  <td>{item.customerTcNo}</td>
                  <td>{item.petAge}</td>
                  <td>{item.genus}</td>
                  <td>{item.species}</td>
                </tr>
              ))}
            </MDBTableBody>
          )}
        </MDBTableBody>
      </MDBTable>
    </div>
  );
};

export default PoliciesPage;
