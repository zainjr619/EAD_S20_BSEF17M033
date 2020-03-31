namespace assign2.dal
{
    internal class sqlConnection
    {
        private string connString;

        public sqlConnection(string connString)
        {
            this.connString = connString;
        }
    }
}