import { Feed } from "./components/Feed";
import Sidebar from "./components/Sidebar";
import { Topbar } from "./components/Topbar";

function App() {
  return (
    <div className="container">
      <>
        <Sidebar />

        <div className="home">
          <Topbar />
          <Feed />
        </div>
      </>
    </div>
  );
}

export default App;
