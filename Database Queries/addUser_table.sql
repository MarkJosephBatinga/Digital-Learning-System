-- create muna ng new database name learnItDb
-- sql server version 2018

--for the registration form
CREATE TABLE user_table(
	id INT NOT NULL IDENTITY,
	last_name NVARCHAR(50) NOT NULL,
	first_name NVARCHAR(50) NOT NULL,
	email NVARCHAR(50) NOT NULL UNIQUE,
	user_password BINARY(64) NOT NULL,
	user_role VARCHAR(20) NOT NULL,
	PRIMARY KEY(id)
);

--for the getting started form
CREATE TABLE user_profile(
	profile_id INT NOT NULL IDENTITY,
	year_level VARCHAR(20) NOT NULL,
    birth_date NVARCHAR(50) NOT NULL,
    gender VARCHAR(20) NOT NULL,
    phone BIGINT NOT NULL,
    add_street NVARCHAR(50) NOT NULL,
    add_town NVARCHAR(50) NOT NULL
    add_province NVARCHAR(50) NOT NULL
    add_zipcode INT NOT NULL,
    id INT NOT NULL,
	PRIMARY KEY(profile_id)
);