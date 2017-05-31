
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 11:08:16
-- Generated from EDMX file: C:\Users\Will\Documents\Asp.netGIT\ProjetoWebForms\ProjetoWebForms\Models\CatalogoJogos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BancoCatalogoJogos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Catalogos'
CREATE TABLE [dbo].[Catalogos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Jogos'
CREATE TABLE [dbo].[Jogos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(25)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [CatalogoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Catalogos'
ALTER TABLE [dbo].[Catalogos]
ADD CONSTRAINT [PK_Catalogos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jogos'
ALTER TABLE [dbo].[Jogos]
ADD CONSTRAINT [PK_Jogos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CatalogoId] in table 'Jogos'
ALTER TABLE [dbo].[Jogos]
ADD CONSTRAINT [FK_CatalogoJogo]
    FOREIGN KEY ([CatalogoId])
    REFERENCES [dbo].[Catalogos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatalogoJogo'
CREATE INDEX [IX_FK_CatalogoJogo]
ON [dbo].[Jogos]
    ([CatalogoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------