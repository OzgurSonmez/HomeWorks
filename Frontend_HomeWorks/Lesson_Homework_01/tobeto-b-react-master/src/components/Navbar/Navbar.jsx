import { Link } from "react-router-dom";
import Products from "../../pages/Products/Products";

function Navbar() {
  return (
    <nav
      className="navbar bg-dark navbar-expand-lg bg-body-tertiary"
      data-bs-theme="dark"
    >
      <div className="container-fluid">
        <a className="navbar-brand" href="#">
          Pair 4
        </a>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarSupportedContent">
          <ul className="navbar-nav me-auto mb-2 mb-lg-0">
            <li className="nav-item">
              <Link to="/products" className="nav-link active" aria-current="page">
                Home
              </Link>
            </li>
            <li className="nav-item">
              <Link to="/addproduct" className="nav-link active" aria-current="page">
                Add Product
              </Link>
            </li>
          </ul>
          <form className="d-flex" role="search">
            <input
              className="form-control me-2"
              type="search"
              placeholder="Search"
              aria-label="Search"
            />
            <div className="d-grid gap-2 d-md-flex justify-content-md-end">
              <button className="btn btn-outline-success" type="button">
                Search
              </button>
              <div>
              </div>

            </div>
          </form>
        </div>
      </div>
    </nav>
  );
}

export default Navbar;
