// Basic SQL Server connection string
"Server=serverName;Database=dbName;User Id=username;Password=password;"

// Trusted connection (Windows Authentication)
"Server=serverName;Database=dbName;Trusted_Connection=True;"

// Connection string with additional options
"Server=serverName;Database=dbName;User Id=username;Password=password;Encrypt=True;Connection Timeout=30;"

// Local SQL Server Express connection
"Server=.\\SQLEXPRESS;Database=dbName;Trusted_Connection=True;"

// Azure SQL Database connection string
"Server=myserver.database.windows.net;Database=dbName;User Id=username@myserver;Password=password;"