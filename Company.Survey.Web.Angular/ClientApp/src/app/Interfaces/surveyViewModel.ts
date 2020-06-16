import { ClientViewModel } from "./clientViewModel";

export interface SurveyViewModel {
  isComplete: boolean;
  title: string;
  client: ClientViewModel;
  companyName: string;
  companySite: string;
  contact: string;
  dateOfQuestionnaire: string;
  requestedStartDate: string;
  requestedEndDate: string;
  steps: Step[];
}

export interface Step {
  id: number;
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
  groupedReplies: GroupedReplies[];
  groupedQuestions: Question[];
}

export interface GroupedReplies {
  id: number;
  reply: string;
}

export interface Group {
  title: string;
  note: string;
  order: number;
}
