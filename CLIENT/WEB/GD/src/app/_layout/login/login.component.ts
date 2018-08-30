import { Component, OnInit } from '@angular/core';
import { LoginServiceService } from './login-service.service';
import { UserModel } from '../../_model/UserModel';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: string;
  password: string;
  constructor(
    private loginService: LoginServiceService
  ) { }

  ngOnInit() {
  }

  Login() {
    if (!this.user || !this.password) {
      alert('Vui lòng nhập lại thông tin tài khoản');
      return;
    }
    else {
      this.loginService.login(this.user, this.password).subscribe(data => {
        console.log(data);
      });
    }
  }
}
