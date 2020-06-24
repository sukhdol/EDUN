import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable()
export class ItemsService {

  constructor(private http: HttpClient) {

  }

  delete(id) {
    return this.http.delete('/api/items/' + id).pipe(map((data: any) => data));
  }
}
