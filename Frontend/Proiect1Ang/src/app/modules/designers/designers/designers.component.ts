import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Designer } from 'src/app/interfaces/designer';
import { DesignersService } from 'src/app/services/designers.service';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog } from '@angular/material/dialog';
import { MatDialogConfig } from '@angular/material/dialog';
import { DialogAddEditDesignerComponent } from '../../shared/dialog-add-edit-designer/dialog-add-edit-designer.component';
import "@angular/compiler"
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { ReactiveFormsModule } from '@angular/forms';
import { DialogAddSubscriberComponent } from '../../shared/dialog-add-subscriber/dialog-add-subscriber.component';
import { FeedbackComponent } from '../../shared/feedback/feedback.component';


@Component({
  selector: 'app-designers',
  templateUrl: './designers.component.html',
  styleUrls: ['./designers.component.scss']
})
export class DesignersComponent implements OnInit, OnDestroy{

  public designers!: Designer[];

  displayedColumns: string[] = ['id', 'name', 'age', 'gender', 'profile', 'edit', 'delete'];
  public parentMessage = 'message from parent';
  public message: any;
  public subscription!: Subscription;

  constructor(
    private designersService: DesignersService,
    private router: Router,
    private dialog: MatDialog,
    private data: DataService
  ) { }

  ngOnInit(): void {
    this.subscription = this.data.currentMessage.subscribe( message => this.message = message);
    this.getAllDesigners();
  }

  public getAllDesigners(): void {
    this.designersService.getDesigners().subscribe((result) => {
      this.designers = result;
    });
  }

  public addData(designer?: any) : void {
    const data = {
      designer 
    };
    // this.designersService.createDesigner(designer).subscribe( () => {
    //   this.getAllDesigners();
    // });
    
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = '550px';
    dialogConfig.height = '600px';
    dialogConfig.data = data;
    const dialogRef = this.dialog.open(DialogAddEditDesignerComponent, dialogConfig);
    dialogRef.afterClosed().subscribe( (result) => {
      if ( result ) {
        this.getAllDesigners();
      }
    });
    }


    public addSubscriber(subscriber?: any) : void {
      const data = {
        subscriber 
      };
      
      const dialogConfig = new MatDialogConfig();
      dialogConfig.width = '550px';
      dialogConfig.height = '600px';
      dialogConfig.data = data;
      const dialogRef = this.dialog.open(DialogAddSubscriberComponent, dialogConfig);
      dialogRef.afterClosed().subscribe( (result) => {
        if ( result ) {
          this.getAllDesigners();
        }
      });
    }
    

    public addFeedback(feedback?: any) : void {
      const data = {
        feedback 
      };
      
      const dialogConfig = new MatDialogConfig();
      dialogConfig.width = '550px';
      dialogConfig.height = '600px';
      dialogConfig.data = data;
      const dialogRef = this.dialog.open(FeedbackComponent, dialogConfig);
      dialogRef.afterClosed().subscribe( (result) => {
        if ( result ) {
          this.getAllDesigners();
        }
      });
    }
  
  public goToDesignerProfile(id: any) : void {
    this.router.navigate(['/designer', id]);

  }

  public editDesigner(designer: any) : void {
    this.addData(designer);
    //console.log("apelare functie edit")
  }

  
  public deleteDesigner(designer: any) : void {
    this.designersService.deleteDesigner(designer).subscribe( (result) => {
      this.designers = result;
    }); 
  }
  

  public receiveMessage(message: any): void {
    console.log(message);
  }
    

  public logout() : void {
    this.data.changeMessage('Hello from Designers');
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}

function setItem(arg0: string, arg1: string) {
  throw new Error('Function not implemented.');
}
