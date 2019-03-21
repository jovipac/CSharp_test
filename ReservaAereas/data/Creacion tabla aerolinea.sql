CREATE TABLE dbo.Airline (
                Id INT IDENTITY NOT NULL,
                Name VARCHAR(100) NOT NULL,
                Status_id INT NOT NULL,
                CONSTRAINT Airline_pk PRIMARY KEY (Id)
)