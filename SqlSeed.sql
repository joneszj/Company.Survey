SET IDENTITY_INSERT [CompanySurveyCore].[dbo].[ClientSurveys] ON;
INSERT INTO [CompanySurveyCore].[dbo].[ClientSurveys] (Id, CreatedBy, ModifiedBy, CreatedDate, ModifiedDate, IsActive, ClientSurveyKey, IsComplete, RequestedStartDate, RequestedEndDate, ClientId, SurveyId)
VALUES (-1, 'Anonymous', 'Anonymous', GETDATE(), GETDATE(), 1,  CONVERT(uniqueidentifier, '00000000-0000-0000-0000-000000000000'), 0, null, null, -1, -1); 
SET IDENTITY_INSERT [CompanySurveyCore].[dbo].[ClientSurveys] OFF;

SET IDENTITY_INSERT [CompanySurveyCore].[dbo].[Reply] ON;
INSERT INTO [CompanySurveyCore].[dbo].[Reply] (Id, CreatedBy, ModifiedBy, CreatedDate, ModifiedDate, IsActive, ClientSurveyId, SurveyQuestionId, ReplyData)
VALUES (-1, 'Anonymous', 'Anonymous', GETDATE(), GETDATE(), 1, -1, -1, 'Azure'); 
INSERT INTO [CompanySurveyCore].[dbo].[Reply] (Id, CreatedBy, ModifiedBy, CreatedDate, ModifiedDate, IsActive, ClientSurveyId, SurveyQuestionId, ReplyData)
VALUES (-2, 'Anonymous', 'Anonymous', GETDATE(), GETDATE(), 1, -1, -15, 'Server Name A'); 
INSERT INTO [CompanySurveyCore].[dbo].[Reply] (Id, CreatedBy, ModifiedBy, CreatedDate, ModifiedDate, IsActive, ClientSurveyId, SurveyQuestionId, ReplyData)
VALUES (-3, 'Anonymous', 'Anonymous', GETDATE(), GETDATE(), 1, -1, -15, 'Server Name B'); 
SET IDENTITY_INSERT [CompanySurveyCore].[dbo].[Reply] OFF;
