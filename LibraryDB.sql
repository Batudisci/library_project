USE [LibraryDb]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230913095431_mig1', N'6.0.21')
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([ID], [BookName], [BookWriter], [BookImage], [IsInLibrary], [Borrower], [BookDescription], [DeadLine]) VALUES (1, N'Sakkara''nın Kumları', N'Glenn Meade', N'debc92d3-9022-441d-9024-d6682a25c42e.jpg', 1, NULL, N'Glenn Meade, İkinci Dünya Savaşı''nın ortasında Mısır''da geçen ilginç ve heyecanlı bir öyküyü anlatıyor. Yıl 1939''dur. Prusya''lı bir anne ile Amerikalı bir babanın oğlu olan Jack, ailesinin yanında bahçıvan olarak çalışan adamın oğlu Harry''yle birlikte Mısır''a, Sakkara kazılarında çalışmaya gider. Orada güzel Alman Yahudisi Rachel Stern''le karşılaşan iki genç ona aşık olurlar. İkinci Dünya Savaşı''nın çıkmasıyla Jack Avrupa''ya döner. ', NULL)
INSERT [dbo].[Books] ([ID], [BookName], [BookWriter], [BookImage], [IsInLibrary], [Borrower], [BookDescription], [DeadLine]) VALUES (2, N'Kar Kurdu', N'Glenn Meade', N'e07e73a1-7484-46cb-9ddb-c858faf83b62.jpg', 0, N'Batuhan Dişci', N'Soğuk Savaş’ın en gergin dönemi. Başkan Eisenhower, Stalin’in akli dengesinin bozulduğuna ilişkin ürkütücü bir istihbarat alır. Daha da kötüsü, SSCB’nin Üçüncü Dünya Savaşı’nı başlatabilecek nükleer bomba programının tamamlanmakta olduğunu öğrenir. Bu haber Eisenhower’ın başkanlık yemin töreninden yalnızca birkaç saat sonra, hiçbir Amerikan başkanının cüret edemeyeceği bir karar almasına neden olacaktır: Stalin’e suikast!', CAST(N'2023-09-20T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
