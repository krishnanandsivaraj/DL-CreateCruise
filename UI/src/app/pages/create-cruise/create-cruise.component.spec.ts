import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCruiseComponent } from './create-cruise.component';

describe('CreateCruiseComponent', () => {
  let component: CreateCruiseComponent;
  let fixture: ComponentFixture<CreateCruiseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateCruiseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateCruiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
