import axios from "axios";
import { useState } from "react";
import { Link } from "react-router-dom";
import Products from "../../pages/Products/Products";

function ProductCard({ product, setProduct }) {
  const [deleteProductId, setDeleteProductId] = useState(0)



  // const handleDeleteProduct = (id) => {
  //   axios
  //     .delete("https://dummyjson.com/products/" + id)
  //     .then((response) => {
  //       console.log(response.data)
  //     })
  //     .catch((error) => console.error(error));
  // };

  return (
    <div className="card">
      <img
        src={product.thumbnail}
        className="card-img-top img-fluid"
        alt="..."
      />
      <div className="card-body">
        <h5 className="card-title">{product.title}</h5>
        <p className="card-text">{product.description}</p>
        <Link to={"/products/" + product.id} className="btn btn-primary">
          Detail
        </Link>
        <button
          className="btn btn-danger"
          onClick={() => setProduct(product.id)}
        >
          Delete
        </button>
      </div>
    </div >
  );
}

export default ProductCard;
