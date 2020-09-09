import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatDividerModule} from '@angular/material/divider'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {GridListOverviewExample} from './grid/grid-list-overview-example'
import {MatGridListModule} from '@angular/material/grid-list'
// added manually
import { MatSliderModule } from '@angular/material/slider';
import { MatIconModule } from '@angular/material/icon';
import { ButtonOverviewExample } from './buttons/button-overview-example';
import {MatSidenavModule} from '@angular/material/sidenav'; 
import {MatButtonModule} from '@angular/material/button' 


import {MatTableModule} from '@angular/material/table'; 
import {TableBasicExample} from './table/table-basic-example'
import {MatTabsModule} from '@angular/material/tabs'; 
@NgModule({
  declarations: [
    AppComponent,
    GridListOverviewExample,
    ButtonOverviewExample,
    TableBasicExample
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatGridListModule,
    MatDividerModule,
    MatSliderModule,
    MatIconModule,
    MatSidenavModule,
    MatButtonModule,
    MatTabsModule,
    MatTableModule
  ],
  providers: [],
  bootstrap: [AppComponent, GridListOverviewExample,
     ButtonOverviewExample, TableBasicExample]
})
export class AppModule { }
