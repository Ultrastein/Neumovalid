using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Neumavalid.Clases
{
    public class Common
    {
        public static int getNumericValue(string value, int defaultVal = 1)
        {
            int a = 1;

            bool res;
            res = int.TryParse(value, out a);
            if (res == false) { return defaultVal; }
            return a;

        }
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

            public static Color colorGreen = Color.FromArgb(0, 255, 0);
        }
        public static void checkIniFileExistAndFill()
        {
            var parser = new FileIniDataParser();
            IniData data;
            if (System.IO.File.Exists("settings.ini") == false)
            {


                data = new IniData();
                data["Sensor"]["Volumen"] = "1".ToUpper();
                data["Sensor"]["Humedad"] = "2".ToUpper();
                data["Sensor"]["Presion"] = "3".ToUpper();
                data["Sensor"]["Temperatura"] = "4".ToUpper();
                data["COM"]["Default"] = "COM3";
                data["rxtx"]["eliminar_r"] = "1";
                data["rxtx"]["enviar_r"] = "1";
                data["rxtx"]["eliminar_n"] = "1";
                data["rxtx"]["enviar_n"] = "1";
                data["comandos"]["iniciar"] = "I";
                data["comandos"]["detener"] = "F";
                data["jeringa"]["marca"] = "marca1;marca2".ToUpper();
                data["jeringa"]["modelo"] = "modelo1;modelo2".ToUpper();
                data["referente"]["personas"] = "persona1;persona2".ToUpper();
                parser.WriteFile("settings.ini", data);
            }

        }
    }
}
