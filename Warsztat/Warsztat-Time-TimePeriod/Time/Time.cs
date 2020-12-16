using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TimeTimePeriod;

namespace TimeTimePeriod
{
        [TestClass]
        public class TimeTimePeriodConstructors
        {
            #region Constructor tests ======
            [TestMethod, TestCategory("Constructors")]
            public void Constructor_defaults_time()
            {
                Time t = new Time();

                Assert.AreEqual(0, t.Hours);
                Assert.AreEqual(0, t.Minutes);
                Assert.AreEqual(0, t.Hours);
            }

            [DataTestMethod, TestCategory("Constructors")]
            [DataRow((byte)21, (byte)37, (byte)45, (byte)21, (byte)37, (byte)45)]
            [DataRow((byte)3, (byte)15, (byte)6, (byte)3, (byte)15, (byte)6)]
            [DataRow((byte)14, (byte)20, (byte)00, (byte)14, (byte)20, (byte)0)]
            [DataRow((byte)23, (byte)59, (byte)59, (byte)23, (byte)59, (byte)59)]
            public void Constructor_Time(byte h, byte m, byte s, byte excpH, byte excpM, byte excpS)
            {
                Time t = new Time(h, m, s);

                Assert.AreEqual(t.Hours, excpH);
                Assert.AreEqual(t.Minutes, excpM);
                Assert.AreEqual(t.Seconds, excpS);
            }

            [DataTestMethod, TestCategory("Constructors")]
            [DataRow("21:37:45", (byte)21, (byte)37, (byte)45)]
            [DataRow("3:15:6", (byte)3, (byte)15, (byte)6)]
            [DataRow("14:20:00", (byte)14, (byte)20, (byte)0)]
            [DataRow("23:59:59", (byte)23, (byte)59, (byte)59)]
            public void Constructor_Time_String(string time, byte excpH, byte excpM, byte excpS)
            {
                Time t = new Time(time);

                Assert.AreEqual(t.Hours, excpH);
                Assert.AreEqual(t.Minutes, excpM);
                Assert.AreEqual(t.Seconds, excpS);
            }

       

            [DataTestMethod, TestCategory("Constructors")]
            [DataRow("2137")]
            [DataRow("piata rano")]
            [DataRow("15;24;12")]
            [DataRow("16-16-21")]
            [ExpectedException(typeof(FormatException))]
            public void Constructor_Time_String_exceptionFormat(string time)
            {
                new Time(time);
            }

       

            [DataTestMethod, TestCategory("Constructors")]
            [DataRow(-200)]
            [DataRow(-2137)]
            [DataRow(-660)]
            [DataRow(0)]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Constructor_TimePeriod_Exceptions(long seconds)
            {
                new TimePeriod(seconds);
            }

        
            [DataTestMethod, TestCategory("Constructors")]
            [DataRow("21:37:-10")]
            [DataRow("21:-57:50")]
            [DataRow("-16:27:22")]
            [DataRow("-21:-62:-20")]
            [DataRow("piec sekund")]
            [DataRow("21-21-51")]
            [DataRow("69;23;12")]
            [ExpectedException(typeof(FormatException))]
            public void Constructor_seconds_TimePeriod_string_exceptions_negative_or_form(string time)
            {
                new TimePeriod(time);
            }
            #endregion
        }
        [TestClass]     
        public class TimeTimePeriodEquable
        {
            #region EquableTests ================
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)37, (byte)45, "21:37:45")]
            [DataRow((byte)3, (byte)15, (byte)6, "3:15:6")]
            [DataRow((byte)14, (byte)20, (byte)00, "14:20:0")]
            [DataRow((byte)23, (byte)59, (byte)59, "23:59:59")]
            public void TimeByteToTimeString_equal(byte h, byte m, byte s, string timeString)
            {
                Time t1 = new Time(h, m, s);
                Time t2 = new Time(timeString);
                Assert.IsTrue(t1 == t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("21:37:45", "21:37:45")]
            [DataRow("3:15:6", "3:15:6")]
            [DataRow("14:20:0", "14:20:0")]
            [DataRow("23:59:59", "23:59:59")]
            public void TimeStringToTimeString_equal(string t1s, string t2s)
            {
                Time t1 = new Time(t1s);
                Time t2 = new Time(t2s);
                Assert.IsTrue(t1 == t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)37, (byte)45, (byte)21, (byte)37, (byte)45)]
            [DataRow((byte)3, (byte)15, (byte)6, (byte)3, (byte)15, (byte)6)]
            [DataRow((byte)14, (byte)20, (byte)00, (byte)14, (byte)20, (byte)00)]
            [DataRow((byte)23, (byte)59, (byte)59, (byte)23, (byte)59, (byte)59)]
            public void TimeByteToTimeByte_equal(byte h1, byte m1, byte s1, byte h2, byte m2, byte s2)
            {
                Time t1 = new Time(h1, m1, s1);
                Time t2 = new Time(h2, m2, s2);
                Assert.IsTrue(t1 == t2);
            }

            [DataTestMethod, TestCategory("Equable")]
            [DataRow(2137, 2137)]
            [DataRow(613126, 613126)]
            [DataRow(9031, 9031)]
            [DataRow(27321, 27321)]
            public void TimePeriodSeconds_equal(long s1, long s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 == tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow(2137, "0:35:37")]
            [DataRow(613126, "170:18:46")]
            [DataRow(9031, "2:30:31")]
            [DataRow(27321, "07:35:21")]
            public void TimePeriodSecondsToString_equal(long s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 == tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("0:35:37", "0:35:37")]
            [DataRow("170:18:46", "170:18:46")]
            [DataRow("2:30:31", "2:30:31")]
            [DataRow("07:35:21", "07:35:21")]
            public void TimePeriodStringToString_equal(string s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 == tp2);
            }

            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)37, (byte)45, "1:37:45")]
            [DataRow((byte)3, (byte)15, (byte)6, "13:15:6")]
            [DataRow((byte)14, (byte)20, (byte)00, "14:20:07")]
            [DataRow((byte)23, (byte)59, (byte)59, "23:59:58")]
            public void TimeByteToTimeString_Notequal(byte h, byte m, byte s, string timeString)
            {
                Time t1 = new Time(h, m, s);
                Time t2 = new Time(timeString);
                Assert.IsTrue(t1 != t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("21:37:45", "21:36:45")]
            [DataRow("3:15:6", "13:15:6")]
            [DataRow("14:20:0", "14:20:06")]
            [DataRow("23:59:59", "22:59:59")]
            public void TimeStringToTimeString_Notequal(string t1s, string t2s)
            {
                Time t1 = new Time(t1s);
                Time t2 = new Time(t2s);
                Assert.IsTrue(t1 != t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)37, (byte)45, (byte)21, (byte)38, (byte)45)]
            [DataRow((byte)3, (byte)15, (byte)6, (byte)3, (byte)11, (byte)6)]
            [DataRow((byte)14, (byte)20, (byte)00, (byte)14, (byte)30, (byte)40)]
            [DataRow((byte)23, (byte)59, (byte)59, (byte)13, (byte)9, (byte)59)]
            public void TimeByteToTimeByte_Notequal(byte h1, byte m1, byte s1, byte h2, byte m2, byte s2)
            {
                Time t1 = new Time(h1, m1, s1);
                Time t2 = new Time(h2, m2, s2);
                Assert.IsTrue(t1 != t2);
            }

            [DataTestMethod, TestCategory("Equable")]
            [DataRow(2136, 2137)]
            [DataRow(613125, 613122)]
            [DataRow(9021, 9031)]
            [DataRow(21001, 27321)]
            public void TimePeriodSeconds_Notequal(long s1, long s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 != tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow(21378, "0:35:37")]
            [DataRow(313179, "170:18:46")]
            [DataRow(9030, "2:30:31")]
            [DataRow(127321, "07:35:21")]
            public void TimePeriodSecondsToString_Notequal(long s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 != tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("1:35:37", "0:35:37")]
            [DataRow("170:48:46", "170:18:46")]
            [DataRow("12:30:31", "2:30:31")]
            [DataRow("07:35:22", "07:35:21")]
            public void TimePeriodStringToString_Notequal(string s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 != tp2);
            }
            #endregion
        }
        [TestClass]
        public class TimeTimePeriodToString
        {
            #region ToStringTests ================
            [DataTestMethod, TestCategory("ToString")]
            [DataRow((byte)21, (byte)37, (byte)45, "21:37:45")]
            [DataRow((byte)23, (byte)59, (byte)59, "23:59:59")]
            public void TimeToString(byte h, byte m, byte s, string timeString)
            {
                Time t = new Time(h, m, s);
                Assert.AreEqual(t.ToString(), timeString);
            }

            [DataTestMethod, TestCategory("ToString")]
            [DataRow("21:37:45", "21:37:45")]
            [DataRow("23:59:59", "23:59:59")]
            public void TimeStringToString(string time, string timeString)
            {
                Time t = new Time(time);
                Assert.AreEqual(t.ToString(), timeString);
            }
            //Time Period
            [DataTestMethod, TestCategory("ToString")]
            [DataRow(77865, "21:37:45")]
            [DataRow(249697, "69:21:37")]
            [DataRow(446399, "123:59:59")]
            public void TimePeriodToString(long seconds, string timeString)
            {
                TimePeriod tp = new TimePeriod(seconds);
                Assert.AreEqual(tp.ToString(), timeString);
            }

            [DataTestMethod, TestCategory("ToString")]
        
        
        
            [DataRow("123:59:59", "123:59:59")]
            public void TimePeriodStringToString(string time, string timeString)
            {
                TimePeriod tp = new TimePeriod(time);
                Assert.AreEqual(tp.ToString(), timeString);
            }

            #endregion
        }
        [TestClass]
        public class TimeTimePeriodComparable
        {
            #region ComparableTests ================
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)37, (byte)45, "1:37:45")]
            [DataRow((byte)13, (byte)15, (byte)7, "13:15:6")]
            [DataRow((byte)15, (byte)20, (byte)00, "14:20:07")]
            [DataRow((byte)23, (byte)59, (byte)59, "23:59:58")]
            public void TimeByteToTimeString_Greaterqual(byte h, byte m, byte s, string timeString)
            {
                Time t1 = new Time(h, m, s);
                Time t2 = new Time(timeString);
                Assert.IsTrue(t1 > t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("21:37:45", "21:36:45")]
            [DataRow("14:15:6", "13:15:6")]
            [DataRow("14:20:7", "14:20:6")]
            [DataRow("23:59:59", "22:59:59")]
            public void TimeStringToTimeString_Greaterequal(string t1s, string t2s)
            {
                Time t1 = new Time(t1s);
                Time t2 = new Time(t2s);
                Assert.IsTrue(t1 > t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)38, (byte)44, (byte)21, (byte)38, (byte)45)]
            [DataRow((byte)3, (byte)10, (byte)6, (byte)3, (byte)11, (byte)6)]
            [DataRow((byte)11, (byte)20, (byte)00, (byte)14, (byte)30, (byte)40)]
            [DataRow((byte)13, (byte)59, (byte)59, (byte)23, (byte)9, (byte)59)]
            public void TimeByteToTimeByte_Lesserequal(byte h1, byte m1, byte s1, byte h2, byte m2, byte s2)
            {
                Time t1 = new Time(h1, m1, s1);
                Time t2 = new Time(h2, m2, s2);
                Assert.IsTrue(t1 < t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("1:35:37", "2:35:37")]
            [DataRow("50:48:46", "170:48:47")]
            [DataRow("12:30:31", "12:50:31")]
            [DataRow("07:35:22", "17:35:21")]
            public void TimePeriodStringToString_Lesserequal(string s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 < tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("3:35:37", "2:35:37")]
            [DataRow("253:48:46", "170:48:47")]
            [DataRow("13:30:31", "12:50:31")]
            [DataRow("106:35:22", "104:35:21")]
            public void TimePeriodStringToString_Greaterequal(string s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 > tp2);
            }

            [DataTestMethod, TestCategory("Equable")]
            [DataRow(2138, 2137)]
            [DataRow(613125, 613122)]
            [DataRow(19021, 9031)]
            [DataRow(28001, 27321)]
            [DataRow(2137, 2137)]
            [DataRow(613122, 613122)]
            [DataRow(19021, 19021)]
            [DataRow(28001, 28001)]
            public void TimePeriodSeconds_GreaterOrEqualequal(long s1, long s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 >= tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow(9035, "2:30:31")]
            [DataRow(37321, "07:35:21")]
            [DataRow(21378, "05:56:18")]
            [DataRow(313179, "86:59:39")]
            [DataRow(9035, "02:30:35")]
            [DataRow(127321, "35:22:01")]
            public void TimePeriodSecondsToString__GreaterOrEqualequal(long s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 >= tp2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("1:35:37", "2:35:37")]
            [DataRow("50:48:46", "170:48:47")]
            [DataRow("12:30:31", "12:50:31")]
            [DataRow("07:35:22", "17:35:21")]
            [DataRow("2:35:37", "2:35:37")]
            [DataRow("170:48:47", "170:48:47")]
            [DataRow("12:50:31", "12:50:31")]
            [DataRow("17:35:21", "17:35:21")]
            public void TimePeriodStringToString_LesserOrEqualequal(string s1, string s2)
            {
                TimePeriod tp1 = new TimePeriod(s1);
                TimePeriod tp2 = new TimePeriod(s2);
                Assert.IsTrue(tp1 <= tp2);
            }

            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)22, (byte)37, (byte)45, "21:37:45")]
            [DataRow((byte)3, (byte)45, (byte)6, "3:15:6")]
            [DataRow((byte)14, (byte)20, (byte)50, "14:20:0")]
            [DataRow((byte)23, (byte)59, (byte)59, "22:59:59")]
            [DataRow((byte)21, (byte)37, (byte)45, "21:37:45")]
            [DataRow((byte)3, (byte)15, (byte)6, "3:15:6")]
            [DataRow((byte)14, (byte)20, (byte)00, "14:20:0")]
            [DataRow((byte)23, (byte)59, (byte)59, "23:59:59")]
            public void TimeByteToTimeString_GreaterOrEqualequal(byte h, byte m, byte s, string timeString)
            {
                Time t1 = new Time(h, m, s);
                Time t2 = new Time(timeString);
                Assert.IsTrue(t1 >= t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow("21:37:45", "21:37:48")]
            [DataRow("3:15:6", "3:25:6")]
            [DataRow("14:20:0", "14:27:0")]
            [DataRow("21:59:59", "23:59:59")]
            [DataRow("21:37:45", "21:37:45")]
            [DataRow("3:15:6", "3:15:6")]
            [DataRow("14:20:0", "14:20:0")]
            [DataRow("23:59:59", "23:59:59")]
            public void TimeStringToTimeString_LesserOrEqualequal(string t1s, string t2s)
            {
                Time t1 = new Time(t1s);
                Time t2 = new Time(t2s);
                Assert.IsTrue(t1 <= t2);
            }
            [DataTestMethod, TestCategory("Equable")]
            [DataRow((byte)21, (byte)35, (byte)45, (byte)21, (byte)37, (byte)45)]
            [DataRow((byte)3, (byte)15, (byte)2, (byte)3, (byte)15, (byte)6)]
            [DataRow((byte)11, (byte)20, (byte)00, (byte)14, (byte)20, (byte)00)]
            [DataRow((byte)22, (byte)59, (byte)59, (byte)23, (byte)59, (byte)59)]
            [DataRow((byte)21, (byte)37, (byte)45, (byte)21, (byte)37, (byte)45)]
            [DataRow((byte)3, (byte)15, (byte)6, (byte)3, (byte)15, (byte)6)]
            [DataRow((byte)14, (byte)20, (byte)00, (byte)14, (byte)20, (byte)00)]
            [DataRow((byte)23, (byte)59, (byte)59, (byte)23, (byte)59, (byte)59)]
            public void TimeByteToTimeByte_LesserOrEqualequal(byte h1, byte m1, byte s1, byte h2, byte m2, byte s2)
            {
                Time t1 = new Time(h1, m1, s1);
                Time t2 = new Time(h2, m2, s2);
                Assert.IsTrue(t1 <= t2);
            }

            #endregion
        }
        [TestClass]
        public class TimeTimePeriodPlus
        {
            #region PlusMinusTests ===============
            [DataTestMethod, TestCategory("PlusMinus")]
            [DataRow("21:37:45", "13:10:8", "34:47:53")]
            [DataRow("3:15:6", "1:59:59", "5:15:5")]
            [DataRow("14:20:0", "105:40:21", "120:0:21")]
            [DataRow("23:59:59", "23:59:59", "47:59:58")]
            public void TimePeriodPlusTimePeriod(string timeP1, string timeP2, string timeP3)
            {
                TimePeriod tp1 = new TimePeriod(timeP1);
                TimePeriod tp2 = new TimePeriod(timeP2);
                TimePeriod tp3 = new TimePeriod(timeP3);
                Assert.IsTrue(tp1 + tp2 == tp3);
            }
            [DataTestMethod, TestCategory("PlusMinus")]
            [DataRow("21:37:45", "13:10:8", "34:47:53")]
            [DataRow("3:15:6", "1:59:59", "5:15:5")]
            [DataRow("14:20:0", "105:40:21", "120:0:21")]
            [DataRow("23:59:59", "23:59:59", "47:59:58")]
            public void TimePeriodMinusTimePeriod(string timeP1, string timeP2, string timeP3)
            {
                TimePeriod tp1 = new TimePeriod(timeP1);
                TimePeriod tp2 = new TimePeriod(timeP2);
                TimePeriod tp3 = new TimePeriod(timeP3);
                Assert.IsTrue(tp3 - tp2 == tp1);
            }
            [DataTestMethod, TestCategory("PlusMinus")]
            [DataRow("21:37:45", "23:10:8")]
            [DataRow("3:15:6", "3:59:59")]
            [DataRow("105:39:21", "105:40:21")]
            [DataRow("23:59:58", "23:59:59")]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TimePeriodMinusTimePeriod_Exception(string timeP1, string timeP2)
            {
                TimePeriod tp1 = new TimePeriod(timeP1);
                TimePeriod tp2 = new TimePeriod(timeP2);
                var tp3 = tp1 - tp2;
            }


            [DataTestMethod, TestCategory("PlusMinus")]
            [DataRow("21:37:45", "10:10:8", "11:27:37")]
            [DataRow("0:0:0", "21:37:0", "2:23:0")]
            [DataRow("12:12:13", "0:0:14", "12:11:59")]
            [DataRow("1:13:14", "1:15:16", "23:57:58")]
            public void TimeMinusTimePeriod(string time1, string timeP1, string time2)
            {
                Time t1 = new Time(time1);
                TimePeriod tp1 = new TimePeriod(timeP1);
                Time t2 = new Time(time2);
                Assert.IsTrue(t1 - tp1 == t2);
            }
            #endregion
            
        }

    }


