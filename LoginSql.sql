use CustomLogin;


CREATE TABLE Users (
    user_id int IDENTITY(1,1) PRIMARY KEY,
    UserName varchar(50) NOT NULL,
    User_password varchar(255) NOT NULL,
    IsAdmin int
);

INSERT INTO Users (Username , User_password, IsAdmin)
VALUES ('Admin', 'Admin', 1);
INSERT INTO Users (Username , User_password, IsAdmin)
VALUES ('Test', 'Test', 0);

Select * from Users;


CREATE TABLE CreatedUsers (
    user_id int IDENTITY(1000,1) PRIMARY KEY,
    UserName varchar(50) NOT NULL,
    User_password varchar(255) NOT NULL,
    IsAdmin int,
	mainIamge varchar(250)
);

Select * from CreatedUsers;

DELETE FROM CreatedUsers where user_id = 1000;

CREATE TABLE LoginUsers2 (
    user_id int IDENTITY(1,1) PRIMARY KEY,
    UserName varchar(50) NOT NULL UNIQUE,
    User_password varchar(255) NOT NULL,
    IsAdmin int,
	Comment varchar(255)
);
INSERT INTO LoginUsers2 (Username , User_password, IsAdmin, Comment)
VALUES ('Admin', 'Admin', 1, 'MAIN ADMIN ACCOUNT');
INSERT INTO LoginUsers2 (Username , User_password, IsAdmin, Comment)
VALUES ('Test', 'Test', 0, 'NOT ADMIN ACCOUNT');
Select * from LoginUsers2;