import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MaterialModule} from './material.module';
import { AppComponent } from './app.component';
import { BookingService } from './Services/booking.service';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BookingResultDialogComponent } from './booking-result-dialog/booking-result-dialog.component';
import { SearchBookingComponent } from './search-booking/search-booking.component';

@NgModule({
   declarations: [
      AppComponent,
      BookingResultDialogComponent,
      SearchBookingComponent
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      MaterialModule,
      HttpClientModule,
      ReactiveFormsModule
   ],
   providers: [
      BookingService
   ],
   bootstrap: [
      AppComponent
   ],
   entryComponents: [BookingResultDialogComponent]
})
export class AppModule { }
