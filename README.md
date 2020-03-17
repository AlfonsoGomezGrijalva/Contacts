# Contacts

Service that returns a list of contacts stored in a Json file, filtered by the last name. 

This project was created in C # .Net core 3.
1) Clone the repository in your local machine

2) Build and run the project

3) With postman (https://www.postman.com/downloads/) or a similar application, try to get the client list in this 2 ways:

   - http://localhost:30000/api/contacts 
   - http://localhost:30000/api/contacts/{lastName}

    example: http://localhost:30000/api/contacts/smith
