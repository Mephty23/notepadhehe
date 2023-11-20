
drop table info1
create table info (
	fname varchar(60),
	lname varchar(60),
	username varchar(60) not null,
	pass varchar(20) not null
)

create table info1 (
	id int primary key ,
	fname varchar(60),
	lname varchar(60),
	username varchar(60) not null,
	pass varchar(20) not null
)

CREATE PROCEDURE db_save3
    @fname VARCHAR(60),
    @lname VARCHAR(60),
    @username VARCHAR(60),
    @pass VARCHAR(20)
AS
BEGIN
    INSERT INTO info(fname, lname, username, pass)
    VALUES (@fname, @lname, @username, @pass)
END

CREATE PROCEDURE log_db
    @username VARCHAR(60),
    @pass VARCHAR(20)
AS
BEGIN
    SELECT *
    FROM info
    WHERE username = @username AND pass = @pass
END


