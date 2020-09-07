import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatDividerModule} from '@angular/material/divider'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {GridListOverviewExample} from './grid/grid-list-overview-example'
import {MatGridListModule} from '@angular/material/grid-list'
@NgModule({
  declarations: [
    AppComponent,
    GridListOverviewExample
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatGridListModule,
    MatDividerModule
  ],
  providers: [],
  bootstrap: [AppComponent, GridListOverviewExample]
})
export class AppModule { }
