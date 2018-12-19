import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';
import { Global } from '../Shared/Global';
import { ISearchInputRequest } from '../Interfaces/SearchInputRequest';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};
@Injectable({
  providedIn: 'root'
})
export class BookingService {
  body: any;
  constructor(private http: HttpClient) {
                }

  private extractData(res: Response) {
    this.body = res;
    return this.body || { };
  }

  searchForFlight (searchInputRequest: ISearchInputRequest): Observable<ISearchInputRequest> {
    httpOptions.headers =
      httpOptions.headers.set('Content-Type', 'application/json');
    const url = Global.BOOKING_ROOT_URL + Global.BOOKING_GETAVAILABLEFLIGHT_API;
    return this.http.post<ISearchInputRequest>(url, searchInputRequest)
     .pipe(
       catchError(this.handleError('searchInputRequest', searchInputRequest))
     );
   }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error.message);
      console.log('${{operation}} failed: ${{error.message}}');
      return of(result as T);
    };
  }
}
