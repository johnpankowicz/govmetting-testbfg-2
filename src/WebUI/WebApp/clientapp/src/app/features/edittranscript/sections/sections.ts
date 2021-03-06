import { Component, OnInit } from '@angular/core';
import { EditTranscriptService } from '../edittranscript.service';

const NoLog = true; // set to false for console logging

@Component({
  selector: 'gm-sections',
  templateUrl: './sections.html',
  styleUrls: ['./sections.css'],
})
export class SectionsComponent implements OnInit {
  private ClassName: string = this.constructor.name + ': ';
  errorMessage: string = '';
  sections: string[] = [];
  gotSections = false;

  constructor(private _edittranscriptService: EditTranscriptService) {}

  ngOnInit() {
    this.getSections();
  }

  getSections() {
    if (!this.gotSections) {
      this.gotSections = true;
      NoLog || console.log(this.ClassName + 'getSections');
      this._edittranscriptService.getTalks().subscribe(
        (addtags: any) => {
          this.sections = addtags.sections;
          NoLog || console.log(this.ClassName, this.sections);
        },
        (error: any) => (this.errorMessage = error as any)
      );
    }
  }

  OnChange(newValue: any) {
    NoLog || console.log(this.ClassName, newValue);
  }

  isEmptyObject(obj: any) {
    let prop;
    for (prop in obj) {
      if (obj.hasOwnProperty(prop)) {
        return false;
      }
    }
    return true;
  }
}
