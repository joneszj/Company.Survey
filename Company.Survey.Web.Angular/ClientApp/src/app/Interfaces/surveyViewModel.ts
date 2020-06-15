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
  stepContent: Content;
  questions: Question[];
}

export interface Content {
  title: string;
  contentBlocks: string[];
}

export interface Question {
  id: number;
  quesitonText: string;
  note: string;
  order: number;
  exampleReplies: string[];
  groupId: number | null;
  clientReply: string;
  groupedQuestions: Question[];
}

export interface Group {
  title: string;
  note: string;
  order: number;
}
