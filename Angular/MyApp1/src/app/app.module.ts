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
import { YouTubePlayerModule } from '@angular/youtube-player'
import { MatVideoModule } from 'mat-video';
@NgModule({
  declarations: [
    AppComponent,
    GridListOverviewExample,
    ButtonOverviewExample
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatGridListModule,
    MatDividerModule,
    MatSliderModule,
    MatIconModule,
    MatDividerModule,
    MatVideoModule,
    YouTubePlayerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
