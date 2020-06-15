import { Component, Input } from "@angular/core";
import { Question } from "../Interfaces/surveyViewModel";

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html'
})
export class TableComponent {
  @Input() data: Question[];

  constructor() { }

  ngOnInit() {
      // loop over replies length - i
      // for each reply, get question[i].reply in td, then new question[i+1].reply td...
    //const row = this.data.map(e => e.groupedReplies).map(e => {
    //  for
    //  return `<tr><td></td></tr>`
    //});

  }
}
