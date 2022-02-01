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
import { Client } from 'src/app/interfaces/client';
import { ClientsService } from 'src/app/services/clients.service';


@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.scss']
})

export class ClientsComponent implements OnInit, OnDestroy{

  public clients!: Client[];

  displayedColumns: string[] = ['id', 'name', 'phone'];
  public parentMessage = 'message from parent';
  public message: any;
  public subscription!: Subscription;
  public id!: Number; 
  public sub : any;

  constructor(
    private clientsService: ClientsService,
    private router: Router,
    private dialog: MatDialog,
    private data: DataService,
    private route : ActivatedRoute
  ) { }

  /*
  ngOnInit(): void {
    this.subscription = this.data.currentMessage.subscribe( message => this.message = message);
    this.getAllClients();
  }*/

  public ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      if (this.id) {
        this.getAllClients();
      }
  })
}

  public getAllClients(): void {
    this.clientsService.getClients(this.id).subscribe((result) => {
      this.clients = result;
    });
  }

  
  public receiveMessage(message: any): void {
    console.log(message);
  }
    

  public logout() : void {
    this.data.changeMessage('Hello from Clients');
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


