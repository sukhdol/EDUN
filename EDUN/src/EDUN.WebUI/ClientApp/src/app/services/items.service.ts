import { ItemCreate } from './../models/item-create';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class ItemsService {
  itemsRoute = '/api/items';

  constructor(private http: HttpClient) {

  }

  create(itemCreate: ItemCreate) {
    return this.http.post(this.itemsRoute, itemCreate).pipe(map((data: any) => data));
  }

  delete(id) {
    return this.http.delete(this.itemsRoute + '/' + id).pipe(map((data: any) => data));
  }
}
