import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { NewsletterService } from 'src/app/services/newsletter.service';

@Component({
  selector: 'app-dialog-add-subscriber',
  templateUrl: './dialog-add-subscriber.component.html',
  styleUrls: ['./dialog-add-subscriber.component.scss']
})
export class DialogAddSubscriberComponent implements OnInit {

  public newsletterForm : FormGroup = new FormGroup({
    email: new FormControl('')
  });

  constructor(
    @Inject(MAT_DIALOG_DATA) public data : any,
    public dialogRef: MatDialogRef<DialogAddSubscriberComponent>,
    private newsletterService: NewsletterService
  ) {
  }

  get email() : AbstractControl | null {
    return this.newsletterForm.get('email');
  }

  ngOnInit(): void {
  }

  public closeDialog() : void {
    this.dialogRef.close();
  }

  public saveSubscriber() : void {
    console.log(this.newsletterForm.value);
    this.newsletterService.createSubscriber(this.newsletterForm.value).subscribe( () => {
      this.dialogRef.close(this.newsletterForm.value);
    });
  }
}
