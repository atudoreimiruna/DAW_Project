import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appBtnHover]'
})
export class BtnHoverDirective {

  constructor (
     private el: ElementRef
  ) {
  }

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight('purple');
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.highlight('');
  }

  private highlight(color: string) {
    this.el.nativeElement.style.backgroundColor = color;
  }
}

