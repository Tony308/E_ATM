USE bank;
GO
CREATE PROC dbo.selectClient @RFID VARCHAR(12), @PIN VARCHAR(16) AS 
	SELECT * FROM client
	WHERE RFID = @RFID AND
	PIN  = @PIN;
GO

USE bank
GO
CREATE PROC dbo.updateClient @RFID VARCHAR(12), @PIN VARCHAR(16), @BALANCE NUMERIC(12,2) AS
	UPDATE client SET
	PIN = @PIN
	WHERE RFID = @RFID;
GO

USE bank;
GO
CREATE PROC dbo.insertClient @RFID VARCHAR(12), @PIN VARCHAR(16), @BALANCE NUMERIC(12,2) AS
	INSERT INTO client VALUES (@RFID, @PIN, @BALANCE);
GO