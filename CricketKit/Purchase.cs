﻿using System;
using System.Collections.Generic;

namespace CricketKit
{
    public class Purchase
    {
        public int purchaseId { get; set; }
        public string purchaseDate { get; set; }
        public double totalAmount { get; set; }
        public string user { get; set; }

        /// <summary>
        /// print the purchase records of user
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            return string.Format("{0}, {1}, {2}", purchaseId, user, totalAmount);
        }
        public static Purchase obtainPurchaseWithAmount(string str)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}