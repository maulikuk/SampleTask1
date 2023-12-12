import { Component } from '@angular/core';
import { ApiService, User } from '../service/api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent {
  public users: User[] = [];
  public error: string | null = null;

  constructor(private apiService: ApiService, private router: Router) { }

  ngOnInit() {
    this.apiService.getUsers().subscribe(
      (records) => {
        this.users = records;
      },
      (error) => {
        this.error = 'Error fetching records.';
        console.error(error);
      }
    );
  }

  addUser() {
    this.router.navigate(['/adduser']);
  }
}
