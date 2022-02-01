import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Designer } from 'src/app/interfaces/designer';
import { DataService } from 'src/app/services/data.service';
import { DesignersService } from 'src/app/services/designers.service';

@Component({
  selector: 'app-designer',
  templateUrl: './designer.component.html',
  styleUrls: ['./designer.component.scss']
})

export class DesignerComponent implements OnInit, OnDestroy {

  public id: Number | undefined;
  public sub : any;
  public designer!: Designer;

  constructor(
    private route : ActivatedRoute,
    private designerService : DesignersService,
    private router: Router,
    private data: DataService
     ) { }

  public ngOnInit(): void {
      this.sub = this.route.params.subscribe(params => {
        this.id = +params['id'];
        if (this.id) {
          this.getDesigner();
        }
    })
  }

  public getDesigner() : void {
      this.designerService.getDesignerById(this.id).subscribe( (result) => {
        this.designer = result;
        console.log(this.designer);
      })
    }
  

  public ngOnDestroy(): void {
      this.sub.unsubscribe();
    };


  public getAllAwards(id : any) : void {
    this.router.navigate(['/awards', id]);
  }

  public getAllClients(id: any) : void {
    this.router.navigate(['/clients', id]);
  }

  public getAllCollections(id: any) : void {
    this.router.navigate(['/collections', id]);
  }
}
