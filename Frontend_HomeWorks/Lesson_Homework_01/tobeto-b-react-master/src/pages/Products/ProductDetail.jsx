import React, { useEffect, useState } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";
import { Link } from "react-router-dom";

export default function ProductDetail() {
  const [productDetail, setProductDetail] = useState([]);

  let { id } = useParams(); //URL'den id parametresi alındı

  useEffect(() => {
    axiosGet();
  }, []);

  const axiosGet = async () => {
    let response = await axios.get("https://dummyjson.com/products/" + id);
    setProductDetail(response.data);
  };

  return (
    <div className="container d-flex justify-content-center mt-5">
      <div className="card" style={{ width: "18rem" }}>
        <img
          src={productDetail.thumbnail}
          className="img-fluid rounded-start"
          alt="..."
        />
        <div className="card-body">
          <h5 className="card-title" style={{ textAlign: "center" }}>
            {productDetail.title}
          </h5>
          <p className="card-text">{productDetail.description}</p>
        </div>
        <ul className="list-group list-group-flush">
          <li className="list-group-item">
            <strong>Price: </strong> {productDetail.price} £{" "}
          </li>
          <li className="list-group-item">
            <strong>Category: </strong>
            {productDetail.category}
          </li>
          <li className="list-group-item">
            <strong>Brand: </strong>
            {productDetail.brand}
          </li>
          <li className="list-group-item">
            <strong>Rating:</strong> 5/{productDetail.rating}
          </li>
          <li className="list-group-item">
            <strong>Stock: </strong> {productDetail.stock}
          </li>
        </ul>
        <div className="card-body" style={{ textAlign: "center" }}>
          <Link to={"/products/"} className="btn btn-violet mb-3" style={{ backgroundColor: "purple", color: "white" }}> Products </Link>
        </div>
      </div>
    </div>
  );
}
