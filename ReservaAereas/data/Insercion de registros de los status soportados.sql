SET IDENTITY_INSERT [dbo].[Status] ON
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (1, N'Desocupada', 1)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (2, N'Ocupada', 1)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (3, N'Mantenimiento', 1)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (4, N'Alta', 2)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (5, N'Baja', 2)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (6, N'En vuelo', 3)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (7, N'Aterrizaje', 3)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (8, N'Aterrizaje emergencia', 3)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (9, N'Desabordar', 3)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (10, N'Abordar', 3)
INSERT INTO [dbo].[Status] ([Id], [Name], [Category_id]) VALUES (11, N'Despegar', 3)
SET IDENTITY_INSERT [dbo].[Status] OFF
