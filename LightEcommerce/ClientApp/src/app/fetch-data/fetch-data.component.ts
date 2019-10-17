import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ExponentialStrengthPipe } from './exponential.pipe';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class ProductComponent {
  public namePage = "Scouts Cartola";
  public products: Products[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Products[]>(baseUrl + 'api/SampleData/products').subscribe(result => {
      this.products = result;
      console.log(this.products);
    }, error => console.error(error));
  }
}

interface Products {
  Id: string;
  Price: string;
  Name: string;
  Value: number;
  Type: any;
}

