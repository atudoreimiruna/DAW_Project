import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Designer } from 'src/app/interfaces/designer';
import { DesignersService } from 'src/app/services/designers.service';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialog } from '@angular/material/dialog';
import { MatDialogConfig } from '@angular/material/dialog';
import { DialogAddEditDesignerComponent } from '../../shared/dialog-add-edit-designer/dialog-add-edit-designer.component';
import "@angular/compiler"
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { Collection } from 'src/app/interfaces/collection';
import { CollectionsService } from 'src/app/services/collections.service';


@Component({
  selector: 'app-collections',
  templateUrl: './collections.component.html',
  styleUrls: ['./collections.component.scss']
})

export class CollectionsComponent implements OnInit, OnDestroy{

  public collections!: Collection[];

  displayedColumns: string[] = ['id', 'name', 'numberofitems', 'releasedate'];
  public parentMessage = 'message from parent';
  public message: any;
  public subscription!: Subscription;
  public id!: Number; 
  public sub : any;

  constructor(
    private clientsService: CollectionsService,
    private collectionsService: CollectionsService,
    private router: Router,
    private dialog: MatDialog,
    private data: DataService,
    private route : ActivatedRoute
   ) { }

  

  public ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      if (this.id) {
        this.getAllCollections();
      }
  })
}

  public getAllCollections(): void {
    this.collectionsService.getCollections(this.id).subscribe((result) => {
      this.collections = result;
    });
  }
  
  public receiveMessage(message: any): void {
    console.log(message);
  }
    
  public logout() : void {
    this.data.changeMessage('Hello from Collections');
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
    this.sub.unsubscribe();
  }
}

function setItem(arg0: string, arg1: string) {
  throw new Error('Function not implemented.');
}



























/*import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Collection } from 'src/app/interfaces/collection';
import { Subscription } from 'rxjs';
import { CollectionsService } from 'src/app/services/collections.service';
import { DataService } from 'src/app/services/data.service';
import { MatDialog } from '@angular/material/dialog';
import { Designer } from 'src/app/interfaces/designer';
import { DesignersService } from 'src/app/services/designers.service';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDialogConfig } from '@angular/material/dialog';
import { DialogAddEditDesignerComponent } from '../../shared/dialog-add-edit-designer/dialog-add-edit-designer.component';
import "@angular/compiler"



@Component({
  selector: 'app-collections',
  templateUrl: './collections.component.html',
  styleUrls: ['./collections.component.scss']
})

export class CollectionsComponent implements OnInit, OnDestroy{

  public collections!: Collection[];

  displayedColumns: string[] = ['id', 'name', 'numberofitems', 'releasedate'];
  public parentMessage = 'message from parent';
  public message: any;
  public subscription!: Subscription;
  public id!: Number;
  public sub : any;

  constructor(
    private clientsService: CollectionsService,
    private router: Router,
    private dialog: MatDialog,
    private data: DataService,
    private route : ActivatedRoute,
    private collectionsService: CollectionsService
   ) { }


  public ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      if (this.id) {
        this.getAllCollections();
      }
  })
}

 
  public getAllCollections(): void {
    this.collectionsService.getCollections(this.id).subscribe((result) => {
      this.collections = result;
    });
  }


  public receiveMessage(message: any): void {
    console.log(message);
  }
    
  public logout() : void {
    this.data.changeMessage('Hello from Collections');
    localStorage.setItem('Role', 'Anonim');
    this.router.navigate(['/login']);
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
    this.sub.unsubscribe();
  }
}

function setItem(arg0: string, arg1: string) {
  throw new Error('Function not implemented.');
}

*/
