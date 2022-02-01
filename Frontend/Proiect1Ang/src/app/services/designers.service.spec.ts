import { TestBed } from '@angular/core/testing';

import { DesignersService } from './designers.service';

describe('DesignersService', () => {
  let service: DesignersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DesignersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
