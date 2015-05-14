﻿CREATE TABLE [dbo].[Card] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [StudentId] INT           NOT NULL,
    [Number]    VARCHAR (50)  NOT NULL,
    [IssueDate] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Card_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id])
);



