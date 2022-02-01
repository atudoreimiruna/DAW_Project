import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appMouse]'
})
export class MouseDirective {

  constructor(private elRef: ElementRef) { 
  }

  @HostListener('mouseover') onMouseOver() {
    this.changeBackgroundColor('blue');
  }
  
  @HostListener('mouseleave') onMouseLeave() {
    this.changeBackgroundColor('grey');
  }
  
  private changeBackgroundColor(color: string) {
    this.elRef.nativeElement.style.backgroundColor = color;
  }  

}