
/*===================================
     CONFIGURATION TABLES
=====================================
*/
CREATE TABLE BarTypes
(
	BarTypeKey int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_BarTypes Primary Key(BarTypeKey)
);
GO
CREATE TABLE BarPays
(
	BarPayKey int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_BarPays Primary Key(BarPayKey)
);
GO
CREATE TABLE EventTypes
(
	EventTypeKey int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_EventTypes Primary Key(EventTypeKey)
);
GO
CREATE TABLE LeadStatus
(
	LeadStat int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_LeadStat Primary Key(LeadStat)
);
GO
CREATE TABLE LineStatus
(
	LineStat int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_LineStatKey Primary Key(LineStat)
);
GO
CREATE TABLE EventStatus
(
	EventStat int identity(1,1) not null,
	Description varchar(50) not null,
	constraint PK_EventStatus Primary Key(EventStat)
);
GO
CREATE TABLE Services
(
	ServiceKey int identity(1,1) not null,
	Description varchar(50) not null,
	Price decimal(6,2) not null,
	UOM varchar(10) not null,
	constraint PK_Services Primary Key(ServiceKey)
);
GO
CREATE TABLE Linkbacks
(
	LinkKey int identity(1,1) not null,
	Name varchar(50) not null,
	URL varchar(50) null,
	constraint PK_Linkbacks Primary Key(LinkKey)
);
GO
--END OF CONFIGURATION TABLES

/*==========================================
             ENTITIES
============================================
*/
--drop table contacts
CREATE TABLE Contacts
(
	ContactKey int identity(1,1) not null,
	Active smallint not null,
	FullName varchar(100) not null,
	Phone varchar(15) not null,
	Email varchar(100) not null,
	Notes varchar(255) null,
	Created datetime not null, 
	CreatedBy varchar(50) not null,
	Modified datetime not null,
	ModifiedBy varchar(50) not null,
	constraint PK_Contact Primary Key(ContactKey)
);
GO
--drop table leads
CREATE TABLE Leads
(
	LeadKey int identity(1,1) not null,
	LegacyID char(10) null,--Previous EventID, used only for Data Imports
	LeadStat int not null,--FK | 1-New, 2-Call, 3-Proposed, 4-Invoiced, 5-Deposit, 6-Paid, 7-Complete, 8-Cancelled
	EventDate date not null, --FK |Stored as Date only YYYY-MM-DD
	StartTime time not null, -- Stored as time only HH:MM AM/PM
	EventTypeKey int not null, --FK | 1-Anniversary, 2-Birthday, 3-Charity, 4-Christmas, 5-Corporate, 6-Other, 7-Wedding
	BarPayKey int not null, --FK | 1-Open, 2-Ticket, 3-Coin, 4-Cash
	BarTypeKey int not null, --Dry (Non-alcoholic), Standard (Beer, Wine, Spirits), Deluxe (Beer, Wine, Spirits, Cocktails), Full, Custom (His and Hers Cocktails)
	Location varchar(255) not null, --Venue Name or Address
	Guests int not null, --Guest Count
	Theme varchar(255) not null, --Describe the theme or colour palette
	ContactKey int not null, --FK | Foreign Key references Contacts.ContactKey - this is the Primary Contact for the event
	LinkKey int not null, --FK | Referral Choice - Instagram, Facebook, etc.
	Notes varchar(255),
	Created datetime not null, 
	CreatedBy varchar(50) not null,
	Modified datetime not null,
	ModifiedBy varchar(50) not null,
	constraint PK_Leads primary key(LeadKey),
	constraint FK_LeadStatus foreign key(LeadStat) references LeadStatus(LeadStat),
	constraint FK_EventTypeKey foreign key(EventTypeKey) references EventTypes(EventTypeKey),
	constraint FK_BarPays foreign key(BarPayKey) references BarPays(BarPayKey),
	constraint FK_BarTypes foreign key(BarTypeKey) references BarTypes(BarTypeKey),
	constraint FK_Contacts foreign key(ContactKey) references Contacts(ContactKey),
	constraint FK_Linkbacks foreign key(LinkKey) references Linkbacks(LinkKey),
); 
GO
CREATE TABLE Events
(
	EventKey int identity(1,1) not null,
	EventStat int not null,--Pending until it is converted to an Event > Open until it is converted to an Invoice> Closed
	ContactKey int not null, --FK | Contact
	Reminder date not null, --Event Date - 14 Days
	BarOpen time null, --Time HH:MM PM
	BarClose time null, --Time HH: PM
	Hours decimal(2,1) not null, --##.#
	StaffCount int not null, 
	Notes varchar(255) null,
	Subtotal decimal(8,2) not null,--Inserted based on Total Price of all EventDetails Lines. Staff Services should be * Staff Count * Hours
	GST decimal(8,2) not null, --Calculated as Subtotal *.05 before inserting
	Gratuity decimal (3,2) not null, -- Calulated as Subtotal * .18 before inserting
	Total decimal(8,2) not null, -- Calculated as Subtotal+GST+Gratuity before inserting
	constraint PK_Events primary key(EventKey),
	constraint FK_EventStatus foreign key(EventStat) references EventStatus(EventStat),
	constraint FK_ContactKey foreign key(ContactKey) references Contacts(ContactKey)
);
GO

/*EVENTDETAILS
* Holds the multiple Services selected by the Customer, including their price
* All Lines are set to pending until the Proposal is accepted by the Customer
* spGenerateProposal updates Lead from Call to Proposal
* spAcceptProposal converts the Lead to Closed, and creates a new Event
* Event Detail Lines are updated from Pending to Open
*/
CREATE TABLE EventDetails
(	
	LineKey int identity(1,1) not null,--Event Details Line Primary Key
	LeadKey int not null, --FK | to the Lead before it is converted to an Event
	EventKey int null, --FK | to separate Event table that gets created when a Lead is converted to an Event
	LineStat int not null,--FK | 1-Pending until it is converted to an 2-Event > 3-Open until it is converted to an 4-Invoice> Closed
	ServiceKey int null,--FK | to Services.ServiceKey
	Description varchar(50) null, --Autofilled with Services.Description
	Price decimal(8,2) not null, --Can be overridden by the Salesperson before converting a lead to an event
	constraint PK_LineKey primary key(LineKey),
	constraint FK_LeadKey foreign key(LeadKey) references Leads(LeadKey),
	constraint FK_LineStatus foreign key(LineStat) references LineStatus(LineStat),
	constraint FK_Services foreign key(ServiceKey) references Services(ServiceKey)
);
GO
