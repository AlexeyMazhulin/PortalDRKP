using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDRKP.Models
{
    public static class MapperFuncs
    {
        public static List<string> MapRUEN(string RUname)
        {
            string letters = "";
            List<string> ENList = new List<string>();
            string[] arr = new string[3];

            for (byte i = 0; i < RUname.Length; i++)
            {
                switch (RUname[i])
                {
                    #region LETTERS
                    case 'а':
                    case 'А':
                        letters = "a ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'б':
                    case 'Б':
                        letters = "b ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'в':
                    case 'В':
                        letters = "v ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'г':
                    case 'Г':
                        letters = "g ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'д':
                    case 'Д':
                        letters = "d ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'е':
                    case 'Е':
                        letters = "e ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ё':
                    case 'Ё':
                        letters = "e yo jo ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ж':
                    case 'Ж':
                        letters = "j zh ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'з':
                    case 'З':
                        letters = "z ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'и':
                    case 'И':
                        letters = "i ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'й':
                    case 'Й':
                        letters = "i j y ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'к':
                    case 'К':
                        letters = "k ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'л':
                    case 'Л':
                        letters = "l ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'м':
                    case 'М':
                        letters = "m ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'н':
                    case 'Н':
                        letters = "n ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'о':
                    case 'О':
                        letters = "o ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'п':
                    case 'П':
                        letters = "p ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'р':
                    case 'Р':
                        letters = "r ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'с':
                    case 'С':
                        letters = "s ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'т':
                    case 'Т':
                        letters = "t ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'у':
                    case 'У':
                        letters = "u ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ф':
                    case 'Ф':
                        letters = "f ph ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'х':
                    case 'Х':
                        letters = "h kh ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ц':
                    case 'Ц':
                        letters = "z c ts";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ч':
                    case 'Ч':
                        letters = "ch ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ш':
                    case 'Ш':
                        letters = "sh w ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'щ':
                    case 'Щ':
                        letters = "sh shh w ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ъ':
                        break;
                    case 'ы':
                    case 'Ы':
                        letters = "y i ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ь':
                    case 'Ь':
                        break;
                    case 'э':
                    case 'Э':
                        letters = "e ie ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'ю':
                    case 'Ю':
                        letters = "yu u ju ";
                        FillSearchList(letters, ENList);
                        break;
                    case 'я':
                    case 'Я':
                        letters = "ya ja ia ";
                        FillSearchList(letters, ENList);
                        break;
                        #endregion#
                }
            }
            return ENList;
        }

        public static void FillSearchList(string letters, List<string> result)
        {
            List<string> letterlist = letters.GetLetterList();

            if (!result.Any())
                for (byte i = 0; i < letterlist.Count; i++)
                    result.Add(letterlist[i]);
            else
            {
                result.DuplicateElems(letterlist.Count);
                result.FillListWithList(letterlist);
            }
        }
    }
    public static class Extensions
    {
        public static string doubleslash(this String str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\u005c')
                    s += "\\";
                s += str[i];
            }
            return s;
        }
        public static List<string> GetLetterList(this String str)
        {

            string s = "";
            List<string> letterlist = new List<string>();

            for (byte i = 0; i < str.Length; i++)
                if (str[i] != ' ')
                    s += str[i];
                else
                {
                    letterlist.Add(s);
                    s = "";
                }

            return letterlist;
        }

        public static List<string> DuplicateElems(this List<string> inputlist, int ittercount)
        {
            if (ittercount == 1)
                return inputlist;

            int elemcount = inputlist.Count;

            for (byte i = 0; i < ittercount - 1; i++)
                for (byte k = 0; k < elemcount; k++)
                    inputlist.Add(inputlist[k]);

            return inputlist;
        }

        public static List<string> FillListWithList(this List<string> inputlist, List<string> sublist)
        {
            for (byte i = 0; i < inputlist.Count; i++)
                if (sublist.Count == 1)
                    inputlist[i] += sublist[0];
                else
                    if (sublist.Count == 2)
                    if (i < inputlist.Count / 2)
                        inputlist[i] += sublist[0];
                    else
                        inputlist[i] += sublist[1];
                else
                    if (i < inputlist.Count / 3)
                    inputlist[i] += sublist[0];
                else
                        if (i >= inputlist.Count / 3 & i < (inputlist.Count / 3) * 2)
                    inputlist[i] += sublist[1];
                else
                    inputlist[i] += sublist[2];

            return inputlist;
        }

        public static string GetLastName(this string input)
        {
            string str = "";
            byte j = 0;

            for (byte i = 1; i < (input.Length); i++)
                if (char.IsUpper(input[i]))
                {
                    j = i;
                    break;
                }

            str += input[j];

            for (int i = j + 1; i < (input.Length); i++)
                if (!char.IsUpper(input[i]) && input[i] != ' ' && input[i] != '(')
                {
                    str += input[i];
                }
                else
                {
                    break;
                }

            return str;
        }

        public static string GetFirstName(this string input)
        {
            string str = input[0].ToString();

            for (byte i = 1; i < (input.Length); i++)
                if (!char.IsUpper(input[i]))
                {
                    str += input[i];
                }
                else
                    break;

            return str;
        }

        public static string ConvertToEN(this string RuName)
        {
            string ENname = "";

            for (byte i = 0; i < RuName.Length; i++)
                switch (RuName[i])
                {
                    #region LETTERS

                    case 'а':
                    case 'А':
                        ENname += "a";
                        break;

                    case 'б':
                    case 'Б':
                        ENname += "b";
                        break;

                    case 'в':
                    case 'В':
                        ENname += "v";
                        break;

                    case 'г':
                    case 'Г':
                        ENname += "g";
                        break;

                    case 'д':
                    case 'Д':
                        ENname += "d";
                        break;

                    case 'е':
                    case 'Е':
                        ENname += "e";
                        break;

                    case 'ё':
                    case 'Ё':
                        ENname += "e";
                        break;

                    case 'ж':
                    case 'Ж':
                        ENname += "zh";
                        break;

                    case 'з':
                    case 'З':
                        ENname += "z";
                        break;

                    case 'и':
                    case 'И':
                        ENname += "i";
                        break;

                    case 'й':
                    case 'Й':
                        ENname += "y";
                        break;

                    case 'к':
                    case 'К':
                        ENname += "k";
                        break;

                    case 'л':
                    case 'Л':
                        ENname += "l";
                        break;

                    case 'м':
                    case 'М':
                        ENname += "m";
                        break;

                    case 'н':
                    case 'Н':
                        ENname += "n";
                        break;

                    case 'о':
                    case 'О':
                        ENname += "o";
                        break;

                    case 'п':
                    case 'П':
                        ENname += "p";
                        break;

                    case 'р':
                    case 'Р':
                        ENname += "r";
                        break;

                    case 'с':
                    case 'С':
                        ENname += "s";
                        break;

                    case 'т':
                    case 'Т':
                        ENname += "t";
                        break;

                    case 'у':
                    case 'У':
                        ENname += "u";
                        break;

                    case 'ф':
                    case 'Ф':
                        ENname += "f";
                        break;

                    case 'х':
                    case 'Х':
                        ENname += "h";
                        break;

                    case 'ц':
                    case 'Ц':
                        ENname += "c";
                        break;

                    case 'ч':
                    case 'Ч':
                        ENname += "ch";
                        break;

                    case 'ш':
                    case 'Ш':
                        ENname += "sh";
                        break;

                    case 'щ':
                    case 'Щ':
                        ENname += "shh";
                        break;

                    case 'ы':
                    case 'Ы':
                        ENname += "y";
                        break;

                    case 'э':
                    case 'Э':
                        ENname += "e";
                        break;

                    case 'ю':
                    case 'Ю':
                        ENname += "yu";
                        break;

                    case 'я':
                    case 'Я':
                        ENname += "ya";
                        break;

                        #endregion
                }

            char[] a = ENname.ToCharArray();

            a[0] = char.ToUpper(a[0]);

            return new string(a);
        }
    }

}