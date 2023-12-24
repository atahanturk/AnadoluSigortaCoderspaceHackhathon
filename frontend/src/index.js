import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter } from "react-router-dom";
import 'mdb-react-ui-kit/dist/css/mdb.min.css';
import "@fortawesome/fontawesome-free/css/all.min.css";
import Footer from "./components/Footer";
import Header from "./components/Header";


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <>
    <Header></Header>
    <div >
      <BrowserRouter>
        <App />
      </BrowserRouter>

    </div>
   
      <Footer ></Footer>


  </>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
