CREATE OR ALTER PROCEDURE dbo.sp_GetLicenseClassByID
    @License_Class_ID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT LicenseClassID, ClassName, Description,
           MinimumAllowedAge, ValidityLength, Fees
    FROM   dbo.LicenseClass
    WHERE  LicenseClassID = @License_Class_ID;
END;
GO