CREATE PROCEDURE dbo.AdvertisementSearchColor
@Color nvarchar(50)
AS
SELECT * FROM tbl_Cars WHERE Color LIKE @Color+ '%'
 