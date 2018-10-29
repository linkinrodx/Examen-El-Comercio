
use [E:\PROYECTOS RSS\EVALUACION COMERCIO\CONEXION\BD\BD_COMERCIO.MDF]

select * from banco
select * from sucursal
select * from OrdenPago
select * from usuario

insert into banco(Nombre, Direccion, FechaRegistro)
values ('Banco El Comercio', 'Calle las begonias 123', GETDATE())

insert into Sucursal(Nombre, Direccion, FechaRegistro, IdBanco)
values ('Sede San Isidro', 'Paque Kennedy 7258', GETDATE(), 1)

insert into OrdenPago(Monto, Moneda, Estado, FechaPago)
values (100, 'S/.', 1, GETDATE())

insert into OrdenPago(Monto, Moneda, Estado, FechaPago, IdSucursal)
values (100, 'S/.', 2, GETDATE(), 1)

insert into usuario(Nombre, Contrasenia, Estado, RolId, FechaRegistro)
values ('Rodrigo', 'Facil123', 1, 1, GETDATE())

insert into usuario(Nombre, Contrasenia, Estado, RolId, FechaRegistro)
values ('Carlos', 'Facil123', 1, 2, GETDATE())

insert into usuario(Nombre, Contrasenia, Estado, RolId, FechaRegistro)
values ('Pedro', 'Facil123', 1, 3, GETDATE())

select * from OrdenPago where IdSucursal = 0 or 0=0
/*
CREATE TABLE [dbo].[Banco] (
	[IdBanco] [int] IDENTITY (1, 1) not null,
	[Nombre] [varchar] (500) not null,
	[Direccion] [varchar] (1000) not null, 
	[FechaRegistro] [datetime] not null
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Banco] WITH NOCHECK ADD 
	CONSTRAINT [PK_Banco] PRIMARY KEY  CLUSTERED 
	(
		[IdBanco]
	)  ON [PRIMARY] 
GO


CREATE TABLE [dbo].[Sucursal] (
	[IdSucursal] [int] IDENTITY (1, 1) not null,
	[Nombre] [varchar] (100) not null,
	[Direccion] [varchar] (100) null, 
	[FechaRegistro] [datetime] not null,
	[IdBanco] [int] not null, 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sucursal] WITH NOCHECK ADD 
	CONSTRAINT [PK_Sucursal] PRIMARY KEY  CLUSTERED 
	(
		[IdSucursal]
	)  ON [PRIMARY] 
GO

CREATE TABLE [dbo].[OrdenPago] (
	[IdOrden] [int] IDENTITY (1, 1) not null,
	[Monto] [money] not null,
	[Moneda] [varchar] (10) not null, 
	[Estado] [int] not null,
	[FechaPago] [datetime] not null,
	[IdSucursal] [int] null, 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrdenPago] WITH NOCHECK ADD 
	CONSTRAINT [PK_OrdenPago] PRIMARY KEY  CLUSTERED 
	(
		[IdOrden]
	)  ON [PRIMARY] 
GO*/

CREATE TABLE [dbo].[Usuario] (
	[IdUsuario] [int] IDENTITY (1, 1) not null,
	[Nombre] [varchar] (100) not null,
	[Contrasenia] [varchar] (100) not null, 
	[Estado] [int] not null,
	[RolId] [int] not null,
	[FechaRegistro] [datetime] not null,
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuario]WITH NOCHECK ADD 
	CONSTRAINT [PK_Usuario] PRIMARY KEY  CLUSTERED 
	(
		[IdUsuario]
	)  ON [PRIMARY] 
GO
