namespace SpotTheBug
{
    public class DataGatherer
    {
        private DbConnection _connection;

        public void WorkWithData(string connString)
        {
	    using(var conn = new SqlConnection(connString))
	    {
                conn.Open();
		
                // Do something with the database

		conn.Close();
	    }
            var isDatabaseClosed = CloseDatabase();
        }
    }
}
