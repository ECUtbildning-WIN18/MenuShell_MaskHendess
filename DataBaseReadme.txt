use MenuShell

Create Table Users(
Username    varchar(50),
[Password]   varchar(50),
Userrole    varchar(50)
)

INSERT INTO Users
VALUES('john','john','receptionist'),
('jane','jane','veterinary'),
('jim','jim','sysadmin')

Select * from Users