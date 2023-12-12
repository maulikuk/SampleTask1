import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-adduser',
  templateUrl: './adduser.component.html',
  styleUrls: ['./adduser.component.css']
})
export class AdduserComponent {
  error: string='';
  userForm: FormGroup;

  constructor(private apiService: ApiService, private formBuilder: FormBuilder, private router: Router) { 
    this.userForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      address: [''],
      postCode: ['', Validators.required],
      country: ['', Validators.required]
    });
  }

  onSubmit(): void {
    console.log('on submit click' + this.userForm.valid);
    debugger;
    if (this.userForm.valid) {
      console.log('Form submitted:', this.userForm.value);
      const formData = this.userForm.value;

      // Call the API service to make the POST request
      this.apiService.postUser(formData).subscribe(
        (response) => {
          console.log('API Response:', response);
          this.router.navigate(['']);
        },
        (error) => {
          console.error('API Error:', error);
          this.error =error; 
        }
      );
    } else {
      // Mark form controls as touched to display validation errors
      this.markFormGroupTouched(this.userForm);
      alert('Validation fail.');
    }
  }

  private markFormGroupTouched(formGroup: FormGroup) {
    Object.values(formGroup.controls).forEach((control) => {
      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      } else {
        control.markAsTouched();
      }
    });
  }
  
  onCancel(): void {
    console.log('on cancel click');
    this.router.navigate(['']);
  }
}

