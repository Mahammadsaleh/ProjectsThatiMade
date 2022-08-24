using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_number_detector_ready_version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "";
            string[,] country = Countrycode();
            int countryRowLength = country.GetLength(0);
            string[,] cityAndOperators = CitiesAndOperatorsPhoneCodeInAze();
            Console.WriteLine("Please enter your phone number.");
            Console.WriteLine("Firstly enter your country code then number.");
            phoneNumber = Console.ReadLine();
            phoneNumber = phoneNumber.Replace(" ", "");
            phoneNumber = ZeroOrPlusRemoving(phoneNumber); 
            if (phoneNumber.Length > 0)
            {
                for (int i = 0; i < countryRowLength; i++)
                {
                    if (phoneNumber.StartsWith(country[i, 1]))
                    {
                        int removeLen = country[i, 1].Length;
                        phoneNumber = phoneNumber.Remove(0, removeLen);
                        Console.WriteLine("Phone number's region is: " + country[i, 0]);
                        if (i == 12)
                        {
                            phoneNumber = PhoneNumberChecking(cityAndOperators, phoneNumber);
                        }
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        private static string ZeroOrPlusRemoving(string phoneNumber)
        {
            if (phoneNumber.StartsWith("+"))
            {
                phoneNumber = phoneNumber.Substring(1);
            }
            else if (phoneNumber.StartsWith("00"))
            {
                phoneNumber = phoneNumber.Substring(2);
            }
            else
            {
                phoneNumber = "";
                Console.WriteLine("Country code is wrong try again");
            }
            return phoneNumber;
        }
        private static string[,] CitiesAndOperatorsPhoneCodeInAze()
        {
            return new string[,]
            {
                {"50", "Azercell"},
                {"51", "Azercell"},
                {"55", "Bakcell"},
                {"99", "Bakcell"},
                {"70", "Nar"},
                {"77", "Nar"},

                {"123", "Bakı"},
                {"124", "Bakı"},
                {"125", "Bakı"},
                {"186", "Sumqayıt"},
                {"2020", "Bərdə"},
                {"2021", "Ucar"},
                {"2022", "Ağsu"},
                {"2023", "Ağdaş"},
                {"2024", "Qobustan"},
                {"2025", "Kürdəmir"},
                {"2026", "Şamaxı"},
                {"2027", "Göyçay"},
                {"2028", "İsmayıllı"},
                {"2029", "Zərdab"},
                {"2120", "Hacıqabul"},
                {"21428", "TransEuroCom"},
                {"2121", "Şirvan"},
                {"2122", "Beyləqan"},
                {"2123", "Sabirabad"},
                {"2124", "İmişli"},
                {"2125", "Salyan"},
                {"2126", "Neftçala"},
                {"2127", "Ağcabədi"},
                {"2128", "Saatlı"},
                {"2220", "Göygöl"},
                {"2221", "Daşkəsən"},
                {"2222", "Ağstafa"},
                {"22428", "TransEuroCom"},
                {"2225", "Gəncə"},
                {"2226", "Gəncə"},
                {"2223", "Tərtər"},
                {"2224", "Goranboy"},
                {"2227", "Samux"},
                {"2229", "Qazax"},
                {"2230", "Şəmkir"},
                {"2231", "Tovuz"},
                {"2232", "Gədəbəy"},
                {"2233", "Yevlax"},
                {"2235", "Naftalan"},
                {"2330", "Siyəzən"},
                {"2331", "Xızı"},
                {"2332", "Xaçmaz"},
                {"2333", "Quba"},
                {"2335", "Şabran"},
                {"2338", "Qusar"},
                {"2420", "Qəbələ"},
                {"2421", "Oğuz"},
                {"2422", "Zaqatala"},
                {"2424", "Şəki"},
                {"2425", "Qax"},
                {"2427", "Mingəçevir"},
                {"2429", "Balakən"},
                {"2520", "Yardımlı"},
                {"2521", "Masallı"},
                {"2522", "Astara"},
                {"2524", "Cəlilabad"},
                {"2525", "Lənkəran"},
                {"2527", "Lerik"},
                {"2529", "Biləsuvar"},
                {"2620", "Xocalı"},
                {"2621", "Laçın"},
                {"2622", "Xankəndi"},
                {"2623", "Qubadlı"},
                {"2624", "Əskəran"},
                {"2625", "Zəngilan"},
                {"2626", "Şuşa"},
                {"2627", "Kəlbəcər"},
                {"2628", "Ağdərə"},
                {"2629", "Xocavənd"},
                {"2630", "Hadrut"},
                {"2631", "Füzuli"},
                {"2632", "Ağdamar"},
                {"2638", "Cəbrayıl"},
                {"365", "Naxçıvan"},   
            };
        }
        private static string[,] Countrycode()
        {
            return new string[,]
            {
                { "UK", "44" },
                { "USA", "1" },
                { "Algeria", "213" },
                { "Andorra", "376" },
                { "Angola", "244" },
                { "Anguilla", "1264" },
                { "Antigua & Barbuda", "1268" },
                { "Argentina", "54" },
                { "Armenia", "374" },
                { "Aruba", "297" },
                { "Australia", "61" },
                { "Austria", "43" },
                { "Azerbaijan", "994" },
                { "Bahamas", "1242" },
                { "Bahrain", "973" },
                { "Bangladesh", "880" },
                { "Barbados", "1246" },
                { "Belarus", "375" },
                { "Belgium", "32" },
                { "Belize", "501" },
                { "Benin", "229" },
                { "Bermuda", "1441" },
                { "Bhutan", "975" },
                { "Bolivia", "591" },
                { "Bosnia Herzegovina", "387" },
                { "Botswana", "267" },
                { "Brazil", "55" },
                { "Brunei", "673" },
                { "Bulgaria", "359" },
                { "Burkina Faso", "226" },
                { "Burundi", "257" },
                { "Cambodia", "855" },
                { "Cameroon", "237" },
                { "Canada", "1" },
                { "Cape Verde Islands", "238" },
                { "Cayman Islands", "1345" },
                { "Central African Republic", "236" },
                { "Chile", "56" },
                { "China", "86" },
                { "Colombia", "57" },
                { "Comoros", "269" },
                { "Congo", "242" },
                { "Cook Islands", "682" },
                { "Costa Rica", "506" },
                { "Croatia", "385" },
                { "Cuba", "53" },
                { "Cyprus North", "90392" },
                { "Cyprus South", "357" },
                { "Czech Republic", "42" },
                { "Denmark", "45" },
                { "Djibouti", "253" },
                { "Dominica", "1809" },
                { "Dominican Republic", "1809" },
                { "Ecuador", "593" },
                { "Egypt", "20" },
                { "El Salvador", "503" },
                { "Equatorial Guinea", "240" },
                { "Eritrea", "291" },
                { "Estonia", "372" },
                { "Ethiopia", "251" },
                { "Falkland Islands", "500" },
                { "Faroe Islands", "298" },
                { "Fiji", "679" },
                { "Finland", "358" },
                { "France", "33" },
                { "French Guiana", "594" },
                { "French Polynesia", "689" },
                { "Gabon", "241" },
                { "Gambia", "220" },
                { "Georgia", "7880" },
                { "Germany", "49" },
                { "Ghana", "233" },
                { "Gibraltar", "350" },
                { "Greece", "30" },
                { "Greenland", "299" },
                { "Grenada", "1473" },
                { "Guadeloupe", "590" },
                { "Guam", "671" },
                { "Guatemala", "502" },
                { "Guinea", "224" },
                { "Guinea - Bissau", "245" },
                { "Guyana", "592" },
                { "Haiti", "509" },
                { "Honduras", "504" },
                { "Hong Kong", "852" },
                { "Hungary", "36" },
                { "Iceland", "354" },
                { "India", "91" },
                { "Indonesia", "62" },
                { "Iran", "98" },
                { "Iraq", "964" },
                { "Ireland", "353" },
                { "Israel", "972" },
                { "Italy", "39" },
                { "Jamaica", "1876" },
                { "Japan", "81" },
                { "Jordan", "962" },
                { "Kazakhstan", "7" },
                { "Kenya", "254" },
                { "Kiribati", "686" },
                { "Korea North", "850" },
                { "Korea South", "82" },
                { "Kuwait", "965" },
                { "Kyrgyzstan", "996" },
                { "Laos", "856" },
                { "Latvia", "371" },
                { "Lebanon", "961" },
                { "Lesotho", "266" },
                { "Liberia", "231" },
                { "Libya", "218" },
                { "Liechtenstein", "417" },
                { "Lithuania", "370" },
                { "Luxembourg", "352" },
                { "Macao", "853" },
                { "Macedonia", "389" },
                { "Madagascar", "261" },
                { "Malawi", "265" },
                { "Malaysia", "60" },
                { "Maldives", "960" },
                { "Mali", "223" },
                { "Malta", "356" },
                { "Marshall Islands", "692" },
                { "Martinique", "596" },
                { "Mauritania", "222" },
                { "Mayotte", "269" },
                { "Mexico", "52" },
                { "Micronesia", "691" },
                { "Moldova", "373" },
                { "Monaco", "377" },
                { "Mongolia", "976" },
                { "Montserrat", "1664" },
                { "Morocco", "212" },
                { "Mozambique", "258" },
                { "Myanmar", "95" },
                { "Namibia", "264" },
                { "Nauru", "674" },
                { "Nepal", "977" },
                { "Netherlands", "31" },
                { "New Caledonia", "687" },
                { "New Zealand", "64" },
                { "Nicaragua", "505" },
                { "Niger", "227" },
                { "Nigeria", "234" },
                { "Niue", "683" },
                { "Norfolk Islands", "672" },
                { "Northern Marianas", "670" },
                { "Norway", "47" },
                { "Oman", "968" },
                { "Palau", "680" },
                { "Panama", "507" },
                { "Papua New Guinea", "675" },
                { "Paraguay", "595" },
                { "Peru", "51" },
                { "Philippines", "63" },
                { "Poland", "48" },
                { "Portugal", "351" },
                { "Puerto Rico", "1787" },
                { "Qatar", "974" },
                { "Reunion", "262" },
                { "Romania", "40" },
                { "Russia", "7" },
                { "Rwanda", "250" },
                { "San Marino", "378" },
                { "Sao Tome & Principe", "239" },
                { "Saudi Arabia", "966" },
                { "Senegal", "221" },
                { "Serbia", "381" },
                { "Seychelles", "248" },
                { "Sierra Leone", "232" },
                { "Singapore", "65" },
                { "Slovak Republic", "421" },
                { "Slovenia", "386" },
                { "Solomon Islands", "677" },
                { "Somalia", "252" },
                { "South Africa", "27" },
                { "Spain", "34" },
                { "Sri Lanka", "94" },
                { "St. Helena", "290" },
                { "St. Kitts", "1869" },
                { "St. Lucia", "1758" },
                { "Sudan", "249" },
                { "Suriname", "597" },
                { "Swaziland", "268" },
                { "Sweden", "46" },
                { "Switzerland", "41" },
                { "Syria", "963" },
                { "Taiwan", "886" },
                { "Tajikstan", "7" },
                { "Thailand", "66" },
                { "Togo", "228" },
                { "Tonga", "676" },
                { "Trinidad & Tobago", "1868" },
                { "Tunisia", "216" },
                { "Turkey", "90" },
                { "Turkmenistan", "7" },
                { "Turkmenistan", "993" },
                { "Turks & Caicos Islands", "1649" },
                { "Tuvalu", "688" },
                { "Uganda", "256" },
                { "Ukraine", "380" },
                { "United Arab Emirates", "971" },
                { "Uruguay", "598" },
                { "Uzbekistan", "7" },
                { "Vanuatu", "678" },
                { "Vatican City", "379" },
                { "Venezuela", "58" },
                { "Vietnam", "84" },
                { "Virgin Islands - British", "1284" },
                { "Virgin Islands - US", "1340" },
                { "Wallis & Futuna", "681" },
                { "Yemen", "969" },
                { "Zambia", "260" },
                { "Zimbabwe", "263" },
            };
        }
        public static string PhoneNumberChecking(string[,] cityAndOperators, string phoneNumber)
        {
            int rowLength = cityAndOperators.GetLength(0);
            for (int i = 0; i < rowLength; i++)
            {
                if (phoneNumber.StartsWith(cityAndOperators[i, 0]))
                {
                    Console.WriteLine("This number belongs to the: "+cityAndOperators[i, 1]);
                    break;
                }
                else if (i>rowLength-1)
                { 
                    Console.WriteLine("There is no region with this code, please re-enter your phone number");
                    break;
                }
            }
            return phoneNumber;
        }
    }
}
