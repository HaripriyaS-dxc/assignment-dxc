create database assessment
use assessment

create table branch_master(
branch_id varchar(6),
branch_name varchar(30),
branch_city varchar(30),
constraint pk_branch primary key(branch_id))

create table loan_details(
customer_number varchar(6),
branch_id varchar(6),
loan_amount int,
constraint fk_loan foreign key(branch_id) references branch_master(branch_id) 
)

alter table loan_details add constraint fk_loanc foreign key(customer_number) references customer_master(customer_number)

create table customer_master(
customer_number varchar(6),
firstname varchar(30),
middlename varchar(30),
lastname varchar(30),
customer_city varchar(15),
customer_contact_no varchar(10),
occupation varchar(20),
customer_date_of_birth date,
constraint pk_customer primary key(customer_number))

create table account_master(
account_number varchar(6),
customer_number varchar(6),
branch_id varchar(6),
opening_balance int,
account_opening_date date,
account_type varchar(10),
account_status varchar(10),
constraint pk_account primary key(account_number),
constraint fk_account1 foreign key(customer_number) references customer_master(customer_number),
constraint fk_account2 foreign key(branch_id) references branch_master(branch_id));

create table transaction_details(
transaction_number varchar(6),
account_number varchar(6),
date_of_transaction date,
medium_of_transaction varchar(20),
transaction_type varchar(20),
transaction_amount int,
constraint pk_transaction primary key(transaction_number),
constraint fk_transaction foreign key(account_number) references account_master(account_number))

SELECT * FROM transaction_details

DELETE FROM loan_details WHERE branch_id IS NULL
INSERT INTO loan_details VALUES ('C00002','B00001',600000)


SELECT account_number, customer_master.customer_number,firstname,lastname,account_opening_date 
FROM customer_master
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number ORDER BY account_number ASC

SELECT COUNT(customer_number) AS Cust_Count FROM customer_master WHERE customer_city='DELHI'

SELECT customer_master.customer_number,firstname, account_number  
FROM customer_master 
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number 
WHERE day(account_opening_date) > 15
ORDER BY account_number ASC


SELECT customer_master.customer_number,firstname, account_number  
FROM customer_master
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number 
WHERE account_status = 'TERMINATED'
ORDER BY account_number ASC,customer_number ASC

select count(transaction_type) as trans_count,
(select count(transaction_type) from transaction_details where transaction_type='DEPOSIT' and account_number='A00001') as deposits,
(select count(transaction_type) from transaction_details where transaction_type='WITHDRAWAL' and account_number='A00001') as withdrawals
 from transaction_details
where account_number='A00001'



