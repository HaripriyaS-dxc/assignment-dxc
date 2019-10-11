--1--
SELECT account_number, customer_master.customer_number,firstname,lastname,account_opening_date 
FROM customer_master
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number ORDER BY account_number ASC

--2--
SELECT COUNT(customer_number) AS Cust_Count FROM customer_master WHERE customer_city='DELHI'

--3--
SELECT customer_master.customer_number,firstname, account_number  
FROM customer_master 
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number 
WHERE day(account_opening_date) > 15
ORDER BY account_number ASC

--4--
SELECT customer_master.customer_number,firstname, account_number  
FROM customer_master
INNER JOIN account_master 
ON customer_master.customer_number = account_master.customer_number 
WHERE account_status = 'TERMINATED'
ORDER BY account_number ASC,customer_number ASC

--5--
SELECT transaction_type,count(transaction_number) Trans_Count
FROM account_master INNER JOIN transaction_details 
ON account_master.account_number=transaction_details.account_number
WHERE customer_number like '%001'
GROUP BY transaction_type
ORDER BY transaction_type ASC

--6--
SELECT count(customer_number) Count_Customer
FROM customer_master 
WHERE customer_number NOT IN  (SELECT customer_number FROM account_master)

--7--
SELECT account_master.account_number, (MAX(opening_balance)+SUM(transaction_amount)) Deposit_Amount
FROM account_master INNER JOIN transaction_details 
ON account_master.account_number = transaction_details.account_number
WHERE transaction_type='DEPOSIT'
GROUP BY account_master.account_number
ORDER BY account_number