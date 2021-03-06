import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { share } from 'rxjs/operators';
import { catchError } from 'rxjs/operators';
import { EditTranscript } from '../../models/edittranscript-view';
import { ErrorHandlingService } from '../../common/error-handling/error-handling.service';
import { EditTranscriptService } from './edittranscript.service';

const NoLog = true; // set to false for console logging

@Injectable()
export class EditTranscriptServiceReal implements EditTranscriptService {
  private ClassName: string = this.constructor.name + ': ';

  private addtagsUrl = 'api/edittranscript';
  // private postId;

  // private addtags: EditTranscript;
  private observable: Observable<EditTranscript> | null = null;

  // Normally the meetingId will be passed to the getTalks method.
  // But we did not yet write the component for the user to select a meeting.
  // We will use id "2" for now. This maps to a meeting of Philadelphia on the server.
  private meetingId = 2;

  constructor(private http: HttpClient, private errHandling: ErrorHandlingService) {
    console.log('EditTranscriptService:constructor');
    NoLog || console.log(this.ClassName + 'constructor');
  }

  getTalks(): Observable<EditTranscript> {
    if (this.observable != null) {
      return this.observable;
    }
    // See notes above for "meetingId".
    let url: string = this.addtagsUrl;
    url = url + '/' + this.meetingId;
    // TODO - handle null return. Here we just cast to the correct object type.
    this.observable = this.http
      .get<EditTranscript>(url)
      .pipe(catchError(this.errHandling.handleError))
      .pipe(share()) as Observable<EditTranscript>; // make it shared so more than one subscriber can get the same result.
    return this.observable;
  }

  public postChanges(addtags: EditTranscript) {
    NoLog || console.log(this.ClassName + 'postChanges');
    const url = this.addtagsUrl + '/' + this.meetingId;

    const headers = { 'Content-Type': 'application/json' };
    this.http.post<any>(url, addtags, { headers }).subscribe({
      // next: data => this.postId = data.id,
      next: (success) => {
        NoLog || console.log(this.ClassName, success);
        if (!success) {
          // TODO handle errs here and below - tell user their save did not succeed.
          NoLog || console.log(this.ClassName, 'false was returned from Post');
        }
      },
      error: (error) => console.error('There was an error!', error),
    });
  }
}
