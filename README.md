#Set Up Local Database
1. Check if LocalDB is Installed: run ` sqllocaldb info` in terminal. 
3. If it is installed you should get some kind of output, if not please [install it.](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)
4. Check if you have SQL Server Management Studio (SSMS) downloaded, if not download [here.](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16#download-ssms)
5. In Visual Studio go to view -> server exploerer and click. 
   ![image](https://github.com/user-attachments/assets/c8f410bf-71bb-476f-859b-bdb2b704416a)
6. Add a new connection to the Data Connections.
   ![image](https://github.com/user-attachments/assets/de74eed9-8a55-444c-8477-1fe848783980)
7. Give `(localdb)\MSSQLLocalDB` as the server and name the database sydneys_strung_creations_db.
8. Now when you run the code the connection string should work locally.... I think... message me if you're having issues. 
