import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BugBoxComponent } from './bug-box.component';

describe('BugBoxComponent', () => {
  let component: BugBoxComponent;
  let fixture: ComponentFixture<BugBoxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BugBoxComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BugBoxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
