using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class MobilePad
    {
        public static string  OldPhonePad(string input)
        {
            IDictionary<string, string> map = new Dictionary<string, string>();
            map.Add("9999", "Z");
            map.Add("999", "Y");
            map.Add("99", "X");
            map.Add("9", "W");
            map.Add("888","V");
            map.Add("88", "U");
            map.Add("8", "T");
            map.Add("7777", "S");
            map.Add("777", "R");
            map.Add("77", "Q");
            map.Add("7", "P");
            map.Add("666", "O");
            map.Add("66", "N");
            map.Add("6", "M");
            map.Add("555", "L");
            map.Add("55", "K");
            map.Add("5", "J");
            map.Add("444", "I");
            map.Add("44", "H");
            map.Add("4", "G");
            map.Add("333", "F");
            map.Add("33", "E");
            map.Add("3", "D");
            map.Add("222", "C");
            map.Add("22", "B");
            map.Add("2", "A");


            Dictionary<string, string> remove = new Dictionary<string, string>();
            remove.Add("A*", "");
            remove.Add("B*", "");
            remove.Add("C*", "");
            remove.Add("D*", "");
            remove.Add("E*", "");
            remove.Add("F*", "");
            remove.Add("G*", "");
            remove.Add("H*", "");
            remove.Add("I*", "");
            remove.Add("J*", "");
            remove.Add("K*", "");
            remove.Add("L*", "");
            remove.Add("M*", "");
            remove.Add("N*", "");
            remove.Add("O*", "");
            remove.Add("P*", "");
            remove.Add("Q*", "");
            remove.Add("R*", "");
            remove.Add("S*", "");
            remove.Add("T*", "");
            remove.Add("U*", "");
            remove.Add("V*", "");
            remove.Add("W*", "");
            remove.Add("X*", "");
            remove.Add("Y*", "");
            remove.Add("Z*", "");
            var output = input;
            foreach(var item in map)
            {
                output = output.Replace(item.Key, item.Value);
            }
            foreach(var item in remove)
            {
                output = output.Replace(item.Key, item.Value);
            }

            return output.Replace("#","").Replace(" ","");
            
            
        }
    }
}
