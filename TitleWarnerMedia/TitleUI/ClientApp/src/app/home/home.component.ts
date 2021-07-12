import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from 'src/environments/environment';
// KENDO UI
//import { DropDownsModule } from '@progress/kendo-angular-dropdowns';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

    public apiRoot: string;
    public listItems: any;

    constructor(public http: HttpClient) {
        this.apiRoot = environment.apiURL + '/api/';

        //const httpOptions = {
        //    headers: new HttpHeaders({
        //        'Content-Type': 'application/json',
        //        'Access-Control-Allow-Origin': '*',
        //        'Access-Control-Allow-Method': 'OPTIONS, GET, POST',
        //        'Access-Control-Allow-Credentials': 'true',
        //    })
        //}

        const httpOptions = {
            headers: new HttpHeaders().set('Access-Control-Allow-Origin', 'http://localhost:44302/')
        }

        //console.log(`*** URL: `, this.url);

        this.http.get(this.apiRoot + 'othername/70523', httpOptions).subscribe(result => {
            console.log(result);
        });
    }

    

}
