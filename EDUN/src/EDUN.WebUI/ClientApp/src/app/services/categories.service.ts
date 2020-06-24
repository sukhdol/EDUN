import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class CategoriesService {
  categoryRoute = '/api/categories';

  constructor(private http: HttpClient) {

  }

  getCategoryItemsList() {
    return this.http.get(this.categoryRoute).pipe(map((data: any) => data));
  }

  getCategoriesKeyValuePair() {
    return this.http.get(this.categoryRoute + '/keyValuePair').pipe(map((data: any) => data));
  }
}
