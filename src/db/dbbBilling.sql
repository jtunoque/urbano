USE [dbBilling]
GO

/****** Object:  Table [dbo].[BillDocument]    Script Date: 1/08/2019 22:06:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BillDocument](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentType] [nvarchar](2) NOT NULL,
	[DocumentNumber] [nvarchar](50) NOT NULL,
	[DocumentIssueDate] [datetime] NOT NULL,
	[ResponseCode] [nvarchar](100) NULL,
	[ResponseMessage] [nvarchar](500) NULL,
	[Status] [int] NOT NULL,
	[CDRFileName] [nvarchar](100) NULL,
	[SentDate] [datetime] NOT NULL,
	[CustomerDocumentType] [nvarchar](20) NOT NULL,
	[CustomerDocumentNumber] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](200) NOT NULL,
	[CustomerAddress] [nvarchar](200) NULL,
	[InvoiceNote] [nvarchar](500) NULL,
	[InvoiceCurrency] [nvarchar](50) NULL,
	[TaxAmount] [decimal](18, 4) NOT NULL,
	[TaxableAmount] [decimal](18, 4) NOT NULL,
	[TotalAmount] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK__BillDocu__3214EC07628DBEA9] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


