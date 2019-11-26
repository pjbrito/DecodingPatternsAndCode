using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DecodingPatternsAndCode.Tests.Toptal.Tests
{
    public class Test1_PlaneSeats_Ex1 // SmallestPositiveIntegerNotInArray
    {
        public int solution(int N, string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var seats = new Seats(S);

            var num = 0;
            foreach (var row in seats.RowsList)
            {
                num += seats.FreeInRow(row);
            }

            return num;
        }

        internal class Seats
        {
            private string _seats { get; }
            public List<Seat> SeatList { get; }

            public List<int> RowsList
            {
                get
                {
                    var l = new List<int>();
                    for (var i = 0; i < SeatList.Count; i++)
                    {
                        if (!l.Contains(SeatList[i].Row))
                            l.Add(SeatList[i].Row);
                    }
                    return l;
                }
            }



            public Seats(string seats)
            {
                _seats = seats;
                SeatList = GetSeats(seats)
                    .ToList();
            }

            private static List<Seat> GetSeats(string s)
            {
                return s
                    .ToUpper()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => new Seat(x))
                    .ToList();
            }

            public int FreeInRow(int row)
            {
                var opt1 = true; // B C  D E
                var opt2 = true; // D E F G
                var opt3 = true; // F G  H J
                for (var i = 0; i < SeatList.Count; i++)
                {
                    var s = SeatList[i];
                    if (s.Row != row)
                    {
                        continue;
                    }

                    var seatLetter = s.seat.Replace("" + row, "");
                    if (string.CompareOrdinal(seatLetter, "B") == 0 ||
                        string.CompareOrdinal(seatLetter, "C") == 0 ||
                        string.CompareOrdinal(seatLetter, "D") == 0 ||
                        string.CompareOrdinal(seatLetter, "E") == 0)
                    {
                        opt1 = false;
                    }

                    if (string.CompareOrdinal(seatLetter, "D") == 0 ||
                        string.CompareOrdinal(seatLetter, "E") == 0 ||
                        string.CompareOrdinal(seatLetter, "F") == 0 ||
                        string.CompareOrdinal(seatLetter, "G") == 0)
                    {
                        opt2 = false;
                    }

                    if (string.CompareOrdinal(seatLetter, "F") == 0 ||
                        string.CompareOrdinal(seatLetter, "G") == 0 ||
                        string.CompareOrdinal(seatLetter, "H") == 0 ||
                        string.CompareOrdinal(seatLetter, "J") == 0)
                    {
                        opt3 = false;
                    }
                }

                int result = 0;
                if (opt1)
                    result++;

                if (opt2)
                    result++;

                if (opt3)
                    result++;

                if (opt1 && opt2)
                    result--;

                if (opt2 && opt3)
                    result--;

                if (opt1 && opt3)
                    result = 2;

                return result;
            }

            internal class Seat
            {
                public string seat
                {
                    get { return _seat; }
                }

                private string _seat { get; set; }
                private int _rowNumber { get; set; }

                public int Row
                {
                    get
                    {
                        if (_rowNumber == 0)
                            _rowNumber = int.Parse(_seat.Substring(0, _seat.Length - 1));

                        return _rowNumber;
                    }
                }

                public Seat(string seat)
                {
                    _seat = seat;
                }
            }
        }

        public class TopTalPlaneSeats
        {

            [Fact]
            public void Solution()
            {
                //var s1 = "1A 3C 2B 40G 5A";

                //var r1 = 6; // acho eu
                //var res = new Test1_PlaneSeats_Ex1().solution(r1, s1);
                //Assert.Equal(r1, res);

                //var s2 = "1A 2F 1C";

                //var s1 = "1A 2F 1C";
                //var r1 = 2; // acho eu
                //var res1 = new Test1_PlaneSeats_Ex1().solution(2, s1);
                //Assert.Equal(r1, res1);


                //var s2 = "";
                //var r2 = 2;
                //var res2 = new Test1_PlaneSeats_Ex1().solution(1, s2);
                //Assert.Equal(r2, res2);

            }

        }

    }

}
