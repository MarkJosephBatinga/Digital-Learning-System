CREATE DATABASE learnItDb;

CREATE TABLE user_table(
	id INT NOT NULL IDENTITY,
	last_name NVARCHAR(50) NOT NULL,
	first_name NVARCHAR(50) NOT NULL,
	email NVARCHAR(50) NOT NULL UNIQUE,
	user_password BINARY(64) NOT NULL,
	user_role VARCHAR(20) NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE user_profile(
	profile_id INT NOT NULL IDENTITY,
	year_level VARCHAR(20) NOT NULL,
    birth_date NVARCHAR(50) NOT NULL,
    gender VARCHAR(20) NOT NULL,
    phone BIGINT NOT NULL,
    add_street NVARCHAR(50) NOT NULL,
    add_town NVARCHAR(50) NOT NULL,
    add_province NVARCHAR(50) NOT NULL,
    add_zipcode INT NOT NULL,
    id INT NOT NULL,
	PRIMARY KEY(profile_id)
);

CREATE TABLE user_class(
	class_id INT NOT NULL IDENTITY,
	class_title nvarchar(100) NOT NULL,
    class_section NVARCHAR(50) NOT NULL,
    class_code varchar(20) NOT NULL,
    class_description nvarchar(200) NOT NULL,
    class_creator int NOT NULL,
	PRIMARY KEY(class_id)
);

CREATE TABLE student_class(
	student_class_id INT NOT NULL IDENTITY,
	student_id int NOT NULL,
    class_id int NOT NULL,
	PRIMARY KEY(student_class_id)
);

CREATE TABLE user_tasks(
	task_id INT NOT NULL IDENTITY,
	class_id INT NOT NULL,
    cur_date NVARCHAR(50) NOT NULL,
    task_title NVARCHAR(100) NOT NULL,
    task_type NVARCHAR(50) NOT NULL,
    task_date NVARCHAR(50),
    task_time NVARCHAR(50),
    task_filename nvarchar(50),
    task_filepath nvarchar(MAX),
    task_description nvarchar(MAX),
	PRIMARY KEY(task_id),
);

CREATE TABLE student_task(
	student_task_id INT NOT NULL IDENTITY,
	student_class_id INT,
    student_pass nvarchar(50) NOT NULL,
    student_grade int,
    date_passed nvarchar(30),
    pdf_name nvarchar(100),
    pdf_path nvarchar(MAX),
    user_task_id int,
	PRIMARY KEY(student_task_id),
);

CREATE TABLE user_chat(
	chat_id INT NOT NULL IDENTITY,
	class_id INT NOT NULL,
    users_id nvarchar(50) NOT NULL,
    curr_time nvarchar(30) NOT NULL,
    curr_date nvarchar(30) NOT NULL,
    user_message nvarchar(MAX) NOT NULL,
	PRIMARY KEY(chat_id),
);