import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DialogAddEditDesignerComponent } from './dialog-add-edit-designer/dialog-add-edit-designer.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { BtnHoverDirective } from 'src/app/btn-hover.directive';
import { DialogAddSubscriberComponent } from './dialog-add-subscriber/dialog-add-subscriber.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { MouseDirective } from 'src/app/mouse.directive';

@NgModule({
  declarations: [
     DialogAddEditDesignerComponent, BtnHoverDirective, DialogAddSubscriberComponent, FeedbackComponent, MouseDirective
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule
  ],
  entryComponents: [
    DialogAddEditDesignerComponent
  ],
  exports: [
    BtnHoverDirective, 
    MouseDirective
  ]
})
export class SharedModule { }
