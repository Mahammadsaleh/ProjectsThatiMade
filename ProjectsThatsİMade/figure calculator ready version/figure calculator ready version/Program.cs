using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hendesi_Fiqur_Kalkulyatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            ConsoleKeyInfo keyM = new ConsoleKeyInfo();
            ConsoleKeyInfo key1Fiqurlar = new ConsoleKeyInfo();
            ConsoleKeyInfo key2Type = new ConsoleKeyInfo();
            ConsoleKeyInfo key3Triangles = new ConsoleKeyInfo();

            bool GoToTriangles = false;
            bool GoToTypes = false;
            bool GoToFiqurlar = false;
            bool GoToM = false;

            while (true)
            {
                 
                if (!GoToM)
                {
                    keyM = Console.ReadKey();
                }
                ConsoleKey keyC = keyM.Key;
                switch (keyC)
                {
                    case ConsoleKey.M:
                        {
                            Menu();
                            if (GoToFiqurlar==false)
                            {
                                key1Fiqurlar = Console.ReadKey();
                            }
                            
                            ConsoleKey keyC1 = key1Fiqurlar.Key;
                            switch (keyC1)
                            {
                                case ConsoleKey.D1:
                                    {
                                        Fiqures();
                                        if (!GoToTypes)
                                        {
                                            key2Type = Console.ReadKey();
                                        }
                                         
                                        ConsoleKey keyC2 = key2Type.Key;
                                        switch (keyC2)
                                        {
                                           default:
                                                Console.Clear();
                                                Console.WriteLine("\n");
                                                Console.WriteLine("Unknown Command.");
                                                Console.WriteLine("Press any key to return back");
                                                Console.ReadKey();
                                                GoToM = true;
                                                GoToFiqurlar = true;
                                                GoToTypes = false;
                                                break;

                                            case ConsoleKey.E:
                                                {
                                                    Console.Clear();
                                                    Ucbucaq();
                                                    if (!GoToTriangles)
                                                    {
                                                        key3Triangles = Console.ReadKey();
                                                    }
                                                     
                                                    ConsoleKey keyC3 = key3Triangles.Key;
                                                    switch (keyC3)
                                                    {
                                                        case ConsoleKey.K:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n");
                                                                Console.WriteLine("DUZBUCAQLI UCBUCAQ\n\n\n");
                                                                Console.Write("Duzbucaqli ucbucagin 1.katetini daxil edin : ");
                                                                double katet1 = double.Parse(Console.ReadLine());
                                                                Console.Write("Duzbucaqli ucbucagin 2.ci katetini daxil edin : ");
                                                                double katet2 = double.Parse(Console.ReadLine());
                                                                double duzUcSahe = 0;
                                                                double duzUcPer = 0;
                                                                double duzUcr = 0;
                                                                double duzUcR = 0;
                                                                double duzUcHipH = 0;
                                                                DuzbucaqliUcbucaq(katet1, katet2, out duzUcSahe, out duzUcPer, out duzUcr, out duzUcR, out duzUcHipH);
                                                                Console.WriteLine("Duzbucaqli ucbucagin sahesi : " + duzUcSahe);
                                                                Console.WriteLine("Duzbucaqli ucbucagin perimetri : " + duzUcPer);
                                                                Console.WriteLine("Duzbucaqli ucbucagin daxiline cekilmis cevrenin radiusu : " + duzUcr);
                                                                Console.WriteLine("Duzbucaqli ucbucagin xaricine cekilmis cevrenin radiusu : " + duzUcR);
                                                                Console.WriteLine("Duzbucaqli ucbucagin hipotenuzuna cekilen hundurluyun uzunlugu : " + duzUcHipH);
                                                                Console.WriteLine("any key");

                                                                Console.ReadKey();
                                                                GoToM = true;
                                                                GoToFiqurlar = true;
                                                                GoToTypes = true;
                                                                GoToTriangles = false;

                                                            }
                                                            break;

                                                        //key3 = Console.ReadKey();
                                                        case ConsoleKey.Z:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n");
                                                                Console.WriteLine("BERABERTEREFLI UCBUCAQ\n\n\n");
                                                                Console.Write("Beraberterefli ucbucagin terefini daxil edin : ");
                                                                double bbtTeref = double.Parse(Console.ReadLine());
                                                                double bbtUcSahe = 0;
                                                                double bbtUcPer = 0;
                                                                double bbtUcr = 0;
                                                                double bbtUcR = 0;
                                                                double bbtUcHMT = 0;
                                                                BeraberterefliUcbucaq(bbtTeref, out bbtUcSahe, out bbtUcPer, out bbtUcr, out bbtUcR, out bbtUcHMT);
                                                                Console.WriteLine("Beraberterefli ucbucagin sahesi : " + bbtUcSahe);
                                                                Console.WriteLine("Beraberterefli ucbucagin perimetri : " + bbtUcPer);
                                                                Console.WriteLine("Beraberterefli ucbucagin daxiline cekilmis cevrenin radiusu : " + bbtUcr);
                                                                Console.WriteLine("Beraberterefli ucbucagin xaricine cekilmis cevrenin radiusu : " + bbtUcR);
                                                                Console.WriteLine("Beraberterefli ucbucagin hundurluyu,mediani ve tenboleni : " + bbtUcHMT);
                                                                Console.WriteLine("any key");

                                                                Console.ReadKey();
                                                                GoToM = true;
                                                                GoToFiqurlar = true;
                                                                GoToTypes = true;
                                                                GoToTriangles = false;

                                                            }
                                                            break;
                                                        case ConsoleKey.X:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n");
                                                                Console.WriteLine("BERABERTEREFLI UCBUCAQ\n\n\n");
                                                                Console.Write("Beraberterefli ucbucagin 1ci terefini daxil edin : ");
                                                                double ixUcT1 = double.Parse(Console.ReadLine());
                                                                Console.Write("Beraberterefli ucbucagin 2ci terefini daxil edin : ");
                                                                double ixUcT2 = double.Parse(Console.ReadLine());
                                                                Console.Write("Beraberterefli ucbucagin31ci terefini daxil edin : ");
                                                                double ixUcT3 = double.Parse(Console.ReadLine());
                                                                
                                                                double ixUcSahe = 0;
                                                                double ixUcPer = 0;
                                                                double p = 0;
                                                                double ixUcr = 0;
                                                                double ixUcR = 0;
                                                                IxtiyariUcbucaq(ixUcT1, ixUcT2,  ixUcT3, out ixUcSahe, out  ixUcPer, out  ixUcr, out ixUcR);
                                                                Console.WriteLine("Beraberterefli ucbucagin sahesi : " + ixUcSahe);
                                                                Console.WriteLine("Beraberterefli ucbucagin perimetri : " + ixUcPer);
                                                                Console.WriteLine("Beraberterefli ucbucagin daxiline cekilmis cevrenin radiusu : " + ixUcr);
                                                                Console.WriteLine("Beraberterefli ucbucagin xaricine cekilmis cevrenin radiusu : " + ixUcR);
                                                                
                                                                Console.WriteLine("any key");

                                                                Console.ReadKey();
                                                                GoToM = true;
                                                                GoToFiqurlar = true;
                                                                GoToTypes = true;
                                                                GoToTriangles = false;

                                                            }
                                                            break;
                                                           
                                                        case ConsoleKey.Escape:
                                                            {
                                                                
                                                                GoToM = true;
                                                                GoToFiqurlar = true;
                                                                GoToTypes = false;
                                                                
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                }
                                            case ConsoleKey.R:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("KVADRAT BASLIGI\n\n\n");
                                                    Console.Write("Kvadratin terefini daxil edin : ");
                                                    double kvteref = double.Parse(Console.ReadLine());
                                                    double kvPer = 0;
                                                    double kvSahe = 0;
                                                    double kvDiaq = 0;
                                                    double kvr = 0;
                                                    double kvR = 0;
                                                    Kvadrat(kvteref, out kvSahe, out kvPer, out kvDiaq, out kvr, out kvR);
                                                    Console.WriteLine("Kvadratin sahesi : " + kvSahe + "\nKvadratin perimetri : " + kvPer + "\nKvadratin diaqonali : " + kvDiaq);
                                                    Console.WriteLine("Kvadratin daxiline cekilen cevrenin radiusu : " + kvr);
                                                    Console.WriteLine("Kvadratin xaricine cekilen cevrenin radiusu : " + kvR);

                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                    

                                                }
                                                break;

                                            case ConsoleKey.A:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("KUB BASLIGI\n\n\n");
                                                    Console.Write("Kubun terefini daxil edin : ");
                                                    double kubT = double.Parse(Console.ReadLine());
                                                    double kubdiaq = 0;
                                                    double kubSyan = 0;
                                                    double kubStam = 0;
                                                    double kubV = 0;
                                                    Kub( kubT, out  kubdiaq, out  kubSyan, out kubStam, out kubV);
                                                    Console.WriteLine("Kubun diaqonali : " + kubdiaq);
                                                    Console.WriteLine("Kubun yan tereflerinin sahesi : " + kubSyan);
                                                    Console.WriteLine("Kubun tam sahesi : " + kubStam);

                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;

                                            case ConsoleKey.T:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Duzbucaqli BASLIGI\n\n\n");
                                                    Console.Write("Duzbucaqlinin tereflerini daxil edin : ");
                                                    double duzT1 = double.Parse(Console.ReadLine());
                                                    Console.Write("2ci: ");
                                                    double duzT2 = double.Parse(Console.ReadLine());
                                                    double duzPer = 0;
                                                    double duzDiaq = 0;
                                                    double duzR = 0;
                                                    double duzSahe = 0;
                                                    string duzr;
                                                    Duzbucaqli(duzT1, duzT2, out duzSahe, out duzPer, out duzDiaq, out duzR, out duzr);
                                                    Console.WriteLine("Duzbucaqlinin diaqonali : " + duzDiaq);
                                                    Console.WriteLine("Duzbucaqlinin Perimetri: " + duzPer);
                                                    Console.WriteLine("Duzbucaqlinin sahesi : " + duzSahe);
                                                    Console.WriteLine("Duzbucaqlinin xaricindeki cevrenin radiusu:"+ duzR);
                                                    Console.WriteLine(duzr);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                                
                                            case ConsoleKey.Y:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Cevre BASLIGI\n\n\n");
                                                    Console.Write("Cevrenin radiusunu daxil edin: ");
                                                    double cevR = double.Parse(Console.ReadLine());
                                                    Console.Write("alfani qeyd edin:");
                                                    double alfa = double.Parse(Console.ReadLine());
                                                    double cevUzn = 0;
                                                    double cevSahe = 0;
                                                    double cevSektSahe = 0;
                                                    double cevQovsUzn = 0;

                                                    Cevre( cevR,  alfa, out  cevUzn, out  cevSahe, out cevSektSahe, out  cevQovsUzn);
                                                    Console.WriteLine("Cevrenin uzunlugu : " + cevUzn);
                                                    Console.WriteLine("Cevrenin sahesi: " + cevSahe);
                                                    Console.WriteLine("Cevrenin sektrinin sahesi : " + cevSektSahe);
                                                    Console.WriteLine("cevQovsUzn:" + cevQovsUzn);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                               
                                            case ConsoleKey.U:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Trapesiya BASLIGI\n\n\n");
                                                    Console.Write("Trapesiyanin alt terefini daxil edin: ");
                                                    double trapAlt = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin ust terefini daxil edin:");
                                                    double trapUst = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin yan terefini daxil edin:");
                                                    double trapYan1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin diger yan terefini daxil edin:");
                                                    double trapYan2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin hundurluyunu daxil edin:");
                                                    double trapH = double.Parse(Console.ReadLine());
                                                    double trapOrtaXett = 0;
                                                    double trapSahe = 0;
                                                    string trapr;

                                                    Trapesiya( trapAlt, trapUst, trapYan1,trapYan2,  trapOrtaXett,  trapH, out trapSahe, out  trapr);
                                                    Console.WriteLine("Trapesiyanin orta xettinin uzunlugu : " + trapOrtaXett);
                                                    Console.WriteLine("Trapesiyanin sahesi: " + trapSahe);
                                                    Console.WriteLine(trapr);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                               
                                            case ConsoleKey.I:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Romb BASLIGI\n\n\n");
                                                    Console.Write("Rombun terefini daxil edin: ");
                                                    double rombT = double.Parse(Console.ReadLine());
                                                    Console.Write("Rombun hundurluyunu qeyd edin:");
                                                    double rombH = double.Parse(Console.ReadLine());
                                                    double rombSahe = 0;
                                                    double rombPer = 0;
                                                    double rombSin = 0;
                                                    double rombr = 0;
                                                    Romb( rombT, rombH, out  rombSahe, out rombPer, out rombSin, out rombr);
                                                    Console.WriteLine("Rombun perimetri : " + rombPer);
                                                    Console.WriteLine("Rombun sahesi: " + rombSahe);
                                                    Console.WriteLine("Rombun sinusu : " + rombSin);
                                                    Console.WriteLine("Rombun radiusu:" + rombr);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                               
                                            case ConsoleKey.O:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Paralelogram BASLIGI\n\n\n");
                                                    Console.Write("Paraleloqramin terefini daxil edin: ");
                                                    double parT1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paraleloqramin 2ci terefini daxil edin:");
                                                    double parT2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paraleloqramin 1ci hundurluyunu daxil edin:");
                                                    double parH1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paraleloqramin 2ci hundurluyunu daxil edin:");
                                                    double parH2 = double.Parse(Console.ReadLine());
                                                    double parSahe = 0;
                                                    double parPer = 0;
                                                    double parSin = 0;
                                                    Paraleloqram(parT1,parT2,  parH1, parH2, out  parSahe, out parPer, out parSin);
                                                    Console.WriteLine("Paraleloqramin perimetri : " + parPer);
                                                    Console.WriteLine("Paraleloqramin sahesi: " + parSahe);
                                                    Console.WriteLine("Paraleloqramin sinusu : " + parSin);
                                                    
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                           
                                            case ConsoleKey.P:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Paralelepiped BASLIGI\n\n\n");
                                                    Console.Write("Paralelepipedin terefini daxil edin: ");
                                                    double prpipedT1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paralelepipedin 2ci terefini daxil edin:");
                                                    double prpipedT2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paralelepipedin 3cu terefini daxil edin:");
                                                    double prpipedT3 = double.Parse(Console.ReadLine());
                                                    
                                                    double prpipedDiaq = 0;
                                                    double prpipedSyan = 0;
                                                    double prpipedStam = 0;
                                                    double prpipedV = 0;
                                                    Paralelepiped( prpipedT1, prpipedT2, prpipedT3, out  prpipedDiaq, out prpipedSyan, out prpipedStam, out  prpipedV);
                                                    Console.WriteLine("Paralelepipedin diaqonali : " + prpipedDiaq);
                                                    Console.WriteLine("Paralelepipedin sahesi (stam): " + prpipedStam);
                                                    Console.WriteLine("Paralelepipedin sahesi (syan) " + prpipedSyan);
                                                    Console.WriteLine("Paralelepipedin hecmi " + prpipedV);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                               
                                            case ConsoleKey.G:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Silindr BASLIGI\n\n\n");
                                                    Console.Write("Silindr radiusunu daxil edin: ");
                                                    double slnR = double.Parse(Console.ReadLine());
                                                    Console.Write("Silindr hundurluyunu daxil edin:");
                                                    double slnH = double.Parse(Console.ReadLine());
                                                    
                                                    double slnSyan = 0;
                                                    double slnStam = 0;
                                                    double slnV = 0;

                                                    Silindr(slnR,slnH, out  slnSyan, out  slnStam, out  slnV);
                                                    Console.WriteLine("Syan: " + slnSyan);
                                                    Console.WriteLine("Stam: " + slnStam);
                                                    Console.WriteLine("Silindr hecmi " + slnV);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                            case ConsoleKey.H:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Sfera BASLIGI\n\n\n");
                                                    Console.Write("Sferanin radiusunu daxil edin: ");
                                                    double rad = double.Parse(Console.ReadLine());
                                                    double sferaS = 0;
                                                    double kureV = 0;
                                                    Sfera(rad, out sferaS, out kureV);
                                                    Console.WriteLine("Sahesi: " + sferaS);
                                                    Console.WriteLine("Hecmi: " + kureV);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                                
                                            case ConsoleKey.F:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Conus BASLIGI\n\n\n");
                                                    Console.Write("Conusun radiusunu daxil edin: ");
                                                    double r = double.Parse(Console.ReadLine());
                                                    Console.Write("Conusun hundurluyunu daxil edin: ");
                                                    double h = double.Parse(Console.ReadLine());
                                                    double area = 0;
                                                    double volume = 0;
                                                    Conus(r, h, out  area, out volume);
                                                    Console.WriteLine("Sahesi: " + area);
                                                    Console.WriteLine("Hecmi: " + volume);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                               
                                            case ConsoleKey.S:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("Pramida BASLIGI\n\n\n");
                                                    Console.Write("Pramidanin terefini daxil edin: ");
                                                    double a = double.Parse(Console.ReadLine());
                                                    Console.Write("Pramidanin 2ci terefini daxil edin: ");
                                                    double b = double.Parse(Console.ReadLine());
                                                    Console.Write("Pramidanin hundurluyunu daxil edin: ");
                                                    double h = double.Parse(Console.ReadLine());
                                                    Console.Write("Pramidanin apofemini daxil edin: ");
                                                    double apofem = double.Parse(Console.ReadLine());
                                                    double area = 0;
                                                    double volume = 0;
                                                    double p = 0;
                                                    Pyramid(a,  b,  h,apofem, out  volume, out  p, out  area);
                                                    Console.WriteLine("Sahesi: " + area);
                                                    Console.WriteLine("Hecmi: " + volume);
                                                    Console.WriteLine("Hecmi: " + p);
                                                    Console.WriteLine("any key");
                                                    Console.ReadKey();
                                                    GoToM = true;
                                                    GoToFiqurlar = true;
                                                    GoToTypes = false;
                                                }
                                                break;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            Console.ReadLine();
        }

        #region Metods
      
        static void Kvadrat(double kvTeref, out double kvSahe, out double kvPer, out double kvDiaq, out double kvr, out double kvR)
        {
            kvSahe = kvTeref * kvTeref;
            kvPer = kvTeref * 4;
            kvDiaq = kvTeref * Math.Sqrt(2);
            kvr = kvTeref / 2;
            kvR = kvDiaq / 2;
        }

        static void DuzbucaqliUcbucaq(double katet1, double katet2, out double duzUcSahe, out double duzUcPer, out double duzUcr, out double duzUcR, out double duzUcHipH)
        {
            duzUcSahe = katet1 * katet2 / 2;
            double hip = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
            duzUcPer = katet1 + katet2 + hip;
            duzUcr = (katet1 + katet2 - hip) / 2;
            duzUcR = hip / 2;
            duzUcHipH = katet1 * katet2 / hip;
        }

        static void BeraberterefliUcbucaq(double bbtTeref, out double bbtUcSahe, out double bbtUcPer, out double bbtUcr, out double bbtUcR, out double bbtUcHMT)
        {
            bbtUcSahe = (bbtTeref * bbtTeref * Math.Sqrt(3)) / 4;
            bbtUcPer = bbtTeref * 3;
            bbtUcr = (bbtTeref * Math.Sqrt(3)) / 6;
            bbtUcR = (bbtTeref * Math.Sqrt(3)) / 3;
            bbtUcHMT = (bbtTeref * Math.Sqrt(3)) / 2;
        }

        static void IxtiyariUcbucaq(double ixUcT1, double ixUcT2, double ixUcT3, out double ixUcSahe, out double ixUcPer, out double ixUcr, out double ixUcR)
        {
            double p = (ixUcT1 + ixUcT2 + ixUcT3) / 2;
            ixUcSahe = Math.Sqrt(p * (p - ixUcT1) * (p - ixUcT2) * (p - ixUcT3));
            ixUcPer = ixUcT1 + ixUcT2 + ixUcT3;
            ixUcr = 2 * ixUcSahe / (ixUcT1 + ixUcT2 + ixUcT3);
            ixUcR = (ixUcT1 * ixUcT2 * ixUcT3) / (4 * ixUcSahe);
        }

        static void Duzbucaqli(double duzT1, double duzT2, out double duzSahe, out double duzPer, out double duzDiaq, out double duzR, out string duzr)
        {
            duzSahe = duzT1 * duzT2;
            duzPer = 2 * duzT1 + 2 * duzT2;
            duzDiaq = Math.Sqrt(Math.Pow(duzT1, 2) + Math.Pow(duzT2, 2));
            duzR = duzDiaq / 2;
            duzr = "Duzbucaqlinin daxiline cevre cekmek olmur.Cunki qarsi tereflerinin cemi beraber deyil .";
        }

        static void Paraleloqram(double parT1, double parT2, double parH1, double parH2, out double parSahe, out double parPer, out double parSin)
        {
            parSahe = parT1 * parH1;
            parSahe = parT2 * parH2;
            parPer = 2 * parT1 + 2 * parT2;
            parSin = parSahe / (parT1 * parT2);
        }

        static void Romb(double rombT, double rombH, out double rombSahe, out double rombPer, out double rombSin, out double rombr)
        {
            rombSahe = rombT * rombH;
            rombPer = 4 * rombT;
            rombSin = rombSahe / Math.Pow(rombT, 2);
            rombr = rombH / 2;
        }

        static void Trapesiya(double trapAlt, double trapUst, double trapYan1, double trapYan2, double trapOrtaXett, double trapH, out double trapSahe, out string trapr)
        {
            trapOrtaXett = (trapAlt + trapUst) / 2;
            trapSahe = trapOrtaXett * trapH;
            trapr = "Trapesiyanin o vaxt daxiline cevre cekmek olar ki, orta xettin uzunlugu yan terefin uzunluguna beraber olsun .";
            // Mainde switchda yanlari daxil edessen.If yazassan ki,yanlar beraberdise trapR=trapH/2 eks halda cw(Trapin xaricine no cevre).
            //ele bil ki, trapR in hesablanmasi funksiyada yox mainin icinde olacaq.Funksiyaynan elaqesi yoxdu onun.
        }

        static void Cevre(double cevR, double alfa, out double cevUzn, out double cevSahe, out double cevSektSahe, out double cevQovsUzn)
        {
            cevUzn = 2 * Math.PI * cevR;
            cevSahe = Math.PI * cevR * cevR;
            cevSektSahe = (cevSahe * alfa) / 360;
            cevQovsUzn = (Math.PI * cevR * alfa) / 180;
        }

        static void Paralelepiped(double prpipedT1,double prpipedT2,double prpipedT3,out double prpipedDiaq,out double prpipedSyan,out double prpipedStam,out double prpipedV)
        {
            prpipedDiaq = Math.Sqrt(Math.Pow(prpipedT1, 2) + Math.Pow(prpipedT2, 2) + Math.Pow(prpipedT3, 2));
            prpipedSyan = 2 * prpipedT3 * (prpipedT1 + prpipedT2);
            prpipedStam = 2 * (prpipedT1 * prpipedT3 + prpipedT2 * prpipedT3 + prpipedT1 * prpipedT2);
            prpipedV = prpipedT1 * prpipedT2 * prpipedT3;
        }

        static void Kub(double kubT, out double kubdiaq, out double kubSyan, out double kubStam, out double kubV)
        {
            kubdiaq = kubT * Math.Sqrt(3);
            kubSyan = 4 * kubT * kubT;
            kubStam = 6 * kubT * kubT;
            kubV = kubT * kubT * kubT;
        }

        static void Silindr(double slnR,double slnH,out double slnSyan,out double slnStam,out double slnV)
        {
            slnSyan = 2 * Math.PI * slnR * slnH;
            slnStam = slnSyan + 2 * Math.PI * slnR * slnR;
            slnV = Math.PI * slnR * slnR * slnH;
        }

        static void Sfera(double rad,out double sferaS,out double kureV)
        {
            sferaS = 4 * Math.PI * rad * rad;
            kureV = 4 / 3 * Math.PI * rad * rad * rad;
        }
        static void Conus(double r, double h,out double area, out double volume)
        {

             area = Math.PI * r * (r * h);
             volume = Math.PI * Math.Pow(r, 2) * (h / 3);
            
        }
       

        static void Pyramid(double a, double b, double h, double apofem,out double volume ,out double p,out double area)
        {

            volume = a * b * h / 3;
            p = (a + b) / 2;
            area = p * apofem / 2 + a * b;
            
        }
       
        static void Fiqures()
        {
            Console.WriteLine();
            Console.WriteLine("2D fiqurlar :");
            Console.WriteLine();
            Console.WriteLine("--> Ucbucaq (secim ucun 'e'))");
            Console.WriteLine("--> Kvadrat (secim ucun 'r'))");
            Console.WriteLine("--> Duzbucaqli (secim ucun 't'))");
            Console.WriteLine("--> Cevre (secim ucun 'y'))");
            Console.WriteLine("--> Trapesiya (secim ucun 'u'))");
            Console.WriteLine("--> Romb (secim ucun 'i'))");
            Console.WriteLine("--> Paraleloqram (secim ucun 'o'))");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("3D fiqurlar :");
            Console.WriteLine();
            Console.WriteLine("--> Kub (Secim ucun 'a')");
            Console.WriteLine("--> Duzbucaqli paralelepiped (Secim ucun 'p')");
            Console.WriteLine("--> Duzgun dordbucaqli piramida (Secim ucun 's')");
            Console.WriteLine("--> Konus (Secim ucun 'f')");
            Console.WriteLine("--> Silindr (Secim ucun 'g')");
            Console.WriteLine("---> Sfera (Secim ucun 'h')");
            
        }
        static void Ucbucaq()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("UCBUCAQ BASLIGI \n\n\n");
            Console.WriteLine("--> Duzbucagli ucbucaq(secim-'k')\n" + "--> Beraberterefli ucbucaq(secim-'z')\n" + "--> Ixtiyari ucbucaq(secim-'x')");
            Console.WriteLine("ESC duymesini basin :");
        }

        static void Menu()
        {
            Console.WriteLine(" MENYU");
            Console.WriteLine("-------\n\n");
            Console.WriteLine("\\Novleri gormek ucun '1' duymesini vurun ./\n");
        }

        static void Welcome()
        {
            Console.WriteLine(" ************   Salam, Hendesi Fiqur Kalkulyatoruna xos gelmisiniz ************ \n\n");
            Console.WriteLine("\\ Bu program vasitesi ile bir cox hendesi fiqurun bezi funksiyalarinin qiymetini hesablaya bilersiniz ./\n");
            Console.WriteLine("\\ Menuya kecerek size lazim olan fiquru sece bilersiniz.Menuya kecmek ucun 'M' duymesini vurun ./\n\n\n");
        }
        #endregion
    }
}
