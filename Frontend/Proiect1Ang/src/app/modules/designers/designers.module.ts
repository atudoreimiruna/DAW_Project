import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DesignersRoutingModule } from './designers-routing.module';
import { DesignersComponent } from './designers/designers.component';
import { DesignerComponent } from './designer/designer.component';
import { MatTableModule} from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { ChildComponent } from './child/child.component';
import { MarksPipe } from 'src/app/marks.pipe';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { AwardsComponent } from './awards/awards.component';
import { ClientsComponent } from './clients/clients.component';
import { CollectionsComponent } from './collections/collections.component';
import { ProfilePipe } from 'src/app/profile.pipe';
import { PagePipe } from 'src/app/page.pipe';


//trebuie sa adaugi mereu un /icon sau  /numele elementului folosit; la mine a mers fara asta ca foloseam versiuni diferite de material

@NgModule({
  declarations: [
    DesignersComponent,
    DesignerComponent,
    ChildComponent,
    MarksPipe,
    AwardsComponent,
    ClientsComponent,
    CollectionsComponent,
    ProfilePipe,
    PagePipe
  ],
  imports: [
    CommonModule,
    DesignersRoutingModule,
    MatTableModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule
  ]
})

export class DesignersModule { }
