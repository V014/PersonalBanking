using System;
using System.Collections.Generic;

namespace PersonalBanking
{
    class Utils
    {
        public static string AccountNo = "";

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

        /// <summary>
        /// Retrieve the account type of the currently logged in user
        /// </summary>
        /// <returns></returns>
        public static string GetAccountType()
        {
            var con = new Connection();
            string accountQuery = $"SELECT accountType FROM account WHERE accountNumber = '{AccountNo}'";
            string result = con.ReadString(accountQuery);
            return result;
        }

        /// <summary>
        /// Checks if the users account has had a record placed in the interest table for interest legibilitys
        /// </summary>
        /// <returns></returns>
        public static bool HasInterest()
        {
            var con = new Connection();

            // Account is not a savings account no need to go further
            if (GetAccountType() != "Savings Account") return false;

            string accountIDQuery = $"SELECT id FROM account WHERE accountNumber = '{AccountNo}'";
            string accountID = con.ReadString(accountIDQuery);

            string interestQuery = $"SELECT id FROM interest WHERE accountID = '{accountID}'";
            string result = con.ReadString(interestQuery);

            // If the result variable is empty then interest has not been placed in yet
            if (string.IsNullOrEmpty(result)) return false;

            return true;
        }

        /// <summary>
        /// Performs interest payment to the users account if the period of time has passed a year
        /// returning true on success and false if the interest has already been paid
        /// </summary>
        /// <returns></returns>
        public static bool PayInterest()
        {
            var con = new Connection();
            
            // If the account is not a savings account return
            if (GetAccountType() != "Savings Account") return false;

            // Interest has not been activated yet return false
            if (!HasInterest()) return false;

            // Retrieve the id of the account record
            string accounIDQuery = $"SELECT id FROM account WHERE accountNumber = '{AccountNo}'";
            string accountID = con.ReadString(accounIDQuery);

            // Check the paid column to ascertain if interest needs to be paid to user
            string interestPaidQuery = $"SELECT paid FROM interest WHERE accountID = '{accountID}'";
            string interestPaid = con.ReadString(interestPaidQuery);

            // Interest has already been paid do not continue any further
            if (interestPaid == "true") return false;

            // Retrieve the date the account was created
            string dateCreatedQuery = $"SELECT date_created FROM account WHERE accountNumber = '{AccountNo}'";
            string result = con.ReadString(dateCreatedQuery);
            DateTime dateCreated = DateTime.Parse(result);

            DateTime today = DateTime.Now;

            // Check if the current date difference with the date the account was created is 365 days meaning a year has passed
            int dateDiff = today.Subtract(dateCreated).Days;
            if (dateDiff == 365)
            {
                // Retrieve the percentage of interest that needs to be paid out
                string queryInterestPercent = $"SELECT percentage FROM interest WHERE accountID = '{accountID}'";
                double interestPercent = double.Parse(con.ReadString(queryInterestPercent));

                string updateToPaid = $"UPDATE interest SET paid = 'true' WHERE accountID = '{accountID}'";
                string updateBalanceQuery = $"UPDATE account SET balance = balance + ({interestPercent / 100} * balance) WHERE accountNumber = '{AccountNo}'";

                con.ExecuteQuery(updateBalanceQuery);
                con.ExecuteQuery(updateToPaid);
            } else
            {
                return false;
            }

            return true;
        }
    }
}
 