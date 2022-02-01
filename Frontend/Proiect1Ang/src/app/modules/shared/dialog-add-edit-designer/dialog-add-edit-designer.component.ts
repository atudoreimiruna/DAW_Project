import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DesignersService } from 'src/app/services/designers.service';
import { ReactiveFormsModule } from '@angular/forms';


@Component({
  selector: 'app-dialog-add-edit-designer',
  templateUrl: './dialog-add-edit-designer.component.html',
  styleUrls: ['./dialog-add-edit-designer.component.scss']
})
export class DialogAddEditDesignerComponent implements OnInit {

  public title: string;
  public designerForm : FormGroup = new FormGroup({
    name: new FormControl(''),
    age: new FormControl(0),
    gender: new FormControl(''),
    id: new FormControl(0)
  });

  constructor(
    @Inject(MAT_DIALOG_DATA) public data : any,
    public dialogRef: MatDialogRef<DialogAddEditDesignerComponent>,
    private designersService: DesignersService
  ) {
    console.log(this.data);
    if ( this.data.designer ) {
      this.designerForm.patchValue(this.data.designer);
      this.title = 'Edit Designer';
    }
    else {
      this.title = 'Add Designer';
    }
  }

  get name() : AbstractControl | null {
    return this.designerForm.get('name');
  }
  
  get age() : AbstractControl | null {
    return this.designerForm.get('age');
  }

  get gender() : AbstractControl | null {
    return this.designerForm.get('gender');
  }

  get id() : AbstractControl | null {
    return this.designerForm.get('id');
  }

  ngOnInit(): void {
  }


  public closeDialog() : void {
    this.dialogRef.close();
  }

  public saveData() : void {
    console.log(this.designerForm.value);
    this.designersService.createDesigner(this.designerForm.value).subscribe( () => {
      this.dialogRef.close(this.designerForm.value);
    });
  }
 
}


