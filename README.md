

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
