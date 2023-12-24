import {
  MDBContainer,
  MDBCol,
  MDBRow,
  MDBBtn,
  MDBIcon,
  MDBInput,
  MDBCheckbox,
} from "mdb-react-ui-kit";

const Footer = () => {
  return (
    <div className="d-flex flex-column flex-md-row text-center text-md-start justify-content-between py-4 px-4 px-xl-5 bg-primary" >
      <div className="text-white mb-3 mb-md-0">
        Copyright © 2020. All rights reserved.
      </div>

      <div>
        <MDBBtn
          tag="a"
          color="none"
          className="mx-3"
          style={{ color: "white" }}
        >
          <MDBIcon fab icon="facebook-f" size="md" />
        </MDBBtn>

        <MDBBtn
          tag="a"
          color="none"
          className="mx-3"
          style={{ color: "white" }}
        >
          <MDBIcon fab icon="twitter" size="md" />
        </MDBBtn>

        <MDBBtn
          tag="a"
          color="none"
          className="mx-3"
          style={{ color: "white" }}
        >
          <MDBIcon fab icon="google" size="md" />
        </MDBBtn>

        <MDBBtn
          tag="a"
          color="none"
          className="mx-3"
          style={{ color: "white" }}
        >
          <MDBIcon fab icon="linkedin-in" size="md" />
        </MDBBtn>
      </div>
    </div>
  );
};

export default Footer;
