﻿using System;
//using NUnit.Framework;

namespace ProductsApp471.Models
{
   // [TestFixture]
    public class Tester
    {
        private double epsilon = 1e-6;

     //   [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(20);

        //    Assert.AreEqual(0, account.OverdaftLimit, epsilon);
        }
    }
}