import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizationGuard } from './authorization.guard';
//import { LoginComponent } from './modules/designers/login/login.component';


const routes: Routes = [
  {
    //path: '',
    //canActivate: [AuthorizationGuard],
    //children: [
    //  {
        path: '',
        //loadChildren: () => import('src/app/modules/designers/designers.module').then(m => m.DesignersModule)
        loadChildren: () => import('src/app/modules/auth/auth.module').then(m => m.AuthModule)
        
      //}
    //]
  },
 /* {
    path: '',
    pathMatch: 'full',
    redirectTo: 'login'
  },
  {
    path: 'login',
    pathMatch: 'full',
    component: LoginComponent
  },*/
  {
    path: 'designers',
    loadChildren: () => import('src/app/modules/designers/designers.module').then(m => m.DesignersModule)
  }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
