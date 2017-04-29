import { Component } from '@angular/core'
import { FormsModule } from '@angular/forms';
import { AuthenticationService } from './../../services/authentication.service';

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class LoginComponent {
    LoginCredentials: Credentials;
    RegisterCredentials: Credentials;

    constructor(private auth: AuthenticationService) {
        this.LoginCredentials = new Credentials();
        this.RegisterCredentials = new Credentials();
    }

    Login(credentials: Credentials): void {
        this.auth.authenticate(credentials.Email, credentials.Password);
    }

    Register(credentials: Credentials): void {
        console.log(credentials.Email);
    }
}

export class Credentials {
    public Email: string;
    public Password: string

    constructor() {
        this.Email = "";
        this.Password = "";
    }
}