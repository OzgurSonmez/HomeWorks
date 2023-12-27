import axios from "axios";
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

export default function AddProduct() {

  const [product, setProduct] = useState({
    title: '',
    description: '',
    price: 0,
    category: '',
    brand: '',
    rating: 0,
    stock: 0,
    image: '',
  })

  const handleProductChange = (e) => {
    const { id, value } = e.target;
    setProduct((prevProduct) => ({
      ...prevProduct,
      [id]: value,
    }));
  };


  const navigate = useNavigate();
  const handleAddProduct = () => {
    axios.post('https://dummyjson.com/products/add', {
      title: product.title,
      description: product.description,
      price: product.price,
      category: product.category,
      brand: product.brand,
      rating: product.rating,
      stock: product.stock,
      image: product.image,
    })
      .then(response => {
        console.log(response.data)
        console.log('New product added', product);
        navigate('/products');
      })
      .catch(error => {
        console.error('Error:', error)
        alert('New product added');
      });
  };


  return (
    <div className="container mt-5">
      <h2 className="mb-4">Add a Product</h2>
      <div className="mb-3">
        <label htmlFor="title" className="form-label fw-bold">
          Title :
        </label>
        <input
          type="text"
          className="form-control"
          id="title"
          onChange={handleProductChange}
          placeholder="MacBook Pro"
        />
      </div>
      <div className="mb-3">
        <label htmlFor="description" className="form-label fw-bold">
          Description :
        </label>
        <input
          type="text"
          className="form-control"
          id="description"
          onChange={handleProductChange}
          placeholder="MacBook Pro 2021 with mini-LED display may launch between September, November"
        />
      </div>

      <div className="mb-3">
        <label htmlFor="price" className="form-label fw-bold">
          Price :
        </label>
        <input
          type="number"
          className="form-control"
          id="price"
          onChange={handleProductChange}
          placeholder="1749"
        />
      </div>

      <div className="mb-3">
        <label htmlFor="category" className="form-label fw-bold">
          Category :
        </label>
        <input
          type="text"
          className="form-control"
          id="category"
          onChange={handleProductChange}
          placeholder="Laptops"
        />
      </div>

      <div className="mb-3">
        <label htmlFor="brand" className="form-label fw-bold">
          Brand :
        </label>
        <input
          type="text"
          className="form-control"
          id="brand"
          onChange={handleProductChange}
          placeholder="Apple"
        />
      </div>

      <div className="mb-3">
        <label htmlFor="rating" className="form-label fw-bold">
          Rating :
        </label>
        <input
          type="number"
          className="form-control"
          id="rating"
          onChange={handleProductChange}
          placeholder="4.57"
        />
      </div>

      <div className="mb-3">
        <label htmlFor="stock" className="form-label fw-bold">
          Stock :
        </label>
        <input type="number" className="form-control" id="stock" onChange={handleProductChange} placeholder="83" />
      </div>

      <div className="mb-3">
        <label htmlFor="image" className="form-label fw-bold">
          Image :
        </label>
        <input
          type="url"
          className="form-control"
          id="image"
          onChange={handleProductChange}
          placeholder="https://i.dummyjson.com/data/products/6/1.png"
        />
      </div>
      <div className="col-12">
        <button type="submit" className="btn btn-primary" onClick={handleAddProduct}>
          Add Product
        </button>
      </div>
    </div>
  );
}

