Client Api Service.

Service that returns a list of clients stored in a Json file, filtered by the last name.

1) Clone the repository in your local machine
2) build and run the project
3) With postman or a similar application, try to get the client list in this 2 ways:
	
	http://localhost:30000/api/client
	http://localhost:30000/api/client/{lastName}

	example: http://localhost:30000/api/client/smith