import { Injectable } from '@angular/core';

@Injectable()
export class AuthenticationService {
    private authenticationToken: string;

    constructor() {
        this.authenticationToken = null;
    }

    authenticate(username: string, password: string): string {
        this.authenticationToken = "ok-token";
        console.error(this.authenticationToken);
        return null;
    }

    isAuthenticated(): boolean {
        return this.authenticationToken != null;
    }
}