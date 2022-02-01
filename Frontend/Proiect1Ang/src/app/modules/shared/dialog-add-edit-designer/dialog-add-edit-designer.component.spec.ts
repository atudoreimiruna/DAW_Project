import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogAddEditDesignerComponent } from './dialog-add-edit-designer.component';

describe('DialogAddEditDesignerComponent', () => {
  let component: DialogAddEditDesignerComponent;
  let fixture: ComponentFixture<DialogAddEditDesignerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogAddEditDesignerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogAddEditDesignerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
