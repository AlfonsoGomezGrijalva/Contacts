# Contacts

Service that returns a list of contacts stored in a Json file, filtered by the last name. 

This project was created in C # .Net core 3 and Visual Studio so, to run it you must search for the .sln file and open it.
1) Clone the repository in your local machine

2) Build and run the project

3) With postman (https://www.postman.com/downloads/) or a similar application, try to get the client list in this 2 ways:

   - http://localhost:30000/api/contact 
   - http://localhost:30000/api/contact/{lastName}

    example: http://localhost:30000/api/contact/smith
