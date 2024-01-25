-- Crear la base de datos
CREATE DATABASE EbenezerSolution;
GO

USE EbenezerSolution;
GO

-- Crear la tabla Role
CREATE TABLE [dbo].[Role] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [IsActive] BIT NOT NULL,
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Module
CREATE TABLE [dbo].[Module] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [IsActive] BIT NOT NULL,
    [RoleId] INT FOREIGN KEY REFERENCES [dbo].[Role]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla User
CREATE TABLE [dbo].[User] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(MAX) NOT NULL,
    [Password] NVARCHAR(MAX) NOT NULL,
    [IsActive] BIT NOT NULL,
    [RoleId] INT FOREIGN KEY REFERENCES [dbo].[Role]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Person
CREATE TABLE [dbo].[Person] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [FullName] NVARCHAR(MAX) NOT NULL,
    [Gender] NVARCHAR(MAX) NOT NULL,
    [NumberPhone] NVARCHAR(MAX) NOT NULL,
    [Address] NVARCHAR(MAX) NOT NULL,
    [BirthDate] DATETIME NOT NULL,
    [UserId] INT FOREIGN KEY REFERENCES [dbo].[User]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Ministry
CREATE TABLE [dbo].[Ministry] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [IsActive] BIT NOT NULL,
    [CretionDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla MinistryMember
CREATE TABLE [dbo].[MinistryMember] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [MinistryId] INT FOREIGN KEY REFERENCES [dbo].[Ministry]([Id]),
    [PersonId] INT FOREIGN KEY REFERENCES [dbo].[Person]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Event
CREATE TABLE [dbo].[Event] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [Day] NVARCHAR(MAX) NOT NULL,
    [DateTime] DATETIME NOT NULL,
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Attendance
CREATE TABLE [dbo].[Attendance] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [EventId] INT FOREIGN KEY REFERENCES [dbo].[Event]([Id]),
    [AssistantId] INT FOREIGN KEY REFERENCES [dbo].[Person]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla Activity
CREATE TABLE [dbo].[Activity] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(MAX) NOT NULL,
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- Crear la tabla ActivityParticipant
CREATE TABLE [dbo].[ActivityParticipant] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [ActivityId] INT FOREIGN KEY REFERENCES [dbo].[Activity]([Id]),
    [ParticipantId] INT FOREIGN KEY REFERENCES [dbo].[Person]([Id]),
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL
);
GO

