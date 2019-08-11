import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WidgetsRoutingModule } from './widgets-routing.module';
import { CruiseFormComponent } from './cruise-form/cruise-form.component';

import { MatButtonModule, MatFormFieldModule, MatSelectModule, MatTableModule } from '@angular/material';
import { MatInputModule, MatChipsModule, MatDatepickerModule, MatNativeDateModule, MatCheckboxModule } from '@angular/material';

@NgModule({
  declarations: [CruiseFormComponent],
  imports: [
    CommonModule,
    WidgetsRoutingModule,
    MatFormFieldModule,
    MatSelectModule, MatTableModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    MatChipsModule,
    MatCheckboxModule,
    MatButtonModule
  ],
  exports: [CruiseFormComponent]
})
export class WidgetsModule { }
