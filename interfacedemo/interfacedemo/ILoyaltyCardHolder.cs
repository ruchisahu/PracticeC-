using System;
using System.Collections.Generic;
using System.Text;

namespace interfacedemo
{
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}