USE EbenezerSolution;
GO

-- Person
CREATE PROCEDURE dbo.InsertPerson
    @FullName NVARCHAR(MAX),
    @Gender NVARCHAR(MAX),
    @NumberPhone NVARCHAR(MAX),
    @Address NVARCHAR(MAX),
    @BirthDate DATETIME,
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @BirthDate > GETDATE()
    BEGIN
        RAISERROR('La fecha de nacimiento no puede ser en el futuro.', 16, 1);
        RETURN;
    END

    INSERT INTO dbo.Person (FullName, Gender, NumberPhone, Address, BirthDate, UserId, CreationDate)
    VALUES (@FullName, @Gender, @NumberPhone, @Address, @BirthDate, @UserId, GETDATE());
END;
GO

CREATE PROCEDURE dbo.UpdatePerson
    @Id INT,
    @FullName NVARCHAR(MAX),
    @Gender NVARCHAR(MAX),
    @NumberPhone NVARCHAR(MAX),
    @Address NVARCHAR(MAX),
    @BirthDate DATETIME,
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @BirthDate > GETDATE()
    BEGIN
        RAISERROR('La fecha de nacimiento no puede ser en el futuro.', 16, 1);
        RETURN;
    END

    UPDATE dbo.Person
    SET FullName = @FullName,
        Gender = @Gender,
        NumberPhone = @NumberPhone,
        Address = @Address,
        BirthDate = @BirthDate,
        UserId = @UserId
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE dbo.DeletePerson
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM dbo.Person WHERE Id = @Id)
    BEGIN
        RAISERROR('La persona con ID especificado no existe.', 16, 1);
        RETURN;
    END

    DELETE FROM dbo.Person WHERE Id = @Id;
END;
GO

CREATE PROCEDURE dbo.GetAllPersons
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Person;
END
GO

CREATE PROCEDURE dbo.GetPersonById
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Person WHERE Id = @Id;
END
GO

CREATE PROCEDURE dbo.SearchPersons
    @Term NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Person WHERE FullName LIKE '%' + @Term + '%';
END
GO

CREATE PROCEDURE dbo.GetPersonsPaginated
    @PageSize INT,
    @PageNumber INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;

    SELECT *
    FROM dbo.Person
    ORDER BY Id
    OFFSET @Offset ROWS
    FETCH NEXT @PageSize ROWS ONLY;
END;
GO

CREATE PROCEDURE dbo.CountPersons
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS TotalPersons
    FROM dbo.Person;
END;
GO

-- //

-- Ministry
CREATE PROCEDURE dbo.CreateMinistry
    @Name NVARCHAR(MAX),
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Ministry (Name, IsActive, CretionDate)
    VALUES (@Name, @IsActive, GETDATE());
END;
GO

CREATE PROCEDURE dbo.UpdateMinistry
    @Id INT,
    @Name NVARCHAR(MAX),
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Ministry
    SET Name = @Name,
        IsActive = @IsActive
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE dbo.DeleteMinistry
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.Ministry WHERE Id = @Id;
END;
GO

CREATE PROCEDURE dbo.GetAllMinistries
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Ministry;
END;
GO

CREATE PROCEDURE dbo.GetMinistryById
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Ministry WHERE Id = @Id;
END;
GO

CREATE PROCEDURE dbo.SearchMinistries
    @Term NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM dbo.Ministry WHERE Name LIKE '%' + @Term + '%';
END;
GO

CREATE PROCEDURE dbo.CountMinistries
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS TotalMinistries FROM dbo.Ministry;
END;
GO

-- //

-- User
CREATE PROCEDURE CreateUser
    @Username NVARCHAR(MAX),
    @Password NVARCHAR(MAX),
    @IsActive BIT,
    @RoleId INT
AS
BEGIN
    INSERT INTO [dbo].[User] (Username, Password, IsActive, RoleId)
    VALUES (@Username, @Password, @IsActive, @RoleId)
END;
GO

CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SELECT
        U.Id AS UserId,
        U.Username,
        U.Password,
        U.IsActive AS UserIsActive,
        U.RoleId AS UserRoleId,
        R.Id AS RoleId,
        R.Name AS RoleName,
        R.IsActive AS RoleIsActive,
        R.CreationDate AS RoleCreationDate
    FROM
        [dbo].[User] U
    INNER JOIN
        [dbo].[Role] R ON U.RoleId = R.Id
END;
GO

CREATE PROCEDURE GetUserById
    @UserId INT
AS
BEGIN
    SELECT
        U.Id AS UserId,
        U.Username,
        U.Password,
        U.IsActive AS UserIsActive,
        R.Id AS RoleId,
        R.Name AS RoleName,
        R.IsActive AS RoleIsActive,
        R.CreationDate AS RoleCreationDate
    FROM
        [dbo].[User] U
    INNER JOIN
        [dbo].[Role] R ON U.RoleId = R.Id
    WHERE
        U.Id = @UserId
END;
GO

CREATE PROCEDURE SearchUsers
    @SearchTerm NVARCHAR(MAX)
AS
BEGIN
    SELECT
        U.Id AS UserId,
        U.Username,
        U.Password,
        U.IsActive AS UserIsActive,
        R.Id AS RoleId,
        R.Name AS RoleName,
        R.IsActive AS RoleIsActive,
        R.CreationDate AS RoleCreationDate
    FROM
        [dbo].[User] U
    INNER JOIN
        [dbo].[Role] R ON U.RoleId = R.Id
    WHERE
        U.Username LIKE '%' + @SearchTerm + '%'
END;
GO

CREATE PROCEDURE UpdateUser
    @UserId INT,
    @Username NVARCHAR(MAX),
    @Password NVARCHAR(MAX),
    @IsActive BIT,
    @RoleId INT
AS
BEGIN
    UPDATE [dbo].[User]
    SET
        Username = @Username,
        Password = @Password,
        IsActive = @IsActive,
        RoleId = @RoleId
    WHERE
        Id = @UserId
END;
GO

CREATE PROCEDURE DeleteUser
    @UserId INT
AS
BEGIN
    DELETE FROM [dbo].[User]
    WHERE
        Id = @UserId
END;
GO

CREATE PROCEDURE CountUsers
AS
BEGIN
    SELECT COUNT(*) AS UserCount
    FROM [dbo].[User]
END;
GO
