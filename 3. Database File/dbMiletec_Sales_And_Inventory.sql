create database Miletec
use Miletec

--Tables
select * from tblcustomertransaction

--Creates table for sp_update_CustomerTransactionUser(Admin and Staff)
create table tblUser
(
UserID VARCHAR(30) PRIMARY KEY,
LastName VARCHAR(30),
FirstName VARCHAR(30),
MiddleName VARCHAR(30),
Username NVARCHAR(30),
Password NVARCHAR(max),
isactive NVARCHAR(max),
secret_question NVARCHAR (max),
secret_answer  NVARCHAR(max),
Status varchar(30)
)

select * from tblUser
SELECT * FROM tblCustomerDelivery
 
delete from tblcustomertransaction	
delete from tblDelivery_Supplier
delete from tblDeliveryDetails
delete from tblCustomerDeliveryDetails
delete from tblProducts
delete from tblOrders
delete from tblSupplierDetails
delete from tblUser where UserID = 'User-0006'
delete from tblOrderDetails
delete from tblUser where Lastname = 'norlyn'
delete  from tblUser
select * from tblUser
delete from tblcustomerdetails
delete from tblCustomerDeliveryDetails
delete select *from tblStocks
delete from tblDamagesAndReplacements
select * from tblCustomerDeliveryDetails

create table tblStocks
(
productid varchar (30) primary key,
productname varchar (30),
availqty int,
price float,
Size float,
Damages int,
Replacement int
)
 
select * from tblcustomertransaction

insert into tblStocks values('ProductID-0001','Glass',0,0,1,0,0)
insert into tblStocks values('ProductID-0002','Around Tube Aluminum',0,0,0,0,0)
insert into tblStocks values('ProductID-0003','Stainless Tube Aluminum',0,0,0,0,0)
select * from tblStocks
--retrieves all the data of the product using the productID
create proc sp_RetrieveStocksQuantity
@ProductID varchar(30),
@ProductName varchar(30)
as select * from tblStocks where productid = @ProductID and productname = @ProductName

create proc sp_Update_StocksQty
@ProductID varchar(30),
@AvailableQuantity int
as update tblStocks set availqty = @AvailableQuantity where productid = @ProductID


create proc sp_get_ProductPrice
@ProductID varchar(30)
as select price from tblStocks where productid = @ProductID 

create proc sp_view_stock
as select * from tblStocks         


create proc sp_searchStock
@search varchar (30)
as select * from tblStocks
where ProductID like @search + '%'
or ProductName like @search + '%'

create proc sp_update_stock_price
@price float,
@productid varchar (30)
as update tblStocks
set price = @price
where productid = @productid

create proc sp_display_stock
@productid varchar (30)
as select price from tblstocks
where productid = @productid


--create table for customer details 07-24-16
create table tblcustomerdetails
(
UserID varchar (30) foreign key references tblUser (UserID),
CustomerID varchar (30) primary key,
CustomerName nvarchar (30),
Address nvarchar (30),
Contactnumber1 varchar (20),
Contactnumber2 varchar (20),
)

select * from tblinstallation

--create table for supplier details
create table tblSupplierDetails
(
AdminID VARCHAR (30) foreign key references tblUser (UserID),
SupplierID varchar (30) primary key,
SupplierName varchar(30),
Address varchar(30),
ContactNumber1 int,
ContactNumber2 int,
ContactPerson varchar(30),
)


create proc sp_Update_SupplierDetails
@SupplierID varchar (30),
@SupplierName varchar(30),
@Address varchar(30),
@ContactNumber1 int,
@ContactNumber2 int,
@ContactPerson varchar(30)
as update tblSupplierDetails
set SupplierName = @SupplierName, Address = @Address, ContactNumber1 = @ContactNumber1, ContactNumber2 = @ContactNumber2, ContactPerson = @ContactPerson
where SupplierID = @SupplierID
--Changes of tables starts here(07/14/16)

create table tblProducts
(
SupplierID varchar (30) foreign key references tblSupplierDetails (SupplierID),
ProductID VARCHAR (30),
ProductName varchar (30),
AvailQty int,
)


create table tblOrders
(
OrderID varchar (30) primary key,
SupplierID varchar (30) foreign key references tblSupplierDetails (SupplierID),
OrderDate datetime,
OrderBy VARCHAR (30) foreign key references tblUser (UserID),
Status varchar(50)
)


--Creates table for Order Display
create table tblOrderDetails
(
OrderID varchar (30) foreign key references tblOrders (OrderID),
ProdID varchar (30),
ProductName varchar (30),
Quantity int,
Status varchar(50)
)

delete from tblProducts

-- for transaction
create table tblcustomertransaction
(
transactionid varchar (30) primary key,
date datetime,
dateOrder datetime,
time varchar (30),
customerid varchar (30) foreign key references tblcustomerdetails(CustomerID),
CustomerName varchar(max),
address varchar (30),
TotalInstallationPayment float,
Gtotal float,
Cashrendered float,
unitprice float,
change float,
services varchar (30),
status varchar (30)
)

create proc sp_RetreiveOrderDetails
@ProductName varchar (30),
@Quantity int
as select ProductName = @ProductName, Quantity = @Quantity from tblOrderDetails

select * from tblinstallation
create table tblinstallation
(
customerid varchar (30) foreign key references tblcustomerdetails(CustomerID),
Transactionid varchar (30)foreign key references tblcustomertransaction(transactionid),
productid varchar (30),
CustomerName varchar (30),
InstallationName varchar (30),
date datetime,
--InstallationPayment float,
--total float,
--cashrender float,
--chan
)


create proc sp_insertInstallation
@customerid varchar (30),
@Transactionid varchar (30),
@productid varchar (30),
@CustomerName varchar (30),
@InsatallationName varchar (30),
@date datetime
as insert into tblinstallation (customerid, Transactionid,productid, CustomerName, InstallationName, date)
values  (@customerid, @Transactionid,@productid, @CustomerName,@InsatallationName, @date)


create proc sp_viewInstallion
as select * from tblinstallation

create proc sp_generateInstallationID
as select count (*) as count from tblinstallation


create proc sp_searchInstallation
@search varchar (30)
as select * from tblinstallation
where installationid like @search + '%'
or customerid like @search + '%'
or Customerid like @search + '%'



SELECT * from tblcustomertransaction

--updates the table Customer Transaction
create proc sp_update_CustomerTransaction
@TransactionID varchar(30),
@TotalInstaPayment float,
@Gtotal float,
@Cashrendered float,
@unitprice float,
@change float,
@time varchar (30),
@date datetime,
@dateOrder datetime,
@services varchar (30),
@status varchar (30)
as update tblcustomertransaction set date = @date,  time = @time, TotalInstallationPayment = @TotalInstaPayment, 
 Gtotal = @Gtotal, Cashrendered = @Cashrendered, unitprice = @unitprice,
 change = @change, dateOrder = @dateOrder, services = @services, status = @status
where transactionid = @TransactionID

select * from tblDeliveryDetails
select * from tblcustomertrans_details
SELECT * FROM tblcustomertransaction

create proc sp_removeTrans_details
@transactionid varchar(30)
as delete from tblcustomertrans_details
where transactionid = @transactionid

--customer delivery
create table tblCustomerDelivery
(
DeliveryID varchar (30)Primary key,
transactionid varchar (30) foreign key references tblcustomertransaction (transactionid),
date datetime,
preparedby varchar (30)foreign key references tblUser (UserID),
TimetoDeliver varchar(30)
)


--table for customer delivery details
create table tblCustomerDeliveryDetails
(
DeliveryNo varchar(30) foreign key references tblCustomerDelivery(DeliveryID),
TransactionID varchar (30) foreign key references tblcustomertransaction (transactionid),
ProdID varchar (30),
ProductName varchar (30),
Quantity int,
TimeToDeliver varchar(30)
)


select * from tblCustomerDeliveryDetails

create table tblcustomertrans_details
(
transactionid varchar (30) foreign key references tblcustomertransaction (transactionid),
productid varchar (30),
productname varchar(30),
qty int,
unitprice float,
size varchar (30),
Status varchar(30),
dateOrder datetime,
Subtotal float,
customerType varchar(30)
)

select * from  tblcustomertrans_details
--Changes of tables ends here(07/14/16)

--Added Table (07/16/16)
select * from tblProducts


create table tblDelivery_Supplier
(
DeliveryNo varchar(30)primary key,
OrderID varchar(30) foreign key references tblOrders (OrderID),
Date datetime,
PreparedAndReceivedBy varchar(30)foreign key references tblUser (UserID),
DeliveredBy varchar(30)
)
create table tblDeliveryDetails
(
DeliveryNo varchar(30) foreign key references tblDelivery_Supplier(DeliveryNo),
OrderID varchar (30) foreign key references tblOrders (OrderID),
ProdID varchar (30),
DeliveryDate datetime,
ProductName varchar (30),
Quantity int
)

delete from tblDelivery_Supplier

create table tblDamagesAndReplacements
(
ReplacementNo varchar(30),
TransactionNo varchar (30) foreign key references tblcustomertransaction (transactionid),
DeliveryNo varchar(30) foreign key references tblCustomerDelivery(DeliveryID),
ProductID varchar(30)foreign key references tblStocks(productid),
ProductName varchar(30),
DateDamaged datetime,
QtyOfDamages int
)

INSERT INTO tblUser values ('Admin-0001','Miletec','Miletec','Miletec','admin','admin','Active',null,null,'Administrator')

select * from tblStocks
select * from tblDamagesAndReplacements
--Stored Procedures

create proc sp_fill_productID
as select productid from tblStocks

--Sales Report
create proc sp_SalesReport
@FromDate datetime,
@ToDate datetime
as select transactionid,productid,qty,dateOrder,Subtotal,customerType from tblcustomertrans_details where dateOrder 
between @FromDate and @ToDate
order by dateOrder asc
sp_SalesReport '2016-10-03 08:11:00.360','2016-10-03 08:11:00.360'

--Inventory Report
create proc sp_InventoryReport
@FromDate datetime,
@ToDate datetime
as
select tblStocks.productid,tblStocks.productname,tblStocks.availqty,tblDamagesAndReplacements.QtyOfDamages,
	   tblDeliveryDetails.Quantity,tblCustomerDeliveryDetails.Quantity,tblDelivery_Supplier.Date,tblCustomerDelivery.date
from(tblStocks full join tblDamagesAndReplacements on tblStocks.productid = tblDamagesAndReplacements.ProductID)
full join tblDeliveryDetails on(tblDeliveryDetails.ProdID = tblStocks.productid)
full join tblCustomerDeliveryDetails on(tblCustomerDeliveryDetails.ProdID = tblStocks.productid)
full join tblDelivery_Supplier on(tblDelivery_Supplier.DeliveryNo = tblDeliveryDetails.DeliveryNo)
full join tblCustomerDelivery on(tblCustomerDelivery.DeliveryID = tblCustomerDeliveryDetails.DeliveryNo)

sp_InventoryReport '2016-09-20 09:52:26.690','2016-09-22 00:00:00.000'
--Update User if active or not
create proc sp_update_userActiveorNot
@UserID varchar(30),
@isActive nvarchar(max)
as update tblUser set isactive = @isActive
where UserID = @UserID

--update customer transaction details
create proc sp_updateCusTransDetails
@transactionID varchar(30),
@ProductID varchar(30),
@Status varchar(30)
as update tblcustomertrans_details set Status = @Status
where transactionid = @transactionID and productid = @ProductID


--update customer transactio delivery
create proc sp_update_CustomerDeilveryStatus
@transactionID varchar(30),
@Status varchar(30)
as update tblcustomertransaction set Status = @Status
where transactionid = @transactionID

--view customer transaction details
create proc sp_view_TransactionDetails
@transactionID varchar(30)
as select * from tblcustomertrans_details where transactionid = @transactionID

--counts the number of data stored in the table stocks
create proc sp_generate_ProductID
as select count (*) as count from tblStocks

--auto generate replacement id
create proc sp_generate_DandR_ID
as select count (*) as count from tblDamagesAndReplacements

--insert data in tbl Damage and replacements
create proc sp_insert_DamagesAndReplacement
@ReplacementNo varchar(30),
@TransactionNo varchar (30),
@DeliveryNo varchar(30),
@ProductID varchar(30),
@ProductName varchar(30),
@DateDamaged datetime,
@QtyOfDamages int
as insert into tblDamagesAndReplacements(ReplacementNo,TransactionNo,DeliveryNo,ProductID,ProductName,DateDamaged,QtyOfDamages)
values(@ReplacementNo,@TransactionNo,@DeliveryNo,@ProductID,@ProductName,@DateDamaged,@QtyOfDamages)

--insert a product n table Stocks
create proc sp_insert_productInStocks
@productid varchar(30),
@productname varchar(30),
@availqty int,
@price float,
@Size float,
@Damages int,
@Replacement int
as insert into tblStocks(productid,productname,availqty,price,Size,Damages,Replacement)
values(@productid,@productname,@availqty,@price,@Size,@Damages,@Replacement)

--view all delivered and not delivered items to the customer
create proc sp_view_CustomerDeliveryDetails
@DeliveryNo varchar(30)
as select * from tblCustomerDeliveryDetails  where DeliveryNo = @DeliveryNo

--view all delivered and not delivered items
create proc sp_view_DeliveryDetails
@DeliveryNo varchar(30)
as select ProdID, ProductName,Quantity from tblDeliveryDetails where DeliveryNo = @DeliveryNo

--deletes the table delivery from suppiler if cancelled
create proc sp_delete_DeliverySupplier
@DeliveryNo varchar(30)
as delete from tblDelivery_Supplier where DeliveryNo = @DeliveryNo

--deletes the table customer transaction if cancelled
create proc sp_delete_transaction
@transactionid varchar(30)
as delete from tblcustomertransaction where transactionid = @transactionid


--deletes the table order if the order was cancelled
create proc sp_delete_Order
@OrderID varchar(30)
as delete from tblOrders where OrderID = @OrderID

--deletes the table customer delivery if it was cancelled
create proc sp_delete_CustomerDelivery
@DeliveryNo varchar(30)
as delete from tblCustomerDelivery where DeliveryID = @DeliveryNo



create proc sp_viewCusdelivery
as select * from tblCustomerDelivery

--update table customer delivery
create proc sp_update_DeliveryCustomer
@DeliveryID varchar(30),
@date datetime,
@TimetoDeliver varchar(30)
as update tblCustomerDelivery set date = @date, TimetoDeliver = @TimetoDeliver
where DeliveryID = @DeliveryID

--stored procedure for the table Customer Delivery Details
create proc sp_CustomerDeliveryDetails
@DeliveryNo varchar(30),
@TransactionID varchar (30),
@ProdID varchar (30),
@ProductName varchar (30),
@Quantity int,
@TimeToDeliver varchar(30)
as insert into tblCustomerDeliveryDetails(DeliveryNo,TransactionID,ProdID,ProductName,Quantity,TimeToDeliver)
values(@DeliveryNo,@TransactionID,@ProdID,@ProductName,@Quantity,@TimeToDeliver)

create proc sp_displayCusdetails
as select transactionid, date, customerid,CustomerName from tblcustomertransaction

create proc sp_display_customerDetails
@TransactionId varchar(30)
as select productid,qty,size from tblcustomertrans_details where transactionid = @TransactionId

select * from tblcustomertrans_details

--stored customerdelivery
create proc sp_customerDelivery
@DeliveryID varchar (30),
@transactionid varchar (30),
@date datetime,
@preparedby varchar (30),
@TimetoDeliver varchar(30)
as insert into tblCustomerDelivery (DeliveryID, transactionid, date, preparedby,TimetoDeliver)
values (@DeliveryID, @transactionid, @date, @preparedby,@TimetoDeliver)

create proc sp_getcustdeliveryID
as select count (*) as count from tblCustomerDelivery


create proc sp_update_tblDeliverySupplier
@DeliveryNo varchar(30),
@DeliveredBy varchar(30)
as update tblDelivery_Supplier set DeliveredBy = @DeliveredBy
where DeliveryNo = @DeliveryNo

create proc sp_DeliveryDetails
@DeliveryNo varchar(30),
@OrderID varchar (30),
@ProdID varchar (30),
@DeliveryDate datetime,
@ProductName varchar (30), 
@Quantity int
as insert into tblDeliveryDetails(DeliveryNo,OrderID,ProdID,DeliveryDate,ProductName,Quantity)
values(@DeliveryNo,@OrderID,@ProdID,@DeliveryDate,@ProductName,@Quantity)
 
create proc sp_update_tblOrderDetails
@OrderID varchar(30),
@ProdID Varchar(30),
@Status varchar(50)
as update tblOrderDetails set Status = @Status
where OrderID = @OrderID and ProdID = @ProdID

create proc sp_update_tblOrders
@OrderID varchar(30),
@Status varchar(50)
as update tblOrders set Status = @Status
where OrderID = @OrderID

create proc sp_searchcusttransdetails
@search varchar (30)
as select * from tblcustomertrans_details
where CustomerName like @search + '%'

create proc sp_searchcustdetails
@key varchar (30)
as select * from tblcustomerdetails
where CustomerName like @key + '%'


--for customertransaction details
create proc sp_insertcustomertrans_Details
@transactionid varchar (30),
@productid varchar (30),
@qty int,
@size varchar (30),
@Status varchar(30),
@DateOrdered datetime,
@Subtotal float,
@CustomerType varchar(30)
as insert into tblcustomertrans_details (transactionid, productid, qty, size,Status,dateOrder,Subtotal,customerType)
values (@transactionid, @productid, @qty, @size,@Status,@DateOrdered,@Subtotal,@CustomerType)

--search

--view for customertransactiondetails
create proc sp_view_customertrandetails
as select * from tblcustomertrans_details

--get customertransactionid
create proc sp_getcustomerid
as select count (*) as count from tblcustomertransaction

--get walk-in customertransaction id
create proc sp_displaycustranID
as select count (*) as  count from tblcustomertransaction



--for customertransaction
create proc sp_insertCustomerTrans
@transactionid varchar (30),
@date datetime,
@customerid varchar (30),
@CustomerName varchar(max),
@address varchar (30),
@TotalInstaPayment float,
@Gtotal float,
@Cashrendered float,
@unitprice float,
@change float,
@services varchar (30),
@status varchar (30)
as insert into tblcustomertransaction (transactionid, date,customerid,CustomerName,address,TotalInstallationPayment, Gtotal, Cashrendered,unitprice,change, services, status)
values (@transactionid, @date,@customerid,@CustomerName,@address,@TotalInstaPayment, @Gtotal, @Cashrendered,@unitprice,@change, @services, @status)

select * from tblcustomertransaction

create proc sp_updateStatus
@transactionid varchar (30),
@services varchar (30)
as update tblcustomertransaction
set services = @services
where transactionid = @transactionid

select * from tblcustomertransaction

--search customerdetails
create proc sp_searchcustomerdetails
@search varchar (30)
as select * from tblcustomerdetails
where CustomerName like @search + '%'

--update customer details
create proc sp_updatecustomerdetails
@CustomerID varchar (30),
@CustomerName nvarchar (30),
@Address nvarchar (30),
@Contactnumber1 varchar (20),
@Contactnumber2 varchar (20)
as update tblcustomerdetails
set  CustomerName = @CustomerName, Address = @Address, Contactnumber1 = @Contactnumber1, Contactnumber2 = @Contactnumber2
	where CustomerID = @CustomerID


--for customer details 07-24-16
create proc sp_insert_customerdetails
@UserID varchar (30),
@CustomerID varchar (30),
@CustomerName nvarchar (30),
@Address nvarchar (30),
@Contactnumber1 varchar (20),
@Contactnumber2 varchar (20)
as insert into tblcustomerdetails (UserID, CustomerID, CustomerName, Address, Contactnumber1, Contactnumber2)
values (@UserID, @CustomerID, @CustomerName, @Address, @Contactnumber1, @Contactnumber2)

--view customerdetails 07-24-16
create proc sp_view_customerdetails
as select * from tblcustomerdetails

--delete from customerdetails 07-24-16
create proc sp_deleteCustomerdetails
@CustomerID varchar (30)
as delete from tblcustomerdetails
where CustomerID = @CustomerID

--07-24-16
create proc sp_genCustomerID
as select count (*) as count from tblcustomerdetails

select * from tblUser


--additional codes starts here 07/22/16 (RYAN)
--view order details except
create proc sp_view_OrderDetails
@OrderID varchar(30)
as select ProdID, ProductName, Quantity,Status from tblOrderDetails
where OrderID = @OrderID
--addtional codes ends here

create proc sp_view_remove_prodID
@ProdID varchar(30)
as select ProdID, ProductName, Quantity from tblOrderDetails
where ProdID != ProdID



--view delivery
create proc sp_viewDelivery
as select * from  tblDelivery_Supplier

--reset username and password
create proc sp_resetUserPass
@Username VARCHAR(30)
as update tbluser
set Password = 'Password'
where  Username = @Username


--change password / verifying the username and password
create proc sp_verifyusernamepass
@Username VARCHAR (30),
@Password NVARCHAR (max)
AS SELECt * FROM tblUser WHERE Username=@Username and Password=@Password

create proc sp_verifyPID
@ProductID VARCHAR (30)
AS SELECt * FROM tblOrderDetails WHERE ProdID = @ProductID



--sp for tblDelivery
create proc sp_DeliverySupplier
@DeliveryNo varchar(30),
@OrderID varchar(30),
@Date datetime,
@PreparedAndReceivedBy varchar(30),
@DeliveredBy varchar(30)
as insert into tblDelivery_Supplier (DeliveryNo, OrderID, Date, PreparedAndReceivedBy, DeliveredBy)
values (@DeliveryNo, @OrderID, @Date, @PreparedAndReceivedBy, @DeliveredBy)



create proc sp_GetDeliveryID
AS SELECT count (*) AS Count from tblDelivery_Supplier

--for retreiving the password
create proc sp_Retreivepass
@Username NVARCHAR (30),
@secret_question NVARCHAR (max),
@secret_answer  NVARCHAR(max)
as select * from tblUser where Username = @Username and secret_question = @secret_question AND secret_answer = @secret_answer 


create proc sp_changepass
@Username NVARCHAR (30),
@newpassword NVARCHAR (MAX),
@oldpassword NVARCHAR(MAX)
as
update tblUser
set Password = @newpassword
where Username = @Username and Password = @oldpassword

--Changes of stored proceedures starts here


--Stored proceedures for tblOrderDisplay
create proc sp_OrderDetails
@OrderID varchar (30),
@ProdID varchar (30),
@ProductName varchar (30),
@Quantity int,
@Status varchar(50) 
as insert into tblOrderDetails(OrderID,ProdID,ProductName,Quantity,Status)
values (@OrderID, @ProdID, @ProductName, @Quantity,@Status)

--delete
create proc sp_DeleteOrderDetails
@OrderID varchar(30),
@ProductID varchar(30)
as delete from tblOrderDetails 
where OrderID = @OrderID and ProdID = @ProductID

--sp for products
create proc sp_Products
@SupplierID varchar (30),
@ProductID VARCHAR (30),
@ProductName varchar (30),
@AvailQty int
as insert into tblProducts (SupplierID, ProductID, ProductName, AvailQty)
values (@SupplierID, @ProductID, @ProductName, @AvailQty)


create proc sp_viewproduct
as select * from tblProducts

--sp for order
create proc sp_Order
@OrderID varchar (30),
@SupplierID varchar (30),
@OrderDate datetime,
@OrderBy VARCHAR (30),
@Status varchar(50)
as insert into tblOrders (OrderID, SupplierID, OrderDate, OrderBy,Status)
values (@OrderID, @SupplierID, @OrderDate, @OrderBy,@Status)

--sp viewOrder
create proc sp_vieworder
as select * from tblOrders



--sp for inserting data on supplierdetails
create proc sp_SupplierDetails
@AdminID VARCHAR(30),
@SupplierID varchar (30),
@SupplierName varchar(30),
@Address varchar(30),
@ContactNumber1 int,
@ContactNumber2 int,
@ContactPerson varchar(30)
as insert into tblSupplierDetails (AdminID,SupplierID, SupplierName, Address, ContactNumber1, ContactNumber2, ContactPerson)
values (@AdminID, @SupplierID, @SupplierName, @Address, @ContactNumber1, @ContactNumber2, @ContactPerson)

--sp view for supplierdetails
create proc sp_ViewSupplierDetails
as select * from tblSupplierDetails



--sp generate for supplierID
create proc sp_GetSupplierDetails
AS SELECT count (*) AS Count from tblSupplierDetails


--sp generate for OrderID
create proc sp_GetOrderID
as select count (*) as Count from tblOrders
 select * from tblOrders

--Storage for ADMIN
create proc sp_insert_User
@UserID VARCHAR(30),
@LastName VARCHAR(30),
@FirstName VARCHAR(30),
@MiddleName VARCHAR(30),
@Username NVARCHAR(30),
@Password NVARCHAR(max),
@isactive NVARCHAR(max),
@secret_question NVARCHAR (max),
@secret_answer  NVARCHAR(max),
@Status VARCHAR(30)
as insert into tblUser(UserID,LastName, FirstName, MiddleName,Username,Password,isactive,secret_question,secret_answer,Status)
values(@UserID,@LastName,@FirstName,@MiddleName,@Username,@Password,@isactive,@secret_question,@secret_answer,@Status)

--Generate Admin and Staff
--generates the UserID automatically
create proc sp_Get_User_ID
AS SELECT count (*) AS Count from tblUser

--Verification
--verify username admin and staff
CREATE PROC sp_verify_Username
@username VARCHAR (30)
AS SELECT * FROM tblUser where Username = @Username

--verify if the user is Administrator or Staff
create proc sp_verify_Status
@Status varchar (30)
AS SELECT * FROM tblUser where Status = @Status

--verify username and password(Admin and staff)
create proc sp_verify_usernamepass
@Username VARCHAR (30),
@Password NVARCHAR (max)
AS SELECt * FROM tblUser WHERE Username=@Username and Password=@Password

--user verification(log-in)
CREATE PROC sp_verify_User
@UserID VARCHAR (30)
AS SELECT * FROM tblUser where UserID = @UserID

--Update Profile

--Update User Information
create proc sp_Update_User
@UserID VARCHAR(30),
@Username NVARCHAR(30),
@newpassword NVARCHAR (MAX),
@secret_question NVARCHAR (max),
@secret_answer  NVARCHAR(max)
as update tblUser 
set Username = @Username, Password = @newpassword, secret_question = @secret_question , secret_answer = @secret_answer
where UserID = @UserID 


--Retrieve User's Password
create proc sp_retreive_User_Password
@Username VARCHAR (30),
@secret_question NVARCHAR (MAX),
@secret_answer NVARCHAR (MAX)
AS SELECT * FROM tblUser where Username = @Username AND secret_question = @secret_question AND secret_answer = @secret_answer