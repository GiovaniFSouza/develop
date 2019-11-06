USE [PfjDB]
GO

/****** Object: Table [dbo].[Pessoa] Script Date: 22/08/2019 11:22:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Pessoa];


GO
CREATE TABLE [dbo].[Pessoa] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [codigo]         VARCHAR (10)  NULL,
    [nome]           VARCHAR (50)  NOT NULL,
    [apelido]        VARCHAR (50)  NULL,
    [cep]            VARCHAR (8)   NOT NULL,
    [logradouro]     VARCHAR (70)  NOT NULL,
    [numero]         VARCHAR (10)  NOT NULL,
    [municipio]      INT           NOT NULL,
    [bairro]         VARCHAR (50)  NOT NULL,
    [estado]         INT           NOT NULL,
    [pais]           INT           NOT NULL,
    [estadocivil]    INT           NOT NULL,
    [profissao]      INT           NOT NULL,
    [nacionalidade]  VARCHAR (20)  NULL,
    [datanascimento] DATETIME      NOT NULL,
    [pessoa_fj]      VARCHAR (1)   NOT NULL,
    [cpf_cnpj]       VARCHAR (15)  NOT NULL,
    [rg]             VARCHAR (18)  NULL,
    [orgexpe]        VARCHAR (6)   NULL,
    [codigo_ibge]    VARCHAR (7)   NOT NULL,
    [ie]             VARCHAR (18)  NULL,
    [im]             VARCHAR (18)  NULL,
    [importador]     BIT           NOT NULL,
    [fone]           VARCHAR (12)  NULL,
    [cel]            VARCHAR (12)  NULL,
    [email]          VARCHAR (100) NOT NULL,
    [complemento]    VARCHAR (50)  NULL,
	[datacadastro]	 DATETIME	   NOT NULL
);


