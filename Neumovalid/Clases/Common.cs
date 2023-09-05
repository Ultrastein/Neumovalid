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
                data["jeringa"]["nserie"] = "0".ToUpper();
                data["jeringa"]["propietario"] = "propierario1".ToUpper();




                parser.WriteFile("settings.ini", data);
            }

        }


        public static double calcular_desviacion(List<String> Items)
        {
            double datos_m = 0;
            //calcular media
            for (int i = 0; i < Items.Count; ++i)
            {
                datos_m += Convert.ToDouble(Items[i].ToString());
            }
            var tamano_muestra = Items.Count;
            var media = datos_m / tamano_muestra;
           
            //calcular varianza
            double datos_v = 0;
            for (int i = 0; i < Items.Count; ++i)
            {
                //conversion explicita a double para emplear el metodo pow
                datos_v += Math.Pow((Convert.ToDouble(Items[i].ToString()) - Convert.ToDouble(media)), 2); ;
            }
            var total_varianza = datos_v / (Items.Count - 1);

            if (Items.Count > 0 && datos_v>0)
            {

                return Math.Sqrt(total_varianza);

            }
            else { return 0; }
        }
        public static double calcular_media(List<String> Items)
        {
            double datos_m = 0;
            //calcular media
            for (int i = 0; i < Items.Count; ++i)
            {
                datos_m += Convert.ToDouble(Items[i].ToString());
            }
          
            var tamano_muestra = Items.Count;
            var media = datos_m / tamano_muestra;
           if (Items.Count > 0)
            {

                return media;

            }
            else
            {

                return 0;

            }
        }
        public static double calcular_coeficiente(double desvio, double promedio)
        {
            double resultado = 0;

            if (desvio > 0 && promedio>0)
            {
                resultado = (desvio / promedio) * 100;
            }

            return resultado;

        }
    }
}
