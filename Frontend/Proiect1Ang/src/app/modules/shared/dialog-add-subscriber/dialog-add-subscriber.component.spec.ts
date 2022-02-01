import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogAddSubscriberComponent } from './dialog-add-subscriber.component';

describe('DialogAddSubscriberComponent', () => {
  let component: DialogAddSubscriberComponent;
  let fixture: ComponentFixture<DialogAddSubscriberComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogAddSubscriberComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DialogAddSubscriberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
