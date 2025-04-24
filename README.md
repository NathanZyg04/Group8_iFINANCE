iFINANCE project by Group 8 

CS_4320 Spring Semester Mizzou
4/24/2025

Contributors:
- Collin Wanta
- Nathan Zygmont
- Tre
- Jack Frater

  Overview

A Personal Finance Management system is a software intended to control the users’ finances,
keeping track of bank accounts, cash, credit cards, and investment accounts. Users record all their deposits
and expenses, and the system generates many reports that help them to monitor their financial health. It
is a versatile and user-friendly software system that makes the principle of double-entry bookkeeping simple
enough to be used by people with very little or no accounting knowledge. The system maintains four
main financial accounting categories, Assets, Liabilities, Income, and Expenses, which, in turn, is classified
as one of the two types: Debit type or Credits type. Financial transactions are classified under these
categories (or user-defined sub-categories under these four categories). This categorization helps allow the
system to prepare a Balance Sheet, a Profit and Loss statement, or a cash flow statement from the financial
data. Typically, the system allows the user to create accounts (called Master Accounts) for each Income,
Expense, asset, and liability account types are used to manage his/her bank accounts, cash, credit cards,
etc. by moving money between them. In addition, the system allows the user to figure out where his/her
money comes from and where it goes.


-- TO RUN THIS APP --

1) Make sure you have SQL Server Express LocalDB installed on your computer
     - To vetify you have this installed run the command " sqllocaldb i "
     - You should see MSSQLLocalDB listed.
      If it’s not listed, you can manually create it with commands 
      'sqllocaldb create MSSQLLocalDB'
      'sqllocaldb start MSSQLLocalDB'

2) This is to ensure that in app.config file that data source=(LocalDB)\MSSQLLocalDB; uses your instance of MSSQLLocalDB
3) Connect to the same instance in SSMS to see the database attached when you run the .exe file and tables updated
4) DOUBLE CHECK that the provided Group8_iFINANCEDB.mdf and _log.ldf files are inside the \Data\ folder where the .exe is, this is required to connect to the database
