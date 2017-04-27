import { Component } from '@angular/core'
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class LoginComponent {
    LoginCredentials: Credentials;
    RegisterCredentials: Credentials;

    constructor() {
        this.LoginCredentials = new Credentials();
        this.RegisterCredentials = new Credentials();
    }

    Login(credentials: Credentials): void {
        console.log(credentials.Email);
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