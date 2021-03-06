USE [master]
GO
CREATE DATABASE [Reservations]
GO
USE [Reservations]
GO
CREATE TABLE [dbo].[HotelReservation](
	[HotelReservationId] [int] IDENTITY(1,1) NOT NULL,
	[HotelId] [int] NOT NULL,
	[HotelName] nvarchar(200) NOT NULL,
	[CreateDate] [date] NOT NULL,
	[DateFrom] [date] NOT NULL,
	[DateTo] [date] NOT NULL,
	[AdultsCount] [int] NOT NULL,
	[ChildrenCount] [int] NOT NULL,
 CONSTRAINT [PK_HotelReservations] PRIMARY KEY CLUSTERED 
(
	[HotelReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
