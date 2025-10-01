using static System.Math;
using static System.Convert;



namespace Physium
{
    public static class App
    {
        public static string Ver()
        {
            return "v1.0.0";
        }
        public static string Type()
        {
            return "Console Application";
        }
        public static string Lang()
        {
            return "C# Application";
        }
        public static string BaseVer()
        {
            return "C# .NET SDK v9.0.0";
        }
        public static string Desc()
        {
            return "Physics Solver for the Windows x64/ARM 64/AMD64/x86 Machines";
        }
        public static string Info()
        {
            return ("Physium Formulae: Physics Solver \n" + "App Version: " + Ver() + "\n" + "App Type: " + Type() + "\n" + "App Language: " + Lang() + "\n" + "App Language Version: " + BaseVer() + "\n" + "App Description: " + Desc() + "\n" + "Tips for Best Usage: \n" + "* Use Full Screen");
        }
    }
    class Formulae
    {
        static void Wait()
        {
            Input();
        }
        static void cls()
        {
            Console.Clear();
        }
        static void Text(string str)
        {
            Console.WriteLine(str);
        }
        static string Input()
        {
        Input:
            string str = Console.ReadLine() ?? "";
            if (str == null)
            {
                goto Input;
            }
            return str;
        }
        static void Main(string[] args)
        {
        Main:
            cls();
            Text("Type anything to Continue, Type Info or Help for Application Information. (Recommended)");
            string Opt = Input();
            if (Opt == "Info" || Opt == "info" || Opt == "Help" || Opt == "help")
            {
                goto AppInfo;
            }
            else
            {
                goto Program;
            }
        AppInfo:
            cls();
            Text(App.Info());
            Wait();
            goto Main;
        Program:
            cls();
            Text("       Physium Formulae: Windows Physics Solver");
            Text("\n                    Main Menu");
            Text("\n                    [1] Solver Menu");
            Text("\n                    [2] Formulas");
            Text("\n                    [3] Exit Program");
            string Menukey = Input();
            cls();
            if (Menukey == "1")
            {
            CASE_1:
                cls();
                Text("\n       Physium Formulae: Windows Physics Solver");
                Text("\n               Solver Menu");
                Text("\n               [1] GPE");
                Text("\n               [2] Force");
                Text("\n               [3] Ohm's Law");
                Text("\n               [4] Speed/Velocity");
                Text("\n               [5] Density - WIP");
                string solkey = Input();
                cls();
                switch (solkey)
                {
                    case "1":
                    GPE:
                        cls();
                        Text("\n       Physium Formulae: Windows Physics Solver");
                        Text("\n               GPE Menu || Solve for:");
                        Text("\n                   [1] GPE");
                        Text("\n                   [2] Mass");
                        Text("\n                   [3] Accel. to Gravity");
                        Text("\n                   [4] Height");
                        Text("\n                   [5] Back");
                        string GPEKey = Input();
                        cls();
                        if (GPEKey == "1")
                        {
                            Text("Mass = ? (Double)");
                            string Mstr = Input();
                            double Mass = ToDouble(Mstr);
                            cls();
                            Text("Accel. to Gravity = ? (Double Format) (Accel. to Gravity = 9.80665 m/s^2 [~9.8m/s^2])");
                            string Gstr = Input();
                            double G = ToDouble(Gstr);
                            cls();
                            Text("Height = ? (Double)");
                            string Hstr = Input();
                            double H = ToDouble(Hstr);
                            cls();
                            double GPE = Mass * G * H;
                            string GPEstr = GPE.ToString();
                            Text("GPE = " + GPEstr + " Joules");
                            Wait();
                            goto Program;
                        }
                        else if (GPEKey == "2")
                        {
                            Text("Accel. to Gravity = ? (Double Format) (Accel. to Gravity = 9.80665 m/s^2 [~9.8m/s^2])");
                            string Gstr = Input();
                            double G = ToDouble(Gstr);
                            cls();
                            Text("Height = ? (Double)");
                            string Hstr = Input();
                            double H = ToDouble(Hstr);
                            cls();
                            Text("GPE = ? (Double)");
                            string GPEstr = Input();
                            double GPE = ToDouble(GPEstr);
                            cls();
                            double M = GPE / (G * H);
                            string Mstr = M.ToString();
                            Text("Mass = " + Mstr + "kg");
                            Wait();
                            goto Program;
                        }
                        else if (GPEKey == "3")
                        {
                            Text("Mass = ? (Double)");
                            string Mstr = Input();
                            double Mass = ToDouble(Mstr);
                            cls();
                            Text("Height = ? (Double)");
                            string Hstr = Input();
                            double H = ToDouble(Hstr);
                            cls();
                            Text("GPE = ? (Double)");
                            string GPEstr = Input();
                            double GPE = ToDouble(GPEstr);
                            cls();
                            double g = GPE / (Mass * H);
                            Text("Acceleration to Gravity = " + g.ToString() + "m/s^2");
                            Wait();
                            goto Program;
                        }
                        else if (GPEKey == "4")
                        {
                            Text("Mass = ? (Double)");
                            string Mstr = Input();
                            double Mass = ToDouble(Mstr);
                            cls();
                            Text("Accel. to Gravity = ? (Double Format) (Accel. to Gravity on Earth = 9.80665 m/s^2 [~9.8m/s^2])");
                            string Gstr = Input();
                            double G = ToDouble(Gstr);
                            cls();
                            Text("GPE = ? (Double)");
                            string GPEstr = Input();
                            double GPE = ToDouble(GPEstr);
                            cls();
                            double H = GPE / (Mass * G);
                            Text("Height = " + H.ToString() + " meters");
                            Wait();
                            goto Program;
                        }
                        else if (GPEKey == "5")
                        {
                            goto CASE_1;
                        }
                        else
                        {
                            goto GPE;
                        }
                    case "2":
                    Force:
                        cls();
                        Text("\n       Physium Formulae: Windows Physics Solver");
                        Text("\n             Force Menu || Solve for:");
                        Text("\n                  [1] Force");
                        Text("\n                  [2] Mass");
                        Text("\n                  [3] Acceleration");
                        Text("\n                  [4] Go Back");
                        string Forcekey = Input();
                        cls();
                        switch (Forcekey)
                        {
                            case "1":
                                Text("Mass = ? (Double)");
                                string Mstr = Input();
                                double Mass = ToDouble(Mstr);
                                cls();
                                Text("Acceleration = ? (Double Format) (Accel. to Gravity on Earth = 9.80665 m/s^2 [~9.8m/s^2])");
                                string Astr = Input();
                                double A = ToDouble(Astr);
                                cls();
                                double F = Mass * A;
                                Text("Force = " + F.ToString());
                                Wait();
                                goto Program;
                            case "2":
                                Text("Acceleration = ? (Double Format) (Accel. to Gravity on Earth = 9.80665 m/s^2 [~9.8m/s^2])");
                                string Acstr = Input();
                                double Ac = ToDouble(Acstr);
                                cls();
                                Text("Force = ? (Double)");
                                string Fstr = Input();
                                double Fo = ToDouble(Fstr);
                                cls();
                                double M = Fo / Ac;
                                Text("Mass = " + M.ToString() + " kg");
                                Wait();
                                goto Program;
                            case "3":
                                Text("Force = ? (Double)");
                                string Fostr = Input();
                                double Forc = ToDouble(Fostr);
                                cls();
                                Text("Mass = ? (Double)");
                                string Mastr = Input();
                                double Ma = ToDouble(Mastr);
                                cls();
                                double Accele = Forc / Ma;
                                Text("Acceleration = " + Accele.ToString() + "m/s^2");
                                Wait();
                                goto Program;
                            case "4":
                                goto CASE_1;
                            default:
                                goto Force;
                        }
                    case "3":
                    Ohm:
                        cls();
                        Text("\n       Physium Formulae: Windows Physics Solver");
                        Text("\n              Ohm's Law Menu || Solve for:");
                        Text("\n                 [1] Voltage");
                        Text("\n                 [2] Current");
                        Text("\n                 [3] Resistance");
                        Text("\n                 [4] Go Back");
                        string Ohmkey = Input();
                        cls();
                        switch (Ohmkey)
                        {
                            case "1":
                                Text("Current = ?");
                                string Current = Input();
                                double C = ToDouble(Current);
                                cls();
                                Text("Resistance = ?");
                                string Resistance = Input();
                                double R = ToDouble(Resistance);
                                cls();
                                double Voltage = C * R;
                                Text("Voltage = " + Voltage.ToString() + " Volts");
                                Wait();
                                goto Program;
                            case "2":
                                Text("Voltage = ?");
                                string V = Input();
                                double Volts = ToDouble(V);
                                cls();
                                Text("Resistance = ?");
                                string Res = Input();
                                double Re = ToDouble(Res);
                                cls();
                                double Cur = Volts / Re;
                                Text("Current = " + Cur.ToString() + " Amperes");
                                Wait();
                                goto Program;
                            case "3":
                                Text("Voltage = ?");
                                string Volt = Input();
                                double Vol = ToDouble(Volt);
                                cls();
                                Text("Current = ?");
                                string I = Input();
                                double Cu = ToDouble(I);
                                cls();
                                double Resi = Vol / Cu;
                                Text("Resistance = " + Resi.ToString() + " Ohms");
                                Wait();
                                goto Program;
                            case "4":
                                goto CASE_1;
                            default:
                                goto Ohm;
                        }
                    case "4":
                    Velocity:
                        cls();
                        Text("\n       Physium Formulae: Windows Physics Solver");
                        Text("\n            Speed/Velocity Menu || Solve for:");
                        Text("\n                 [1] Speed/Velocity");
                        Text("\n                 [2] Distance");
                        Text("\n                 [3] Time");
                        Text("\n                 [4] Go Back");
                        string VMenukey = Input();
                        cls();
                        switch (VMenukey)
                        {
                            case "1":
                                Text("Distance = ? Double");
                                string Distance = Input();
                                double Dist = ToDouble(Distance);
                                cls();
                                Text("Time = ? Double");
                                string Time = Input();
                                double Tim = ToDouble(Time);
                                cls();
                                double Speed = Dist / Tim;
                                Text("Velocity/Speed = " + Speed.ToString() + " m/s");
                                Wait();
                                goto Program;
                            case "2":
                                Text("Velocity/Speed = ? Double");
                                string Velocity = Input();
                                double Ve = ToDouble(Velocity);
                                cls();
                                Text("Time = ? Double");
                                string T = Input();
                                double Ti = ToDouble(T);
                                cls();
                                double Distan = Ve / Ti;
                                Text("Distance = " + Distan.ToString() + " meters");
                                Wait();
                                goto Program;
                            case "3":
                                Text("Velocity/Speed = ? Double");
                                string S = Input();
                                double Sp = ToDouble(S);
                                cls();
                                Text("Distance = ? Double");
                                string Dista = Input();
                                double Dis = ToDouble(Dista);
                                cls();
                                double t = Sp / Dis;
                                Text("Time = " + t.ToString() + " seconds");
                                Wait();
                                goto Program;
                            case "4":
                                goto Program;
                            default:
                                goto Velocity;
                        }
                        case "5":
                        Density:
                            cls();
                            Text("\n       Physium Formulae: Windows Physics Solver");
                            Text("\n            Density Menu || Solve for:");
                            Text("\n                 [1] Density");
                            Text("\n                 [2] Mass");
                            Text("\n                 [3] Volume");
                            Text("\n                 [4] Go Back");
                            string Densitykey = Input();
                            cls();
                            switch (Densitykey)
                            {
                                case "1":
                                    Text("Mass = ? Double");
                                    string Mass = Input();
                                    double Ma = ToDouble(Mass);
                                    cls();
                                    Text("Volume = ? Double");
                                    string Volume = Input();
                                    double Vol = ToDouble(Volume);
                                    cls();
                                    double Density = Ma / Vol;
                                    Text("Density = " + Density.ToString() + " kg/m^3");
                                    Wait();
                                    goto Program;
                                case "2":
                                    Text("Density = ? Double");
                                    string Dens = Input();
                                    double De = ToDouble(Dens);
                                    cls();
                                    Text("Volume = ? Double");
                                    string Vo = Input();
                                    double V = ToDouble(Vo);
                                    cls();
                                    double M = De * V;
                                    Text("Mass = " + M.ToString() + " kg");
                                    Wait();
                                    goto Program;
                                case "3":
                                    Text("Density = ? Double");
                                    string D = Input();
                                    double Den = ToDouble(D);
                                    cls();
                                    Text("Mass = ? Double");
                                    string Mas = Input();
                                    double Masss = ToDouble(Mas);
                                    cls();
                                    double Volu = Masss / Den;
                                    Text("Volume = " + Volu.ToString() + " m^3");
                                    Wait();
                                    goto Program;
                                case "4":
                                    goto CASE_1;
                                default:
                                    goto Density;
                            }
                    default:
                        goto CASE_1;
                }
            }
            else if (Menukey == "2")
            {
                cls();
                Text("\n       Physium Formulae: Windows Physics Solver");
                Text("\n              Formulas:");
                Text("\n              1) GPE = Mass * g * Height");
                Text("\n              2) Mass = GPE / (g * Height)");
                Text("\n              3) Height = GPE / (g * Mass)");
                Text("\n              4) g = GPE / (Mass * Height)");
                Text("\n              5) Force = Mass * Acceleration");
                Text("\n              6) Mass = Force / Acceleration");
                Text("\n              7) Acceleration = Force / Mass");
                Text("\n              8) Voltage = Current * Resistance");
                Text("\n              9) Current = Voltage / Resistance");
                Text("\n              10) Resistance = Voltage / Current");
                Text("\n              11) Speed = Distance / Time");
                Text("\n              12) Velocity = Displacement / Time");
                Wait();
                goto Program;
            }
            else if (Menukey == "3")
            {
                goto End;
            }
            else
            {
                goto Program;
            }
        End:
            cls();
        }
    }
}

