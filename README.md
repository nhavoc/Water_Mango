# Water_Mango
Remote Water Management System.

This water management system provides a user with the ability to water plants with the help of a button and responses using a background color code that signify the following: 

__RED__: NEEDS WATERING

__LIGHT GREEN__: WATERING DISABLED AS IT WAS WATERED WITHIN THE LAST 30 SECONDS

__YELLOW__: CAN BE WATERED

Plants cannot be watered within 30 seconds of watering, multiple plants can watered as well as single plants. To water multiple plans select the topmost checkbox and click water all plants. To water individual plants press the water plant button next to each plant. 

*TO DEPLOY*: 

-Clone or download the zip file

-Open Visual Studio

-Go to file > open> Project/Solution

-Open PWM.sln

-An SQL connection will be required, hence, go to Server Explorer or click CTRL+ALT+S

-Delete any existing connections

-Right click Data Connection > Add Connection

-Ensure the Data Connection is set to 'Microsoft SQL Server Database File (SqlClient)'

-Name the connection as pwmdb

-Once the connection is created, right click on pwmdb > properties

-Copy the connection string and open solution explorer i.e. CTRL + ALT + L

-Open web config and change the connection string in the file to what was previously copied from pwmdb properties. 

-Finally, go to Tools > Nuget Packet Manager > Package Manager Console and run 'update-database'

-Press CTRL + F5 or the PLAY Icon to deploy
