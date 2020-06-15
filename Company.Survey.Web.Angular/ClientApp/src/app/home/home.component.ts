import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { ActivatedRoute } from '@angular/router';
import { SurveyViewModel } from '../Interfaces/surveyViewModel';

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

  onBlurReplace(i) {
    this.survey.steps[i].questions.find(e => e.id === event.target.id).clientReply = event.target.value;
  }
}
