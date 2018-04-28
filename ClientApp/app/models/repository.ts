import {Product} from "./product.model";
import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs/Observable";
import "rxjs/add/operator/map";

const productUrl = "/api/products";

@Injectable()
export class Repository {
    private productData: Product;

    constructor(private readonly httpClient: HttpClient) {
        this.getProduct(1);
    }

    get product(): Product {
        console.log("Product data Requested");
        return this.productData;
    }

    getProduct(id: number) {
        this.sendRequest(productUrl + "/" + id)
            .subscribe(response => {
                this.productData = response;
            });
    }

    sendRequest(url: string): Observable<any> {
        return this.httpClient.get(url, {responseType: "json"})
    };
}