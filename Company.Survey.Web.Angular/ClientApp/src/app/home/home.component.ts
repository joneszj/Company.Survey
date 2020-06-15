import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { ActivatedRoute } from '@angular/router';
import { SurveyViewModel } from '../Interfaces/surveyViewModel';
import { PutReplyViewModel } from '../Interfaces/putReplyViewModel';
import { PutSurveyViewModel } from '../Interfaces/putSurveyViewModel';
import { ClientViewModel } from '../Interfaces/clientViewModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  hasLoaded = false;
  notFound = false;
  survey: SurveyViewModel;

  constructor(
    private _http: HttpClient,
    private _route: ActivatedRoute
  ) { }

  ngOnInit() {
    const email = this._route.snapshot.paramMap.get("email");
    const key = this._route.snapshot.paramMap.get("key");
    if (!email || !key) {
      this.hasLoaded = true;
      this.notFound = true;
    }
    this._http.get<SurveyViewModel>(`${environment.ApiBaseUrl}/surveys/${email}/?key=${key}`).subscribe(survey => {
      this.survey = survey;
      this.hasLoaded = true;
    });
  }

  updateClient = () => {
    const client = {
      companyName: (document.getElementById("companyName") as HTMLInputElement).value,
      email: (document.getElementById("email") as HTMLInputElement).value,
      firstName: (document.getElementById("firstName") as HTMLInputElement).value,
      lastName: (document.getElementById("lastName") as HTMLInputElement).value,
      phone: (document.getElementById("phone") as HTMLInputElement).value,
    } as ClientViewModel;
    if (JSON.stringify(this.survey.client) !== JSON.stringify(client)) {
      this._http.put(`${environment.ApiBaseUrl}/client/?key=${this._route.snapshot.paramMap.get("key")}`, client).subscribe(() => this.survey.client = client);
    }
  }

  updateSurvey = () => {
    const surveyUpdate = {
      requestedStartDate: (document.getElementById("requestedStartDate") as HTMLInputElement).value,
      requestedEndDate: (document.getElementById("requestedEndDate") as HTMLInputElement).value
    } as PutSurveyViewModel;
    const survey = {
      requestedStartDate: this.survey.requestedStartDate,
      requestedEndDate: this.survey.requestedStartDate
    } as PutSurveyViewModel;

    if (JSON.stringify(survey) !== JSON.stringify(surveyUpdate)) {
      this._http.put(`${environment.ApiBaseUrl}/surveys/?key=${this._route.snapshot.paramMap.get("key")}`, surveyUpdate).subscribe(() => {
        this.survey.requestedStartDate = surveyUpdate.requestedStartDate;
        this.survey.requestedEndDate = surveyUpdate.requestedEndDate;
      });
    }
  }

  // TODO: really wanted this to be a debounce instead of blur, but couldn't get trailing debounce only to exectue
  updateQuestionReply = (event) => {
    if (event.target.dataset.isnew === 'true') {
      if ((event.target as HTMLInputElement).value) {
        // create group reply item
        this._http.post(`${environment.ApiBaseUrl}/reply/?key=${this._route.snapshot.paramMap.get("key")}`, {
          surveyQuestionId: Number(event.target.id),
          value: event.target.value,
          groupdIndex: Number(event.target.dataset.replyindex)
        } as PutReplyViewModel).subscribe(res => {
          debugger;
          event.target.id = res;
          event.target.dataset.isnew = false;
        })
      }
    } else {
      // TODO: add depuping gaurd
      // TODO: this is functionaing as an upsert on the backend and should be separated
      this._http.put(`${environment.ApiBaseUrl}/reply/?key=${this._route.snapshot.paramMap.get("key")}`, {
        surveyQuestionId: Number(event.target.id),
        value: event.target.value
      } as PutReplyViewModel).subscribe(res => console.log(res))
      // TODO: maybe add delete reply if value is empty
    }
  };

  addNewRow = () => {
    const sourceRow = (event.target as HTMLElement).parentElement.parentElement.parentElement;
    const lastRow = sourceRow.parentElement.getElementsByTagName('tbody')[0].children[sourceRow.parentElement.getElementsByTagName('tbody')[0].children.length - 1];
    const targetRow = lastRow.cloneNode(true);
    Array.from(lastRow.querySelectorAll('input')).forEach((e: HTMLInputElement) => {
      e.id = "",
      e.dataset.isnew = "true",
      e.value = "";
      e.dataset.replyindex = lastRow.querySelectorAll('input')[0].dataset.replyindex + 1;
    });
    sourceRow.parentElement.getElementsByTagName('tbody')[0].insertBefore(targetRow, lastRow);
  }
}
