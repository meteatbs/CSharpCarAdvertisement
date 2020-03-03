ALTER PROCEDURE dbo.CarsAddOrEdit
@mode nvarchar(10),
@CarsID int,@Model nvarchar(50),@Color nvarchar(50),@Brand nvarchar(50),@Year int,@FuelType nvarchar(50),@Gear nvarchar(50)
AS
IF @mode='Add'
BEGIN
INSERT INTO tbl_Cars
(Model,Color,Brand,Year,FuelType,Gear)
VALUES 
(@Model,@Color,@Brand,@Year,@FuelType,@Gear)
END
ELSE IF @mode='Edit'
BEGIN
UPDATE tbl_Cars
SET
Model=@Model,Color=@Color,Brand=@Brand,Year=@Year,FuelType=@FuelType,Gear=@Gear
WHERE CarsID=@CarsID
END

