# tlibcqrs 
a duplicated of http://tlibcqrs.codeplex.com/

Project Description
Tiny Library CQRS is a small demonstration project which demonstrates the concept of Domain Driven Design and the CQRS architecture pattern. This project relies on the Apworks DDD framework, which is already included in the source package.


Prerequisites

Tiny Library CQRS requires the following components to run properly:

    Microsoft .NET Framework 3.5 SP1
    Microsoft Patterns&Practices Enterprise Library 5.0 (April 2010)
    Microsoft SQL Express 2008
    Microsoft Visual Studio 2010 (It is required when opening the source solution)
    Microsoft ASP.NET MVC
    Apworks DDD framework (http://www.apworks.org, http://apworks.codeplex.com), the framework now is at its Alpha version (Version number: 1.0.4016.23016). Please download and install the installation package of this version from http://apworks.codeplex.com 

IMPORTANT: Note that the Apworks DDD framework is still at its Alpha version, currently please DO NOT use this framework in your production envrionment since it might lead to unpredictable issues. For the latest information about the apworks framework, please refer to http://www.apworks.org or http://apworks.codeplex.com.

 

Setup

Please follow the steps below to setup the environment after you have installed the prerequisites above:

    Open Microsoft Visual Studio 2010
    Open the Server Explorer
    Right click on Data Connections, and select Create New SQL Server Database option
    In the Create New SQL Server Database dialog box, type .\SQLEXPRESS as the Server name, then in the New database name field, type TinyLibraryEventDB
    Use the same approach indicated above to create another database, named TinyLibraryQueryDB
    In Microsoft Visual Studio 2010, open the TinyLibraryCQRS solution
    If you have installed the Apworks Application Development Framework to C:\Program Files\Apworks directory, then nothing needs to be changed. Otherwise, please re-add the reference to Apworks DLLs for each project under the solution
    Under Additions folder, run TinyLibraryEventDB.sql and TinyLibraryQueryDB.sql scripts sequentially
    Build entire solution
    In Solution Explorer, right click TinyLibrary.Services.CommandService.svc file, select View in Browser, this will start an ASP.NET Development Server with the port 1421
    Set TinyLibrary.WebApp project as the startup project and press CTRL+F5 to run the application 

 

Running the Application

After successfully started the application, you will be able to see the following screen:

image

To Logon, use Username: daxnet / Password: 123456 as the account.
