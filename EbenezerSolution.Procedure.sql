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
