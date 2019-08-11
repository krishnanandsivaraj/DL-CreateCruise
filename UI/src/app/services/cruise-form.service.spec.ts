import { TestBed } from '@angular/core/testing';

import { CruiseFormService } from './cruise-form.service';

describe('CruiseFormService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CruiseFormService = TestBed.get(CruiseFormService);
    expect(service).toBeTruthy();
  });
});
