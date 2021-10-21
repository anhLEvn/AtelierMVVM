
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/20/2021 15:53:30
-- Generated from EDMX file: C:\Users\NORA\Desktop\Nouveau dossier (3)\AtelierMVVM\AtelierMVVM\Model\EmailDBEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MVVMDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AdresseDomicilePersonnel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personnels] DROP CONSTRAINT [FK_AdresseDomicilePersonnel];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceEmailAdministratif]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompteAdmins] DROP CONSTRAINT [FK_ServiceEmailAdministratif];
GO
IF OBJECT_ID(N'[dbo].[FK_RespServiceService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personnels_RespService] DROP CONSTRAINT [FK_RespServiceService];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonnelService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personnels] DROP CONSTRAINT [FK_PersonnelService];
GO
IF OBJECT_ID(N'[dbo].[FK_DemandeCreation2Service_DemandeCreation2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemandeCreation2Service] DROP CONSTRAINT [FK_DemandeCreation2Service_DemandeCreation2];
GO
IF OBJECT_ID(N'[dbo].[FK_DemandeCreation2Service_Service]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemandeCreation2Service] DROP CONSTRAINT [FK_DemandeCreation2Service_Service];
GO
IF OBJECT_ID(N'[dbo].[FK_DemandeCreation2RespService_DemandeCreation2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemandeCreation2RespService] DROP CONSTRAINT [FK_DemandeCreation2RespService_DemandeCreation2];
GO
IF OBJECT_ID(N'[dbo].[FK_DemandeCreation2RespService_RespService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemandeCreation2RespService] DROP CONSTRAINT [FK_DemandeCreation2RespService_RespService];
GO
IF OBJECT_ID(N'[dbo].[FK_RespService_inherits_Personnel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personnels_RespService] DROP CONSTRAINT [FK_RespService_inherits_Personnel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Personnels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personnels];
GO
IF OBJECT_ID(N'[dbo].[CompteAdmins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompteAdmins];
GO
IF OBJECT_ID(N'[dbo].[AdresseDomiciles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdresseDomiciles];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO
IF OBJECT_ID(N'[dbo].[DemandeCreation2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DemandeCreation2];
GO
IF OBJECT_ID(N'[dbo].[Personnels_RespService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personnels_RespService];
GO
IF OBJECT_ID(N'[dbo].[DemandeCreation2Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DemandeCreation2Service];
GO
IF OBJECT_ID(N'[dbo].[DemandeCreation2RespService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DemandeCreation2RespService];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personnels'
CREATE TABLE [dbo].[Personnels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Matricule] nvarchar(max)  NOT NULL,
    [TypeDeContrat] nvarchar(max)  NOT NULL,
    [DateNaissance] datetime  NOT NULL,
    [LieuNaissance] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NOT NULL,
    [Profil] nvarchar(max)  NOT NULL,
    [EmailPersonnel] nvarchar(max)  NOT NULL,
    [AdresseDomicile_Id] int  NOT NULL,
    [Service1_Id] int  NOT NULL
);
GO

-- Creating table 'CompteAdmins'
CREATE TABLE [dbo].[CompteAdmins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Motif] nvarchar(max)  NOT NULL,
    [NomBoite] nvarchar(max)  NOT NULL,
    [NomDemandeur] nvarchar(max)  NOT NULL,
    [StatutDemande] nvarchar(max)  NOT NULL,
    [Info] nvarchar(max)  NOT NULL,
    [ServiceId] int  NOT NULL,
    [EmailAdmin] nvarchar(max)  NOT NULL,
    [DateCreation] datetime  NOT NULL
);
GO

-- Creating table 'AdresseDomiciles'
CREATE TABLE [dbo].[AdresseDomiciles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [NomRue] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [TelephonesService] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DemandeCreation2'
CREATE TABLE [dbo].[DemandeCreation2] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateDeDemande] nvarchar(max)  NOT NULL,
    [NumeroDeDemande] nvarchar(max)  NOT NULL,
    [TitreDeDemande] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Personnels_RespService'
CREATE TABLE [dbo].[Personnels_RespService] (
    [RespServiceId] int IDENTITY(1,1) NOT NULL,
    [DemandeCreationId] int  NOT NULL,
    [Id] int  NOT NULL,
    [Service_Id] int  NOT NULL
);
GO

-- Creating table 'DemandeCreation2Service'
CREATE TABLE [dbo].[DemandeCreation2Service] (
    [DemandeCreation2_Id] int  NOT NULL,
    [Services_Id] int  NOT NULL
);
GO

-- Creating table 'DemandeCreation2RespService'
CREATE TABLE [dbo].[DemandeCreation2RespService] (
    [DemandeCreation2_Id] int  NOT NULL,
    [RespServices_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Personnels'
ALTER TABLE [dbo].[Personnels]
ADD CONSTRAINT [PK_Personnels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompteAdmins'
ALTER TABLE [dbo].[CompteAdmins]
ADD CONSTRAINT [PK_CompteAdmins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdresseDomiciles'
ALTER TABLE [dbo].[AdresseDomiciles]
ADD CONSTRAINT [PK_AdresseDomiciles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DemandeCreation2'
ALTER TABLE [dbo].[DemandeCreation2]
ADD CONSTRAINT [PK_DemandeCreation2]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personnels_RespService'
ALTER TABLE [dbo].[Personnels_RespService]
ADD CONSTRAINT [PK_Personnels_RespService]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DemandeCreation2_Id], [Services_Id] in table 'DemandeCreation2Service'
ALTER TABLE [dbo].[DemandeCreation2Service]
ADD CONSTRAINT [PK_DemandeCreation2Service]
    PRIMARY KEY CLUSTERED ([DemandeCreation2_Id], [Services_Id] ASC);
GO

-- Creating primary key on [DemandeCreation2_Id], [RespServices_Id] in table 'DemandeCreation2RespService'
ALTER TABLE [dbo].[DemandeCreation2RespService]
ADD CONSTRAINT [PK_DemandeCreation2RespService]
    PRIMARY KEY CLUSTERED ([DemandeCreation2_Id], [RespServices_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AdresseDomicile_Id] in table 'Personnels'
ALTER TABLE [dbo].[Personnels]
ADD CONSTRAINT [FK_AdresseDomicilePersonnel]
    FOREIGN KEY ([AdresseDomicile_Id])
    REFERENCES [dbo].[AdresseDomiciles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdresseDomicilePersonnel'
CREATE INDEX [IX_FK_AdresseDomicilePersonnel]
ON [dbo].[Personnels]
    ([AdresseDomicile_Id]);
GO

-- Creating foreign key on [ServiceId] in table 'CompteAdmins'
ALTER TABLE [dbo].[CompteAdmins]
ADD CONSTRAINT [FK_ServiceEmailAdministratif]
    FOREIGN KEY ([ServiceId])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceEmailAdministratif'
CREATE INDEX [IX_FK_ServiceEmailAdministratif]
ON [dbo].[CompteAdmins]
    ([ServiceId]);
GO

-- Creating foreign key on [Service_Id] in table 'Personnels_RespService'
ALTER TABLE [dbo].[Personnels_RespService]
ADD CONSTRAINT [FK_RespServiceService]
    FOREIGN KEY ([Service_Id])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RespServiceService'
CREATE INDEX [IX_FK_RespServiceService]
ON [dbo].[Personnels_RespService]
    ([Service_Id]);
GO

-- Creating foreign key on [Service1_Id] in table 'Personnels'
ALTER TABLE [dbo].[Personnels]
ADD CONSTRAINT [FK_PersonnelService]
    FOREIGN KEY ([Service1_Id])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonnelService'
CREATE INDEX [IX_FK_PersonnelService]
ON [dbo].[Personnels]
    ([Service1_Id]);
GO

-- Creating foreign key on [DemandeCreation2_Id] in table 'DemandeCreation2Service'
ALTER TABLE [dbo].[DemandeCreation2Service]
ADD CONSTRAINT [FK_DemandeCreation2Service_DemandeCreation2]
    FOREIGN KEY ([DemandeCreation2_Id])
    REFERENCES [dbo].[DemandeCreation2]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Services_Id] in table 'DemandeCreation2Service'
ALTER TABLE [dbo].[DemandeCreation2Service]
ADD CONSTRAINT [FK_DemandeCreation2Service_Service]
    FOREIGN KEY ([Services_Id])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemandeCreation2Service_Service'
CREATE INDEX [IX_FK_DemandeCreation2Service_Service]
ON [dbo].[DemandeCreation2Service]
    ([Services_Id]);
GO

-- Creating foreign key on [DemandeCreation2_Id] in table 'DemandeCreation2RespService'
ALTER TABLE [dbo].[DemandeCreation2RespService]
ADD CONSTRAINT [FK_DemandeCreation2RespService_DemandeCreation2]
    FOREIGN KEY ([DemandeCreation2_Id])
    REFERENCES [dbo].[DemandeCreation2]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RespServices_Id] in table 'DemandeCreation2RespService'
ALTER TABLE [dbo].[DemandeCreation2RespService]
ADD CONSTRAINT [FK_DemandeCreation2RespService_RespService]
    FOREIGN KEY ([RespServices_Id])
    REFERENCES [dbo].[Personnels_RespService]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemandeCreation2RespService_RespService'
CREATE INDEX [IX_FK_DemandeCreation2RespService_RespService]
ON [dbo].[DemandeCreation2RespService]
    ([RespServices_Id]);
GO

-- Creating foreign key on [Id] in table 'Personnels_RespService'
ALTER TABLE [dbo].[Personnels_RespService]
ADD CONSTRAINT [FK_RespService_inherits_Personnel]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Personnels]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------