namespace aspmvccore6test1.Utility
{
    public class ConnectionString
    {
        //https://www.c-sharpcorner.com/article/crud-operations-using-asp-net-core-and-ado-net/
        //SQL ACCESS
        private static string cName = "Data Source=.; Initial Catalog=Endproject_extendver;User ID=ASP1;Password=123";
        public static string CName
        {
            get => cName;
        }
    }
}
