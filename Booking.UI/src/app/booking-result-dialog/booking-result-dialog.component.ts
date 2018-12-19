import { Component, Inject } from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA, MatDialogRef, MatTableDataSource } from '@angular/material';
@Component({
  selector: 'app-booking-result-dialog',
  templateUrl: './booking-result-dialog.component.html',
  styleUrls: ['./booking-result-dialog.component.css']
})
export class BookingResultDialogComponent  {
 response: any;
 displayedColumns = ['flightName', 'availableSeats'];
  dataSource = new MatTableDataSource<any>();
  constructor(@Inject(MAT_DIALOG_DATA) public data,  public dialogRef: MatDialogRef<BookingResultDialogComponent>) {
      this.dataSource =  data;
      console.log(data);
   }

   close() {
    this.dialogRef.close();
   }
}
