import logo from './logo.svg';
import { Route, Routes } from "react-router-dom";
import LoginPage from "./pages/LoginPage";
import RegisterPage from "./pages/RegisterPage";
import HomePage from "./pages/HomePage";
import ProfilePage from "./pages/ProfilePage";
import WrongRoute from "./pages/WrongRoute";
import InsuranceSelectionPage from "./pages/InsuranceSelectionPage"
import DamageRecordPage from "./pages/DamageRecordPage"
import HealthPolicyRequestPage from "./pages/HealthPolicyRequestPage"
import HomePolicyRequestPage from "./pages/HomePolicyRequestPage"
import PetPolicyRequestPage from "./pages/PetPolicyRequestPage"
import PoliciesPage from "./pages/PoliciesPage"


function App() {
  return (

    <Routes>
      <Route path="/" element={<LoginPage></LoginPage>}></Route>
      <Route path="/RegisterPage" element={<RegisterPage></RegisterPage>}></Route>
      <Route path="/HomePage" element={<HomePage></HomePage>}></Route>
      <Route path="/ProfilePage" element={<ProfilePage></ProfilePage>}></Route>
      <Route path="/InsuranceSelectionPage" element={<InsuranceSelectionPage></InsuranceSelectionPage>}></Route>
      <Route path="/DamageRecordPage" element={<DamageRecordPage></DamageRecordPage>}></Route>
      <Route path="/HealthPolicyRequestPage" element={<HealthPolicyRequestPage></HealthPolicyRequestPage>}></Route>
      <Route path="/HomePolicyRequestPage" element={<HomePolicyRequestPage></HomePolicyRequestPage>}></Route>
      <Route path="/PetPolicyRequestPage" element={<PetPolicyRequestPage></PetPolicyRequestPage>}></Route>
      <Route path="/PoliciesPage" element={<PoliciesPage></PoliciesPage>}></Route>
      <Route path="*" element={<WrongRoute />}></Route>
    </Routes>
   


    
  );
}

export default App;
