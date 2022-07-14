Persistence Layer
This layer handles database concerns and other data access operations. 
By design the infrastructure depends on Application layer. 
This project contains implementations of the interfaces (e.g. Repositories) that defined in the Application project.

For instance an SQL Server Database is a secondary actor which is affected by the application use cases, 
all the implementation and dependencies required to consume the SQL Server is created on infrastructure (persistence) layer.

For example, if you wanted to implement the Repository pattern you would do so by adding an interface within Application layer 
and adding the implementation within Persistence (Infrastructure) layer.

Persistence layer contains:

Data Context
Repositories
Data Seeding
Data Migrations
Caching (Distributed, In-Memory)