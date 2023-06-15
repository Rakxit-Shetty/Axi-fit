#  Axi-fit

## Chapter 1
SYNOPSIS
1.1 

### Introduction: 
Gym Management System basically is a user-friendly data management project. The project interface will focus on managing various information and performing basic operations such as adding, managing supplements, equipment’s and members.

#### 1.2 Objective of the project: 
Maintaining data of gym member, equipment’s and supplements available.

#### 1.3 Project category: 
RDBMS (Relational Database Management Systems)
Relational Database Management System is a type of Database Management 
System that stores data in the form of related tables. Relational databases are powerful 
Because they require few assumptions about how data is related or how it will be 
Extracted from the database. An important feature of relational systems is that a single 
Database can be spread across several tables.

#### 1.4 Hardware Requirements: 
•	40 GB hard disk and above.
•	1 GB RAM and above.
•	Peripheral devices.

#### 1.5 Software Requirements: 
•	Microsoft Visual Studio 2008.
•	Microsoft SQL server 2008.
•	Operating system: Windows Xp and above.
•	Processer: Intel core i3 and above.
Languages to be used:
Front End: Visual Basic.net.
Back End: SQL (Structured Query Language)
Methodology:
Gym Management System is an application program. Here the admin having an account (root-user) can perform various query on the database and access information about the members, equipments and supplements.
Admin can add, remove or alter the information of a member, equipment’s and supplements in the system.
#### 1.7 Module Description:
	Admin module:
•	Login:
Admin can log in using admin login via user Id and password. 

•	Equipments:
Admin can view the data about the equipment currently available and they can add new equipment, or remove existing equipment in the gym as they prefer.

•	Supplements:
Admin can view the data about the supplement currently available which is categorized as weight gain and weight-loss supplements, they can add new supplement or remove supplement as they prefer.

•	Member data:
Admin can view the data about the member currently available and they can register new member, or remove existing member in the gym as they prefer.

#### 1.8 Limitations:
●	Offline reports cannot be generated due to batch mode execution.
●	User cannot access their data on their own.

#### 1.9 Conclusion:
Gym management system software will reduce manual recording work and will provide easy way to manage the data for admin and provides easy interaction in the gym.

#### 1.10 Future Scope:
●	Monitoring individual member’s progress can be implemented.

 
## Chapter-2
### SOFTWAREREQUIREMENT AND SPECIFICATION

#### 2.1 Introduction:
A Software Requirement Specification (SRS) is a comprehensive description of the intended purpose and environment for software under development. The SRS fully describes what the software will do and how it will be expected to perform. An SRS minimizes the time and effort required by developer to achieve desired goals and also minimize the development cost. A good SRS defines how an application will interact with system hardware, other programs and human users in a wide variety of real-world situation.
#### 2.1.1 Purpose
The purpose of SRS document is to provide detailed overview of our software product, its parameter and goals. The document describes the user interface, hardware and software requirements. Gym management system allows admin to browse through and retain information. It provides friendly environment to maintain the details of supplements, equipments and members.

#### 2.1.2 Scope
The document specifies requirements of the system. The validation of the process is done through software requirement specification. Gym management system is comprehensive system where admin can go through each and every supplements, equipments and members available in the system and manage them. If there are any changes in the software in future, the changes are done through SRS.

#### 2.1.3 Definitions, Acronyms and Abbreviations
DFD -Data Flow Diagram
CFD-Context Flow Diagram
SRS-Software Requirement Specification
ER-Entity Relationship
SQL-Structured Query Language
RPU-Rate per unit
DOJ-Date of join
DOB-Date of birth
OS-Operating System
RAM-Random Access Memory
GUI-Graphical User Interface

 
#### 2.1.5 Overview
Rest of this document contains General Description, General Constraints specific requirements etc.
➢designing a system for admin in the gym, to maintain data.
➢It stores the information of the members, supplements and equipments, admin can easily access these information.

### 2.2 Language and Tools:
#### 2.2.1 Frontend
VB.net 2015, it’s an open source .net framework designed for development. Visual Basic is often used in conjunction with the Windows Forms GUI library to make desktop apps for Windows. Programming for Windows Forms with Visual Basic involves dragging and dropping controls on a form using a GUI designer and writing corresponding code for each control.

#### 2.2.2 Backend
SQL Server 2008SQL (Structured Query Language) is a standardized programming language used for managing relational databases and performing various operations on the data in them. SQL is regularly used by database administrators, as well as by developers writing data integration scripts and analyst looking to set up and run analytical queries.

### 2.3 Overall Description:
#### 2.3.1 Product Perspective
Gym management system is a replacement for the ordinary Gym data management way which depend on paper work for recording information through the mode of computer. 
#### 2.3.2 Product Function
➢The main function of Gym management system is to store, retrieve and maintain the information efficiently.
➢The system eases the work of admin.

#### 2.3.3 User Characteristics
➢User need to have the basic computer knowledge to operate the system.
The types of users and their characteristics
❖Admin
▪Admin is mainly responsible for adding and modifying members, supplements and equipments.
▪Can provide registration of member.
▪Add, remove and can edit the various supplements and equipments.
▪Members, supplements and equipments information can be easily viewed by admin.
▪Can get the information of any members.
▪Admin is allowed to add, remove and update details.

 
#### 2.3.4 General Constraints
➢user id and password is used for identification of admin.
➢Users must be educated enough to use the system.

#### 2.3.5 Hardware Requirements
•Any standard keyboard.
•Any standard mouse.
•Any standard CD-ROM.
•Hard disk drive with at least 10GB space for storing data

#### 2.3.6 Assumption and Dependencies
➢User will be having a valid username and password to access the software.
➢Admin should be careful in deleting or modifying data knowingly or unknowingly which will lead to inconsistency of the database.

### 2.4 Specific Requirements
#### 2.4.1 External Interface Requirements
The interface should be simple and easy to understand and use. It should always be interactive interface. It should prompt the user and administrator for proper input criteria.

#### 2.4.1.1 User Interface
The quality of the user interface is friendly to the end users. Various controls are used in activity which can be used by the system for accepting user input and saving the same in database. The controls are:
▪Textbox
▪Buttons
▪Dropdown list
▪Radio button list
▪Checkbox
▪Link button
▪Labels
▪Grid view

#### 2.4.1.2 Hardware Interface
➢RAM				: 2GB
➢Input device		: Keyboard, Mouse
➢Output device		: Monitor, Printer
➢Hard Disk			: 10GB or more
➢Processor			: Intel CORE i3

#### 2.4.1.3 Software Interface
➢Operating System	: Windows XP and above
➢Frontend 			: Visual Studio2015
➢Backend 			: SQL Server2008
➢Browser			: Google chrome, Mozilla Firefox

#### 2.4.1.4 Communication Interface
➢A system is a must.
➢Since this is a system application, basic hardware requirement is needed.

### 2.4.2 Functional Requirements
#### 2.4.2.1 Module Description

Module Name	Login
Description	Admin login to their account by using their ID and password.
Data Inputs	•user ID
•Password
Processing	•User ID and password are checked with the database table.
•If the Email and password is invalid then they will get an error message else they will login to their account.


Admin Sub Modules
Module Name	Members
Description	Admin can add, remove and modify the member data in the system.
Data Inputs	•MemberID
•Name
•Age
•DOJ
•Address
•Phone no
•DOB
•feesId
•Status
Processing	•Admin will add all the above details of members and store it in the database table.
•Admin can also remove and modify the member information.

Module Name	Equipments
Description	Admin can add, remove and modify the equipments data in the system.
Data Inputs	•ItemID
•ItemName
•DOP
•DOB
•Status
•Qty
•RPU
Processing	•Admin will add all the above details of store it in the database table.
•Admin can also remove and modify the equipments information.

Module Name	Supplements
Description	Admin can add, remove and modify the supplements data in the system.
Data Inputs	•ItemID
•ItemName
•DOP
•DOB
•Status
•Qty
•RPU
Processing	•Admin will add all the above details of store it in the database table.
•Admin can also remove and modify the supplements information.

Module Name	Supplier Details
Description	Admin maintains vendor details.
Data Inputs	•SupID
•SupName
•Address
•Mail
•Phn
•status
Processing	Admin can add, edit and remove the supplier information.

Module Name	Item Purchase
Description	Admin maintains purchased information.
Data Inputs	•itemName
•SupID	
•Quantity
•RPU
Processing	Admin can add, edit and remove the information.

Module Name	View
Description	This module allows the admin to go through the supplements and equipments and members.
Data Inputs	•MemberID
•ItemID
•SupID
Processing	Supplements and equipments and members are browsed by specifying above details.




#### 2.4.3 Performance Requirements
This part of an SRS specifies the performance constraints on the software system. All the requirements related to the performance characteristics of the system must be clearly specified. There are two types of performance requirements:
➢Static Requirement
➢Dynamic Requirement
▪Static Requirements: Static Requirements are those that do not impose constraints on the execution characteristics of the system. These includes requirements like the number of terminals to be supported, the number of simultaneous users to be supported and the number of files that system has to produce and their sizes.
▪Dynamic Requirements: Dynamic Requirements specify constraints on the execution behavior of the system, this typically include response time and throughput constraint on the system.

### 2.5 Design Constraints
The system must be designed in such a way that will be easy to use 
➢Security: Security of the system is maintained by giving access to only authenticated users. Authentication of user is achieved through his/her username and password.
➢Reliability: The system is reliable for giving correct results to the user. If the system does not find details for the requested information then the appropriate message displayed to the user.
➢Portability: The system is portable to any windows configured machine having 4GB RAM for better performance.
➢Reusability: The system modules are usable for next development process. With use of the system, developer can enhance it with other improved or additional features.
➢Interoperability: Some system may be optimized to solve specified set of problems. An automated system should be flexible enough.
 
## Chapter-3
### SYSTEM DESIGN DOCUMENT
#### 3.1 Introduction
 Design is essentially bridge between the requirement specification and the final solution for specifying the requirements. This is the first step from the problem domain towards solution domain. At the first level the focus is on deciding which modules are needed for the system, this specification of these modules should be interconnected. This is called top level design. In second level, internal level of the module or how the specification of the modules is satisfied and decided. This constitutes detailed design. The detailed design essentially expands the system design to contain more detail description of the processing login and data structure.

#### 3.2 Design Objective 
System design is to deliver the requirement as specified in the feasibility report. The main objectives of the design are 
➢ Practically 
➢ Efficiency 
➢ Flexibility 
➢ Completeness 
➢ Security
➢ Traceability
 System design contains Logical design and Physical design: 
Logical designing describes the structure and characteristics or features like output, input, files, database and the procedure. 
The physical design follows the logical design, actual software and working system. There will be constraints like hardware, software, cost, time and interfaces. 
Structure design is a data flow methodology. The graphical representation of the dataflow communication and defining the modules and their relationship with each is known as structured chart. This method decomposes and modularized the system so that the complexity and manageability will come down. Thus, reducing the initiative reasoning and promotes the maintainable provable system, system specification is a document, which will have a result of system design process, it serves as a blue print for the project development maintenance. 

#### 3.3 Functional and decomposition 
Input: Objectives of input design are 
➢ Avoiding delay in follow up 
➢ Avoiding errors in data entry 
➢ Avoiding extra steps 
➢keeping the process simple 
#### 3.4 Description of the program
Gym Management System:
The main purpose of Gym Management System is to maintain the overall work done in the gym, gym management system replace the ordinary gym management system which depends on paper work for recording data of the user, equipment and supplements.
#### 3.4.1 Context Flow Diagram (CFD)
 Content flow diagram is top level data flow diagram. It contains only one process node generate the functions of the entire system in relationship to external entities. In Context Flow Diagram the entire system is treated as a single process and all its inputs, outputs, sinks and sources identified as shown below 

 
#### 3.4.2 Data Flow Diagram (DFD) 
The DFD shows the flow of data through the system. It views the system as the function that transforms the input into desired outputs. It helps to understand IMS efficiently. The processes are shown by the named circles and the flows are represented by named arrows entering and leaving the processes. Rectangle represents the source sink. All external files are shown as labeled straight lines.


Data flow diagram notation:
Notation	Description

The circle represents the process or transform that is applied to data or control and changes it in some way

A rectangle represents the source sink, that is a system element or another system that produces the information by the software or receives information produced by the software

An arrow represents one or more data items or data objects.

The arrows one data store or stored information that is used by the software (File/Database)

The database is to store the data


 

Level 1: DFD for admin:



 

Level2: Admin DFD for User Management:
 
 

Level 2: Admin DFD for Equipment management:
 
 

Level 2: Admin DFD for Supplement management:
 

 

Level 2: Admin DFD for Supplier management:
 

 
## Chapter-4
### DATABASE DESIGN

 #### 4.1 Introduction
 Database design is the first step of the design activities. In any database based project data integrity constraints are important. The table used must be fully normalized and suitable constraints must be added to attributes. Primary key, foreign key and null constraints must be specified whenever required. Suitable type of must be set up between the entities. 


#### 4.2 Database Schema
 

#### 4.3 Entity Relationship Diagram
 An Entity Relationship (ER) diagram is a specialized graphics that illustrates the interrelation between entities in the database. ER diagram often use symbols to represent the three different types of information. Boxes are commonly used to represent relationships and ovals are used to represent.
Notation	Description
 
An entity is a real-world item or concept that exists on its own. The set of all possible values for an entity type.

 
An attribute of an entity is a particular property that describes the entity. The set of all possible values of an attributes is the attributes domain.
 
Key attributes :
 An attributes or set of attributes that uniquely identifies a particular entity is a key.
 
Many-to-One relationship
 
One-to-One relationship
 
 Many-to-Many relationship
 
Weak entity
 
Relationship type
 
Total participation of E2 in R

 
 Cardinality ratio 1:N for E1:E2 in R
 
Identifying relationship type


 
Entity-Relationship Diagram 
  
Entity-Attribute for AdminTable
 

Entity-Attribute for MemberTable
 
 
Entity-Attribute for SupplementTable
 
Entity-Attribute for SupplierTable

 
 
Entity-Attribute for item

 

Entity-Attribute for feeTable
 
 
Entity-Attribute for EquiTable
 



#### 4.4 Tables Name
Table: Equipment
Column	Data Type	Size	Constraints	Description
ItemID	nvarchar	50	Foreign Key	Item ID
Name	varchar	50	Not Null	Equipment Name
quantity	nvarchar	50	Not Null	Quantity
rpu	nvarchar	50	Not Null	Rate per unit
Status	nvarchar	50	Not Null	Status

Tbl:Fee
Column	Data Type	Size	Constraints	Description
FeeID	nvarchar	50	Primary Key	Item ID
Timmings	varchar	50	Not Null	Equipment Name
Cost	nvarchar	50	Not Null	Quantity

Tbl:item
Column	Data Type	Size	Constraints	Description
ItemID	nvarchar	50	Primey Key	Item ID
UserID	nvarchar	50	Not Null	User ID
SupplierID	nvarchar	50	Not Null	Supplier ID
DOP	nvarchar	50	Not Null	Date of purchase
Type	nvarchar	50	Not Null	Type of item

Tbl:mem
Column	Data Type	Size	Constraints	Description
MemberID	nvarchar	50	Primary Key	Member ID
Name	nvarchar	50	Not Null	Name
Age	int		Not Null	Age
Address	nvarchar	50	Not Null	Address
PhoneNumber	bigint		Not Null	Phone Number
FeeID	nvarchar	50	Foreign key	Fee ID
DOB	nvarchar	50	Not Null	Date of Birth
DOJ	nvarchar	50	Not Null	Date of join
Status	nvarchar	50	Not Null	Status

Tbl:suplim
Column	Data Type	Size	Constraints	Description
ItemID	nvarchar	50	Foreign Key	Item ID
Name	nvarchar	50	Not Null	Equipment Name
Type	nvarchar	50	Not Null	Supplement type
qty	nvarchar	50	Not Null	Quantity
Rpu	nvarchar	50	Not Null	Rate per unit
ExpireDate	nvarchar	50	Not Null	Expire Date
Status	nvarchar	50	Not Null	Status


Table: Supplier
Column	Data Type	Size	Constraints	Description
SupplierID	nvarchar	50	Primary Key	Supplier ID
Name	nvarchar	50	Not Null	Suppiler Name
Adress	nvarchar	50	Not Null	Quantity
Email	nvarchar	50	Not Null	Rate per unit
PhoneNumber	nvarchar	50	Not Null	Phone Number
Status	nvarchar	50	Not Null	Status


Tbl:AdminTable
Column	Data Type	Size	Constraints	Description
UserID	nvarchar	50	Primary Key	USer ID
Name	nvarchar	50	Not Null	Name
Age	int		Not Null	Age
Gender	nvarchar	50	Not Null	Gender
Address	nvarchar	50	Not Null	Address
PhoneNumber	bigint		Not Null	Phone Number
Email	nvarchar	50	Not Null	Email
DOB	nvarchar	50	Not Null	Date of Birth
Password	nvarchar	50	Not Null	Password

 
## Chapter-5
### DETAILED DESIGN
 
#### 5.1 Introduction:
 Detailed design starts after the system design phase is completed. The goal of this is to develop the internal logic of modules identified during system design. In a design document, a more detailed specification is given by explaining in natural language what a module is supposed to do. The design level in which the internal design of the modules or how the specification of the module is specified is decided and often called detailed or logic design. Detailed design essentially expands the system design to contain a more detailed description of the processing logic and data structure is sufficiently complete for coding. Detailed design is the extension of the system. 

#### 5.2 Structure Chart:
Structure design methodology is used to convert DFD’s into structure chart, and aims to control the influence the structure of the final program. Final program implemented will have a nice hierarchical structure with functional cohesive module and has few interconnections between of modules as possible.

#### 5.2.1 Factoring level of Admin module:
 
 
Description of the Above:
a.e		-		add equipment
r.e		-		remove equipment
v.e		-		view equipment
e.e		-		edit equipment
a.s		-		add equipment 
r.s		-		remove supplements
e.s		-		edit supplements
v.s		-		view supplements
a.m		-		add member
r.m		-		remove member
e.m		-		edit member
v.m		-		View member
e.p		-		Edit profile
v.p		-		view profile


#### 5.3 Structured English:
Structured English is the use of English language with the syntax of structured programming to communicate the design of a computer program to non-technical users by breaking it down into logical steps using straightforward English words. Structured English gives aims to get the benefits of both programming logic and natural language. Program logic helps to attain precision, natural language helps with familiarity of the spoken word. It is the basis of some programming languages such as SQL (Structured Query Language) for used by people who have need for interaction with a large database but who are not trained programmers.

#### 5.3.1 Login
If the logged in person is admin then the admin menu page is displayed. If the logged in person is manager or the employee then their respective menu page is displayed.
Algorithm: 
Input: Admin UserID and password at login. 
Begin:
If login is Admin Then 
Redirect to the Admin menu form module 
Else 
Display message “invalid UserID and password” 
End If 
End 
Output: Displays menu form
Add 
Add button allows admin to add information.
Algorithm:
Input: Enter the valid information 
Begin If button selected is Add Then 
Add valid information to database 
Else 
Message “Enter all values” 
End If 
End 
Output: A valid record is inserted to the table.

Remove 
Remove button allows admin to remove the record from the database. 
Algorithm: 
Input: Data to be removed. 
Begin 
If button selected is Removed Then 
Remove the record of selected ID 
End If 
End 
Output: Selected record is removed from the database.

Update 
Update button allows admin to edit information which is present in the database.
Algorithm: 
Input: The selected data shown in the panel along with edit button in the end.
Begin 
If button selected is Edit Then 
Edit information of selected ID 
End If 
End 
Output:	 Edited information is updated.


 
#### 5.4.1 Hierarchy of Admin Module 
 
 
## Chapter-6
### TESTING
 #### 6.1 Introduction: 
Testing is the phase where errors from the earlier phase also must be tested. It is the process of examining something with intension of finding the errors. Testing a program consists of providing the program with the set of test inputs and observing if the program behaves as expected. 

#### 6.2 Levels of Testing: 
Before the implementation of the system, testing has been carried out thoroughly to eliminate any bugs, which may be present. The test has been conducted based on some levels of testing.
 • Unit testing 
• Integration testing
• System testing 

#### 6.2.1 Unit testing
Testing at the unit level is very much essential because the error is accurate. Unit testing is testing of different units or modules of a system is isolation. Testing is done to check whether each module in the software works properly so that is gives desired outputs to the given inputs.
Login Form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Click Login button without selecting the username and password	Display message in required field validator as “enter both field”	Display message in required field validator as “enter both field”	Pass
2	Click Login button with invalid username and password	Display message “please check user ID and password”	Display message “please check user ID and password”	Pass
3	Click Login button without entering the password	Display message in required field validator as “enter both field”	Display message in required field validator as “enter both field”	Pass
4	Click Login button without entering the username	Display message in required field validator as “enter both field”	Display message in required field validator as “enter both field”	Pass
5	Click on Login button	Redirected to a  form depending upon username and password	Redirected to a form depending upon username and password	Pass

 
Registration Form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox Name: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
2	Textbox Age: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
3	Textbox Address: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
4	Textbox Phone: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
5	Textbox Email: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
6	Textbox Password: If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass

Forgot password form
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox userID: If not entered	Display message “enter the  fields”	Display message “enter  the  fields”	Pass
2	Textbox userID: If entered wrong	Display message “invalid ID”	Display message “invalid ID”	Pass
3	Textbox address: If not entered	Display message “please enter the values in the  fields”	Display message “please enter the values in the  fields”	Pass
4	Textbox Phone: If not entered	Display message “please enter the values in the  fields”	Display message “please enter the values in the  fields”	Pass
5	Textbox password: If not entered	Display message “please enter the values in the  password section”	Display message “please enter the values in the  password section”	Pass
6	Textbox Re-Password: If not Matched	Display message “password does not match, try again”	Display message “password does not match, try again”	Pass
7	Textbox Password: If  Matched	Display message “password updated successfully”	Display message “password updated successfully”	pass

 
Add member form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the  fields”	Display message “enter  the  fields”	Pass
2	Textbox memberID: if already exists	Display message “member ID already exists”	Display message “member ID already exists”	Pass
3	Textbox date of birth: If under age	Display message “member must be 15+”	Display message “member must be 15+”	Pass
4	Click on submit button with valid data	Display message “added successfully”	Display message “added successfully”	Pass

Update member form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the  valid ID”	Display message “enter the  valid ID”	Pass
2	Textbox memberID: if entered wrong	Display message “invalid member ID”	Display message “invalid member ID”	Pass
3	Click on submit button with valid data	Display message “updated successfully”	Display message “updated successfully”	Pass

Delete member form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the  valid ID”	Display message “enter the  member ID”	Pass
2	Textbox memberID: if entered wrong	Display message “invalid member ID”	Display message “invalid member ID”	Pass
3	Click on submit button with valid data	Display message “deleted successfully”	Display message “deleted successfully”	Pass

 
Add supplier form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the  fields”	Display message “enter  the  fields”	Pass
2	Textbox supplierID: if already exists	Display message “supplier ID already exists”	Display message “supplier ID already exists”	Pass
3	Click on submit button with valid data	Display message “added successfully”	Display message “added successfully”	Pass

Delete supplier form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the  valid supplier ID”	Display message “enter the  valid supplier ID”	Pass
2	Textbox memberID: if entered wrong	Display message “invalid supplier ID”	Display message “invalid supplier ID”	Pass
3	Click on submit button with valid data	Display message “deleted successfully”	Display message “deleted successfully”	Pass

Add Equipments form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
2	Textbox item ID: if already exists	Display message “sorry, you can’t use this ItemID”	Display message “sorry, you can’t use this ItemID”	Pass
3	Click on submit button with valid data	Display message “added successfully”	Display message “added successfully”	Pass

Update Equipments form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter Item ID”	Display message “enter Item ID”	Pass
2	Textbox Item ID: if entered wrong	Display message “invalid ID”	Display message “invalid ID”	Pass
3	Click on submit button with valid data	Display message “updated successfully”	Display message “updated successfully”	Pass

Delete Equipments form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the Item ID”	Display message “enter the Item ID”	Pass
2	Textbox ItemID: if entered wrong	Display message “invalid Item ID”	Display message “invalid Item ID”	Pass
3	Click on submit button with valid data	Display message “deleted successfully”	Display message “deleted successfully”	Pass

Add Supplements form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter all the  fields”	Display message “enter all the  fields”	Pass
2	Textbox item ID: if already exists	Display message “sorry, you can’t use this ItemID”	Display message “sorry, you can’t use this ItemID”	Pass
3	Textbox expire date: If  less than today	Display message “expired supplements can’t be added"	Display message “expired supplements can’t be added"	pass
4	Click on submit button with valid data	Display message “added successfully”	Display message “added successfully”	Pass

Update Supplements form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter Item ID”	Display message “enter Item ID”	Pass
2	Textbox Item ID: if entered wrong	Display message “invalid ID”	Display message “invalid ID”	Pass
3	Click on submit button with valid data	Display message “updated successfully”	Display message “updated successfully”	Pass

 
Delete Supplements form:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Textbox : If not entered	Display message “enter the Item ID”	Display message “enter the Item ID”	Pass
2	Textbox ItemID: if entered wrong	Display message “invalid Item ID”	Display message “invalid Item ID”	Pass
3	Click on submit button with valid data	Display message “deleted successfully”	Display message “deleted successfully”	Pass

6.2.2 Integration Testing
 In the integration testing all the code modules are put together and tested for desired outputs. The modules unit tested are integrated and tested. All the modules are combined in the testing step. The entire program is tested as a whole. 
The integration testing is carried out using integrated test plans prepared in the design phase of the system development as guide. All the errors found in the system are corrected for the next testing steps. The modules which are tested show expected results. 

General Test Cases for Add button:
Test Case ID	Description 	Expected Result	Actual Result	Remark
1	Add button	Adds the information in database if all unit testing is satisfied else display proper error message.	Display message “added successfully”	Pass

General Test Cases for Update button:
Test case ID	Description	Expected Result	Actual Result	Remark
1	Update button	Edit and Update the information in database if all unit testing is satisfied else display proper error message.	Display message “ updated successfully”	Pass

General Test Cases for Delete button:
Test Case ID	Description	Expected Result	Actual Result	Remark
1	Delete button	Removes the information	Display message “ Deleted successfully”	Pass

 
#### 6.2.3 System Testing and Acceptance Testing
 In the system testing entire system is tested as a whole with all forms, code, modules and class modules. After the integration testing the whole system is rested in the different environments and it is found that the system has performed well without giving any runtime error. Hence after the testing is concluded that the system will work fine in all environments.

#### 6.3 Debugging and code improvement 
Debugging is the process of correcting the errors traced either in testing phase or by any other way. While testing the codes or modules, if errors are found, or if found that module generated wrong results, the code concerning for that particular module was corrected by tracing the errors. This process is called debugging by which the standard of code can be improved.
 
## CHAPTER-7
### Screenshots

 


 
 


 
 


 
 


 
## Chapter-8
### USER MANUAL


The project “Gym Management System” is an application which allows admin to add, delete, update and view the system information. This system document store and maintain records of admin and user details with information.
 The user guide, also commonly known as manual, is a technical communication intended to give assistance to people using a particular system. It help admin to maintain their records of items and members. Most user guides contain associated images. 
The user manual of Gym Management System has screenshots of the pages that user has to deal with. It also describes the functions of the pages and buttons available in the pages. This helps the user to understand the software with case and also makes it user friendly. 
The user manual helps the user to use the pages and make use of all the functions available in it in an easier way. 


 
## Chapter-9
### SYSTEM SECURITY

Introduction: 
Security requirements are particularly significant in today’s software developed scenario. The system must be protected from unauthorized intruders who may try to corrupt/steal/misuse the data. The security systems by password authenticates of users, providing different level of access to different people and so on.
Security in Gym Management System:
Only admin can login using a correct user ID and Password to the software. Each user will be having user ID and Password, and these details are stored in a table. Gym Management System application has Admin. Only admin has authority to add, delete and update the users and items.
Gym Management System is more secured because: 
➢ User can change their password. 
➢Unique user ID and password for each of them. 








	







	
 
## Chapter-10
### REPORTS


#### 10.1 Introduction: 
Reports in any software are the final outputs from the system as they provide us the medium to pose our question and get answer. They are the most essential product of any software project. 
10.2 Reports of Gym management system: 
Our system is mainly developed to handle. It has the following report. 
➢ Members Report 
➢ Equipment Report
➢ Supplement Report 
➢ Supplier Report



 
## Chapter-11
### FUTURE SCOPE AND ENHANCEMENT


Everything in the earth goes changing day by day. In the changing world on the basis of requirement the “Gym management system” also needs to changed or enhanced to make it efficient are mentioned here. 
➢ Monitoring details
●	Monitoring individual member’s progress can be implemented.


 
## Chapter-12
### CONCLUSION


Gym management system software will reduce manual recording work and will provide easy way to manage the data for admin and provides easy interaction in the gym.
This can benefit admin and ease the work of physical recording. 
It promises great benefits to the users as it allows easy interaction, provides user friendly interface, and reduces wastage of time. The importance of a good software design was learned during the project. We hope people find this software useful and interesting and developing this software was good experience. 
In present day’s software engineering, the software has to be simple, user friendly and should be able to incorporate any further improvement. The greatest strength of the project is its simplicity which enables an end user to study and use the software.

 



## Chapter-13
### BIBLOGRAPHY

Reference Book:
 • “An Integrated Approach to Software Engineering “. By – Pankaj Jalote
 • “Fundamentals of Database Systems”. By – Ramez Elmasri and Shamkanth B. Nvate. 
Website: 
• WWW.StackOverflow.com 
• WWW.Codeproject.com




