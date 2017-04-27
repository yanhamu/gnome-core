import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './../../services/authentication.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    providers: [ AuthenticationService ]
})
export class HomeComponent {

    IsAuthenticated: boolean = false;

    constructor(private auth: AuthenticationService) { }

    OnInit() {
        this.IsAuthenticated = this.auth.IsAuthenticated()
    }
}
