import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedRoutingModule } from './shared-routing.module';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';

import {
  MatToolbarModule,
  MatSidenavModule,
  MatIconModule,
  MatMenuModule,
  MatBadgeModule,
  MatCardModule,
  MatTableModule
} from '@angular/material';

@NgModule({
  declarations: [HeaderComponent, FooterComponent],
  imports: [
    CommonModule,
    SharedRoutingModule,
    MatToolbarModule, MatSidenavModule, MatIconModule, MatMenuModule, MatBadgeModule, MatCardModule, MatTableModule
  ],
  exports: [HeaderComponent, FooterComponent]
})
export class SharedModule { }
