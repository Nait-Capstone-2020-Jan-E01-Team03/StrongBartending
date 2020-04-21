
/*=========================================
CONFIGURATION DATA
===========================================*/
--BARTYPES
INSERT INTO BarTypes(Description)
VALUES ('Dry - Non-Alcoholic'),('Standard - Beer, Wine, Spirits '),('Deluxe - Beer, Wine, Spirits, Cocktails'),('Custom - Deluxe plus His and Hers Cocktails')
--BAR PAYS
INSERT INTO BarPays(Description)
VALUES ('Open'),('Ticket'),('Coin'),('Cash'),('Full')
--EVENT TYPES
INSERT INTO EventTypes(Description) 
VALUES ('Anniversary'),('Birthday'),('Charity'),('Christmas'),('Corporate'),('Other'),('Wedding'); 
--SERVICES 
INSERT INTO Services(Description,Price,UOM) 
VALUES ('Bartenders',20.00,'hr'),('Mixology',150.00,'event'),('Photobooth',150.00,'each'),('Other',0.00,'each'),('Cocktails',50.00,'each'), ('Servers',20.00,'hr')
--LINKBACKS (REFERRAL SOURCES)
INSERT INTO Linkbacks(Name,URL) 
VALUES  ('Facebook','facebook.com/strongbartending'),('Instagram','instagram.com/strongbartending'),('Wedding Wire','weddingwire.com/strongbartending')
--LEADSTATUS
INSERT INTO LeadStatus(Description)
VALUES ('New'),('Call'),('Proposal'),('Complete'),('Invoice'),('Deposit'),('Closed'),('Cancelled'); 
--LINESTATUS
INSERT INTO LineStatus(Description)
VALUES ('Pending'),('Open'),('Invoiced'),('Complete');
--EVENTSTATUS
INSERT INTO EventStatus(Description)
VALUES ('Open'),('Scheduled'),('Complete')
/*=======================================
ENTITY DATA
=========================================*/
--CONTACTS
INSERT INTO Contacts(Active,FullName,Phone,Email,Notes,Created,CreatedBy,Modified,ModifiedBy) VALUES
(1,'Connor McDavid','7787664276','mcjesus@oilers.net','Her is getting married',GetDate(),'mark.garner@live.ca',GetDate(),'mark.garner@live.ca'),
(1,'Leon Draisaitl','7787664276','neonleon@oilers.net','He is planning the bachelor party.',GetDate(),'mark.garner@live.ca',GetDate(),'mark.garner@live.ca'),
(1,'Jesse Puljarvi','7787664276','poolparty@oilers.net','He is the ring-bearer',GetDate(),'mark.garner@live.ca',GetDate(),'mark.garner@live.ca'),
(1,'Chris Strong','7787664276','chris@strongcrm.com','CEO',GetDate(),'mark.garner@live.ca',GetDate(),'mark.garner@live.ca'),
(2,'Slippery Sean','7787664276','slipperysean@strongcrm.com','He is a shady businessman',GetDate(),'mark.garner@live.ca',GetDate(),'mark.garner@live.ca')


--LEADS - All Leads with a status of 1 (NEW) to demonstrate processing stored procedures 
INSERT INTO Leads(LegacyID,LeadStat,EventDate,StartTime,EventTypeKey,BarPayKey,BarTypeKey,Location,Guests,Theme,ContactKey,LinkKey,Created,CreatedBy,Modified,ModifiedBy) VALUES
('547',1,'2020-04-01','10:00',7,3,2,'Lily Lakes',100,'Tiffany Blue and Pearl',1,1,getdate(),'mark.garner@live.ca',getdate(),'mark.garner@live.ca'),
('8009',1,'2020-05-01','09:00',7,3,3,'Edmonton Convention Center',200,'Empress Purple',4,1,getdate(),'mark.garner@live.ca',getdate(),'mark.garner@live.ca'),
('SB-101',1,'2020-04-01','10:00',7,4,3,'Whitewood Farms',75,'Backstabbing Black',5,1,getdate(),'mark.garner@live.ca',getdate(),'mark.garner@live.ca')

--EVENT DETAILS
/* NO EVENTKEY IS INSERTED UNTIL THE LEAD HAS BEEN CONVERTED TO EVENT
*/
INSERT INTO EventDetails(LeadKey,LineStat,ServiceKey,Description,Price) VALUES
(4,1,1,'Bartenders',20.00),--Lily Lakes (New),Pending,Bartenders,20.00
(4,1,1,'Cocktails', 50.00),--Lily Lakes (New),Pending,Cocktails,50.00
(5,1,1,'Servers',20.00),--ECC (New),Pending,Bartenders,20.00
(6,1,1,'Bartenders', 50.00)--WWF (New),Pending,Cocktails,50.00

--EVENTS
--EVENTS ARE INSERTED BY THE spAcceptProposal PROCEDURE
INSERT INTO Events(EventStat,ContactKey,Reminder,BarOpen,BarClose,Hours,StaffCount,Notes,Subtotal,GST,Gratuity,Total) VALUES
(1,1,'2020-03-14','09:30 AM','04:30 PM', 8, 2, 'Quick-insert event to show data on the Proposal',90.00,4.50,16.20,110.70)