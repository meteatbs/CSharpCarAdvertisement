CREATE PROCEDURE dbo.AdvertisementViewOrSearch
@Model nvarchar(50)
AS
SELECT * FROM tbl_Cars WHERE Model LIKE @Model+ '%'
 