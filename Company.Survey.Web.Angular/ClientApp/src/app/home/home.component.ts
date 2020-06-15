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
    db: void;

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
      this.addEventListeners();
      this.hasLoaded = true;
    });
  }

  addEventListeners = () => {
    Array.from(document.getElementsByClassName("clientInput")).forEach(e => e.addEventListener("blur", this.updateClient))
    Array.from(document.getElementsByClassName("surveyInput")).forEach(e => e.addEventListener("blur", this.updateSurvey))
  }

  updateClient = () => {
    const client = {
      companyName: document.getElementById("companyName").nodeValue,
      email: document.getElementById("email").nodeValue,
      firstName: document.getElementById("firstName").nodeValue,
      lastName: document.getElementById("lastName").nodeValue,
      phone: document.getElementById("phone").nodeValue,
    } as ClientViewModel;

    if (JSON.stringify(this.survey.client) !== JSON.stringify(client)) {
      this._http.put(`${environment.ApiBaseUrl}/client/?key=${this._route.snapshot.paramMap.get("key")}`, client).subscribe(() => this.survey.client = client);
    }
  }

  updateSurvey = () => {
    const surveyUpdate = {
      requestedStartDate: document.getElementById("requestedEndDate").nodeValue,
      requestedEndDate: document.getElementById("requestedEndDate").nodeValue
    } as PutSurveyViewModel;
    const survey = {
      requestedStartDate: this.survey.requestedStartDate,
      requestedEndDate: this.survey.requestedStartDate
    } as PutSurveyViewModel;

    if (JSON.stringify(survey) !== JSON.stringify(surveyUpdate)) {
      this._http.put(`${environment.ApiBaseUrl}/survey/?key=${this._route.snapshot.paramMap.get("key")}`, surveyUpdate).subscribe(() => {
        this.survey.requestedStartDate = surveyUpdate.requestedStartDate;
        this.survey.requestedEndDate = surveyUpdate.requestedEndDate;
      });
    }
  }

  // TODO: really wanted this to be a debounce instead of blur, but couldn't get trailing debounce only to exectue
  updateQuestionReply = (event) => {
    this._http.put(`${environment.ApiBaseUrl}/reply/?key=${this._route.snapshot.paramMap.get("key")}`, {
      surveyQuestionId: Number(event.target.id),
      value: event.target.value
    } as PutReplyViewModel).subscribe(res => console.log(res))
  };
}
