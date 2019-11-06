USE [PfjDB]
GO

/****** Object: Table [dbo].[CodUf] Script Date: 26/08/2019 17:19:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[CodUf];


GO
CREATE TABLE [dbo].[CodUf] (
    [Id]           INT   PRIMARY KEY NOT NULL,
    [codigo]       VARCHAR (2) NOT NULL,
    [sigla]        VARCHAR (2) NOT NULL,
    [vigencia_ini] DATETIME    NOT NULL,
    [vigencia_fim] DATETIME    NULL
);


