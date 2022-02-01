import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AwardsComponent } from './awards/awards.component';
import { ClientsComponent } from './clients/clients.component';
import { CollectionsComponent } from './collections/collections.component';
import { DesignerComponent } from './designer/designer.component';
import { DesignersComponent } from './designers/designers.component';


const routes: Routes = [
  {
    path: 'designers',
    redirectTo: 'designers',
    pathMatch: 'full'
  },
  {
    path: '',
    pathMatch: 'full',
    component: DesignersComponent
  },
  {
    path: 'designers',
    component: DesignersComponent
  },
  {
    path: 'designer/:id',
    component: DesignerComponent
  },
  {
    path: 'awards/:id',
    component: AwardsComponent
  },
  {
    path: 'clients/:id',
    component: ClientsComponent
  },
  {
    path: 'collections/:id',
    component: CollectionsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DesignersRoutingModule { }
