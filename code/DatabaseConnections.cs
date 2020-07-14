public DbConnection _connection;

public bool OpenDatabase(string connString)
{
    bool result = false;

    if(connString != null && !string.IsNullOrEmpty(connString))
    {
	_connection = new SqlConnection(connString);
	result = true;
    }

    return result;
}

public bool CloseDatabase()
{
    _connection.Close();
    return true;
}

// Buggy Code
public void WorkWithData()
{
    var isDatabaseOpen = OpenDatabase(_connString);

    // Do something with the database

    var isDatabaseClosed = CloseDatabase();
}

// Good code
public void WorkWithData()
{
    using(var conn = new SqlConnection(_connString))
    {
        conn.Open();

        // Do database work here

        conn.Close();
    }
}
