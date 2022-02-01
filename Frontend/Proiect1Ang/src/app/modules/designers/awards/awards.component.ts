import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Award } from 'src/app/interfaces/award';
import { Subscription } from 'rxjs';
import { AwardsService } from 'src/app/services/awards.service';
import { DataService } from 'src/app/services/data.service';
import { MatDialog } from '@angular/material/dialog';


@Component({
  selector: 'app-awards',
  templateUrl: './awards.component.html',
  styleUrls: ['./awards.component.scss']
})
export class AwardsComponent implements OnInit , OnDestroy{

  public awards!: Award[];
  displayedColumns: string[] = ['id', 'name', 'contest', 'data'];
  public parentMessage = 'message from parent';
  public message: any;
  public subscription!: Subscription;
  public id!: Number; 
  public sub : any;
  

  constructor(
    private clientsService: AwardsService,
    private router: Router,
    private dialog: MatDialog,
    private data: DataService,
    private route : ActivatedRoute,
    private awardsService : AwardsService
  ) { }


  public ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      if (this.id) {
        this.getAllAwards();
      }
  })
}

  public getAllAwards(): void {
    this.awardsService.getAwards(this.id).subscribe((result ) => {
      this.awards = result;
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
    this.sub.unsubscribe();
  }

}

function setItem(arg0: string, arg1: string) {
  throw new Error('Function not implemented.');
}

