CREATE PROCEDURE dbo.CarsDeletion
@CarsID int
AS
DELETE tbl_Cars
WHERE CarsID=@CarsID
 