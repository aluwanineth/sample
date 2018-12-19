import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { BookingService } from '../Services/booking.service';
import { ISearchInputRequest } from '../Interfaces/SearchInputRequest';
import { BookingResultDialogComponent } from '../booking-result-dialog/booking-result-dialog.component';

@Component({
  selector: 'app-search-booking',
  templateUrl: './search-booking.component.html',
  styleUrls: ['./search-booking.component.css']
})
export class SearchBookingComponent implements OnInit {
  searchInputRequest: ISearchInputRequest;
  response: any;
  bookingForm = new FormGroup({
    fromDestination: new FormControl(''),
    toDestination: new FormControl(''),
    depatureDateTime: new FormControl(''),
    returnDepatureDateTime: new FormControl(''),
    numberOfPassenger: new FormControl(''),
  });

  ngOnInit() {
  }

  constructor(private _bookingService: BookingService, private dialog: MatDialog) {
  }
  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.bookingForm.value);
    this.searchForFilght(this.bookingForm.value);
  }


  searchForFilght(searchInputRequest) {
    this._bookingService.searchForFlight(searchInputRequest)
    .subscribe(data => {
      console.log(data);
      this.response = data;
      this.openbookingResultDialog();
    });
  }

  openbookingResultDialog() {
    const dialogConfig = new MatDialogConfig();
     dialogConfig.disableClose = true;
     dialogConfig.autoFocus = true;
     dialogConfig.data = {
       data: this.response
    };
     dialogConfig.width = '750px';
    // dialogConfig.height = '700px';
     const dialogRef = this.dialog.open(BookingResultDialogComponent, dialogConfig);
      // dialogRef.updatePosition({ top: '400px', right: '650px' });
  }
}
