import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule } from './pages-routing.module';
import { CreateCruiseComponent } from './create-cruise/create-cruise.component';
import { LayoutComponent } from './layout/layout.component';

import { SharedModule } from '../shared/shared.module';
import { WidgetsModule } from '../widgets/widgets.module';

@NgModule({
  declarations: [CreateCruiseComponent, LayoutComponent],
  imports: [
    CommonModule,
    PagesRoutingModule,
    SharedModule,
    WidgetsModule
  ]
})
export class PagesModule { }
