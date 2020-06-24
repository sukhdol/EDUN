import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class CategoriesService {

  constructor(private http: HttpClient) {

  }

  getCategoryItemsList() {
    return this.http.get('/api/categories').pipe(map((data: any) => data));
  }
}
