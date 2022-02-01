import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.scss']
})
export class ChildComponent implements OnInit {

  @Input() message : string | undefined;
  @Output() messageEvent = new EventEmitter<string>();

  constructor() { 
    console.log('from constructor', this.message);
  }

  ngOnInit(): void {
    console.log('from init', this.message);
  }

  public emitData():void {
    this.messageEvent.emit('message from child');
  }
}
