CREATE TABLE dbo.Airline (
                Id INT IDENTITY NOT NULL,
                Name VARCHAR(100) NOT NULL,
                Status_id INT NULL,
                CONSTRAINT Airline_pk PRIMARY KEY (Id)
)