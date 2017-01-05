﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nager.Date.UnitTest
{
    [TestClass]
    public class UnitTestLogic
    {
        [TestMethod]
        public void CheckEasterSunday()
        {
            var easterSunday = DateSystem.EasterSunday(1900);
            Assert.AreEqual(new DateTime(1900, 4, 15), easterSunday);

            easterSunday = DateSystem.EasterSunday(2014);
            Assert.AreEqual(new DateTime(2014, 4, 20), easterSunday);

            easterSunday = DateSystem.EasterSunday(2015);
            Assert.AreEqual(new DateTime(2015, 4, 5), easterSunday);

            easterSunday = DateSystem.EasterSunday(2016);
            Assert.AreEqual(new DateTime(2016, 3, 27), easterSunday);

            easterSunday = DateSystem.EasterSunday(2017);
            Assert.AreEqual(new DateTime(2017, 4, 16), easterSunday);

            easterSunday = DateSystem.EasterSunday(2018);
            Assert.AreEqual(new DateTime(2018, 4, 1), easterSunday);

            easterSunday = DateSystem.EasterSunday(2019);
            Assert.AreEqual(new DateTime(2019, 4, 21), easterSunday);

            easterSunday = DateSystem.EasterSunday(2020);
            Assert.AreEqual(new DateTime(2020, 4, 12), easterSunday);

            easterSunday = DateSystem.EasterSunday(2200);
            Assert.AreEqual(new DateTime(2200, 4, 6), easterSunday);
        }

        [TestMethod]
        public void CheckIsPublicHoliday()
        {
            var isPublicHoliday = DateSystem.IsPublicHoliday(new DateTime(2016, 5, 1), CountryCode.AT);
            Assert.AreEqual(true, isPublicHoliday);

            isPublicHoliday = DateSystem.IsPublicHoliday(new DateTime(2016, 1, 6), CountryCode.AT);
            Assert.AreEqual(true, isPublicHoliday);
        }

        [TestMethod]
        public void CheckFindDay()
        {
            var result = DateSystem.FindDay(2017, 1, 1, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 2, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 3, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 4, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 5, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 6, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 6), result);

            result = DateSystem.FindDay(2017, 1, 7, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 8, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 9, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 10, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 11, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 12, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 13, DayOfWeek.Friday);
            Assert.AreEqual(new DateTime(2017, 1, 13), result);

            result = DateSystem.FindDay(2017, 1, 14, DayOfWeek.Wednesday);
            Assert.AreEqual(new DateTime(2017, 1, 18), result);
        }
    }
}