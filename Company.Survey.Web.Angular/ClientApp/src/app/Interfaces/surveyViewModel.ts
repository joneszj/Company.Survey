export interface SurveyViewModel {
  isComplete: boolean;
  title: string;
  companyName: string;
  companySite: string;
  contact: string;
  dateOfQuestionnaire: string;
  requestedStartDate: string;
  requestedEndDate: string;
  steps: Step[];
}

export interface Step {
  title: string;
  order: number;
  renderItems: RenderItem[];
}

export interface RenderItem {
  title: string;
  order: number;
  note: string;
  question: Question;
  questionsAsTable: Question[];
  renderAs: string;
  groupKey: string;
}

export interface Question {
  id: number;
  title: string;
  note: string;
  order: number;
  exampleReplies: string[];
  clientReply: string;
  renderAs: string;
  groupKey: string;
}
