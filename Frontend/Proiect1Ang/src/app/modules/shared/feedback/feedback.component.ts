import { Component, Inject, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FeedbackService } from 'src/app/services/feedback.service';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.scss']
})
export class FeedbackComponent implements OnInit {

  public feedbackForm : FormGroup = new FormGroup({
    name: new FormControl(''),
    message: new FormControl('')
  });

  constructor(
    @Inject(MAT_DIALOG_DATA) public data : any,
    public dialogRef: MatDialogRef<FeedbackComponent>,
    private feedbackService: FeedbackService
  ) { }

  get name() : AbstractControl | null {
    return this.feedbackForm.get('name');
  }

  get message() : AbstractControl | null {
    return this.feedbackForm.get('message');
  }

  ngOnInit(): void {
  }

  public closeDialog() : void {
    this.dialogRef.close();
  }

  public saveFeedback() : void {
    console.log(this.feedbackForm.value);
    this.feedbackService.createFeedback(this.feedbackForm.value).subscribe( () => {
      this.dialogRef.close(this.feedbackForm.value);
    });
  }
}
