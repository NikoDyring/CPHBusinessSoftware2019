# RPC Assignment
My solution for the RPC Assignment

**_Assignment Description_**  
CPH Business Academy collects data about their PBA SOU students – name, email address, etc. Imagine, the data of the second semester students is already stored in a SQL database, while the same kind of data of the new students is still in a text file. 

Create an application, which can read the data from all sources, regardless the input format, can merge it and then to print it out on the console, one line per student. 

The application should illustrate the use of RPC/RMI technology. 
***
**_Technology used_**
* [gRPC](https://grpc.io/)
* [Google Protocol Buffers](https://developers.google.com/protocol-buffers/docs/csharptutorial)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
***
**_Instructions_**  
1. Download Solution from Github. (Protip: Use [DownGit](https://minhaskamal.github.io/DownGit/#/home) to download this solution only, instead of the whole repo.
2. Open solution file in Visual Studio.
3. Change FILEPATH property on the server to where your txt file is placed.
4. Change connectionstring to fit your database.
5. Start debugging server and start client after to test out the connection.
6. *Success!*
***
**_Pictures from solution_**

*Print of students in the database*  
<img src="https://raw.githubusercontent.com/NikoDyring/Software2019/master/Solutions/System%20Integration/RPCAssignment/imagesForGithub/txtScreenshot.png">

*Screenshot of students in the database*  
<img src="https://raw.githubusercontent.com/NikoDyring/Software2019/master/Solutions/System%20Integration/RPCAssignment/imagesForGithub/dbScreenshot.png">

*Print of consoles showing the RPC functions correctly.*  
<img src="https://raw.githubusercontent.com/NikoDyring/Software2019/master/Solutions/System%20Integration/RPCAssignment/imagesForGithub/consoleprintScreenshots.png" width="498px">
***
**_Known Issues_**
* **Filepath shouldn't be local.**

### By Nikolaj Dyring Jensen
