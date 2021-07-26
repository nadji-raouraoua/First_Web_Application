ALTER TABLE [dbo].[Seance] 
   ADD CONSTRAINT FK_Seance_Sport FOREIGN KEY (IDSport)
      REFERENCES [dbo].[Sport] (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;