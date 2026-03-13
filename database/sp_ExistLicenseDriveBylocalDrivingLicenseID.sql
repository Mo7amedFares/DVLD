CREATE OR ALTER PROCEDURE dbo.sp_ExistLicenseDriveBylocalDrivingLicenseID
    @localDrivingLicenseID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1 l.LicenseID
    FROM   dbo.License           l
    INNER JOIN dbo.LocalDrivingLicense ldl
           ON  l.RequestID = ldl.Request_id
    WHERE  ldl.Local_Driving_License_Id = @localDrivingLicenseID;
END;
GO