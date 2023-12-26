import axios from "axios";

export default class ProductService {
    getProducts(){
        //api'deki restfull service'e request atmak;
        return axios.get("https://localhost:44354/api/Products/getall");
    }
}