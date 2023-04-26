INSERT INTO [dbo].[Items]
           ([ID]
           ,[Name]
           ,[Category]
           ,[price]
           ,[GUID]
           ,LogoRef
           )
     VALUES
           (@ID
           ,@Name
           ,@Category
           ,@price
           ,@GUID
           ,@LogoRef)