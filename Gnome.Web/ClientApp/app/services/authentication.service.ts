import { Injectable } from '@angular/core';

@Injectable()
export class AuthenticationService {
    private authenticationToken: string;

    constructor() {
        this.authenticationToken = null;
    }

    getAuthenticationToken(username: string, password: string): string {
        return null;
    }

    IsAuthenticated(): boolean {
        return this.authenticationToken == null;
    }
}