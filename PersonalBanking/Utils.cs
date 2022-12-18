namespace PersonalBanking
{
    class Utils
    {
        /**
        Returns the current id of the logged in user
        **/
        public static string GetUserID() {
            var con = new Connection();
            var queryStatus = "SELECT id FROM account WHERE status = 'online'";
            var id = con.ReadString(queryStatus);
            return id;
        }

        public static string GetBalance(string uid)
        {
            var con = new Connection();
            var queryBalance = $"SELECT balance FROM account WHERE id = {uid}";
            var balance = con.ReadString(queryBalance);
            return balance;
        }

        /// <summary>
        /// Checks if the owner of the supplied account is the same as the currently logged in user
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public static bool IsOwner(string accountNo)
        {
            var con = new Connection();
            string userID = GetUserID();
            string isOwnerQuery = $"SELECT id FROM account WHERE accountNumber = '{accountNo}' AND id = '{GetUserID()}'";
            string isOwnerQueryResult = con.ReadString(isOwnerQuery);
            bool isOwner = !string.IsNullOrEmpty(isOwnerQueryResult);
            return isOwner;
        }

        /// <summary>
        /// Retrieve the current account number of the logged in user
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentAcc()
        {
            var con = new Connection();
            string currentAccQuery = $"SELECT accountNumber FROM account WHERE id = {GetUserID()} AND accountType = 'Current Account'";
            string result = con.ReadString(currentAccQuery);
            return result;
        }
    }
}
