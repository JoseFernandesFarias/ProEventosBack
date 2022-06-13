import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Eventos2Component } from './eventos2.component';

describe('Eventos2Component', () => {
  let component: Eventos2Component;
  let fixture: ComponentFixture<Eventos2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Eventos2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Eventos2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
