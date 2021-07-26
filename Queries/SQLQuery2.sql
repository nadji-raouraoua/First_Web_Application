ALTER TABLE [dbo].[Seance] 
   ADD CONSTRAINT FK_Seance_Gymnase FOREIGN KEY (IDGymnase)
      REFERENCES [dbo].[Gymnase] (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;