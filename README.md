# CinemaManagementPanel
 Onion Architecture alongside MVC was utilized on this project. <br>
 Further Improvements including the transfer to the common language will be made in short time. This choice of language was made purely for an interview. <br>
<br>
Login Page has not yet been implemented.<br>
<br>
<br>
Instructions to Run:<br>
<br>
1- The "ConnectionStrings:" string in appsettings.json may be changed as needed. If changed however, the "XYZ" string within the method GetConnectionString("XYZ") inside Program.cs should also be updated accordingly.<br>
2- A new migration should be made through the Package Manager Console. Active project should of course be the Persistence project. The process is simply to "Add-Migration mig_name", and then "Update-Database".<br>
3- The Films page can be navigated to using the navigation panel on the left.<br>
4- Films can be viewed, added, edited and deleted using the Films page.<br>
<br>
<br>
Known Issues:<br>
<br>
The entity of MovieScreenings currently doesn't bring with it the other entitites it contains. Reason is probably a lack of knowledge on my part that I should be using Eager Loading there.<br>
<br>
<br>
All questions and recommendations are welcome and HIGHLY appreciated! You can reach me through PMs, Mail, LinkedIn or anything you see fit.<br>
<br>
Mail: batuhan22.ozdemir@gmail.com<br>
LinkedIn: linkedin.com/in/batuhanozdemir22<br>
