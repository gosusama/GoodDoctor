import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './_layout/login/login.component';
import { LayoutComponent } from './_layout/layout/layout.component';

const routes: Routes = [
  { path: '', component: LayoutComponent },
  { path: 'login', component: LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
