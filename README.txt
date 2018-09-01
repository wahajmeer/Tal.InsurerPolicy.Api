This solution implements the CQRS pattern to implement the API 
There are four projects in the solution 
1. Api: solution which implments the Main project which returns the Life client as json objects (once implemented)
2. Data: which deals with the data connection, in this case it only reads the contents from the excel file and maps it to the ClientRecord object.
3. Domain: which contains the object models in the domain
4. Services: which implements the CQRS pattern, the folder Queries contain the logic for query handling to get the insurance policies and returns it to the API

Given more time, I would be able to complete the solution and implement validation and unit testing and integration for the methods in the solution. This solution still requires 
methods to be implemented asynchronously.
To implement in a proper manner I would prefer importing this file into a database staging area and processing the data throught an ETL process, the solution can then be
modified to implement the repository patter using lightweight Dapper plugin to read the data from the database. This way we can make it more fail safe in case the
file structure changes and we would be sure that the data provided would be in correct format. 
We could use Swagger documents in the API to produce documentation which would be useful for the consumers of this API. This can be implemented by using a Swashbuckle nuget 
package and injecting the configuration at the startup.

Assumptions: It is assumed that the excel file is present in a particular location given in the appsettings.json file and the structure of the file remains unchanged.

