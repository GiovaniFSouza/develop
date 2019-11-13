USE [PfjDB]
GO

/****** Object: View [dbo].[CodUfxUf] Script Date: 13/11/2019 14:50:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP VIEW [dbo].[CodUfxUf];


GO
CREATE VIEW [dbo].[CodUfxUf]
	AS SELECT cd.Id , uf.nome , cd.sigla
	--, cd.sigla, uf.codigo as siglas
	FROM [CODUF] as cd								 
	inner join [Ufs] as uf (NOLOCK) on uf.codigo = cd.sigla
