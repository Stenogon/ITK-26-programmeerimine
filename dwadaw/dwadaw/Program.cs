namespace dwadaw
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("datatypes");

            //string e tähemärkide jada, mis on defineeritud andmetüübiga string saab sisestada kõike, mis on klaviatuuril

            string name = "John Doe";
            Console.WriteLine(name);
            string one = "1";
            string two = "-2";
            string three = "-3";
            //see on stringide liitmine, mis tähendab, et need kaks stringi liidetakse kokku
            //NB! ei toimu matemaatilist lisamist, vaid lihtsalt stringide ühendamine
            Console.WriteLine(one + two + three);

            Console.WriteLine("----Täisarvud----");
            //int on andmetüüp, mis on defineeritud andmetüübiga int
            int age = 25;
            //lisada teine täisarv ja saada konsoolis kahe liitumise tulemuseks 30
            int add = 5;
            Console.WriteLine(age + add);

            Console.WriteLine("----Byte----");
            //byte andmetüüp, mis toetab täiarve vahemikus 0 kuni 255 see on kasulik, kui on vaja salvestada väikeseid täisarve 8-bitine täisarv
            byte myByte = 255;
            Console.WriteLine(myByte);

            Console.WriteLine("----Short----");
            // short on antmetüüp, mis toetab täisarve vahemikus -32,768 kuni 32,767 see on kasulik, kui on vaja salvestada keskmise suurusega täisarve 16-bitine täisarv
            short myShort = 32767;
            Console.WriteLine(myShort);

            Console.WriteLine("----long----");
            //long on andmetüüp, mis toetab täisarve vahemikus -9,223,372,836,854,77,808 kuni 9,223,372,836,854,77,807 see on kasulikm kui on vaja salvestada suuri täisarve 64-bitine täisarv
            long myLong = 922337203685477807L;
            Console.WriteLine(myLong);

            Console.WriteLine("----float----");

            //float on andmetüüp, mis toetab ujukoomarve see on kasulik, kui on vaja salvestada arve, mis sisaldavad komakohta 32-bitiline ujukomaarv
            float myFloat = 3.14f;
            Console.WriteLine(myFloat);

            Console.WriteLine("----double----");
            //double on andmetüüp, mis toetab ujukomaarv see on kasulik, kui on vaja salvestada arve, mis sisaldab komakohti 64-bitine ujukomaarv
            double myDouble = 3.123195967650345347841;
            Console.WriteLine(myDouble);

            Console.WriteLine("----dencimal----");
            //dencimal on andmetüüp, mis toetab ujukomaarv see on kasulik, kui on vaja salvestada arve, mis nõuavad täpsust 128-bitine ujukomarv
            decimal mydecimal = 3.93928378567928370981250476154970213765689847657465064305602340734645280475680363456M;
            Console.WriteLine(mydecimal);

            Console.WriteLine("----boolean----");
            //bool on andmetüüp, mis toetab tõeväärtusi see on kasulik, kui on vaja salvestada tõeväärtused
            bool isTrue = true;
            Console.WriteLine(isTrue);
            bool isfalse = false;
            Console.WriteLine(isfalse);
        }
    }
}
