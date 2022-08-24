create view employeesvwtable as
select employee_name,employee_wages from Employees
where employee_wages>300;