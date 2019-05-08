using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_App
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IDictionary datenstruktur = Program.EingabeStart();
                Program.TestSection(datenstruktur);
            }
            while(true);
           
        }

        static IDictionary EingabeStart()
        {
            Console.WriteLine("\n\n\n=============================================");
            Console.WriteLine("Algorithmen und Datenstrukturen ::: Praktikum");
            Console.WriteLine("=============================================");
            Console.WriteLine(">> Testapplikation \n\n");

            bool keineKorrekteEingabe = false;
            string eingabe = "";

            do
            {
                keineKorrekteEingabe = false;
                Console.WriteLine("Wähle eine Datenstruktur:");
                Console.WriteLine("1) MultiSet ");
                Console.WriteLine("2) Set ");
                Console.WriteLine("3) MultiSet sortiert ");
                Console.WriteLine("4) Set sortiert ");
                Console.WriteLine("5) Programm beenden ");
                eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Console.WriteLine("\nMultiSet wurde gewählt!");
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("\nSet wurde gewählt!");
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("\nMultiSet sortiert wurde gewählt!");
                }
                else if (eingabe == "4")
                {
                    Console.WriteLine("\nSet sortiert wurde gewählt!");
                }
                else if (eingabe == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\nEs wurde keine gültige Option gewählt!");
                    keineKorrekteEingabe = true;
                }


            }
            while (keineKorrekteEingabe);

            keineKorrekteEingabe = false;
            IDictionary datenstruktur = null;

            do
            {
                keineKorrekteEingabe = false;
                Console.WriteLine("\n\nWähle eine konkrete Implementierung:");
                Console.WriteLine("1) SetSortedArray ");
                Console.WriteLine("2) SetSortedLinkedList ");
                Console.WriteLine("3) BinSearchTree ");
                Console.WriteLine("4) AVL-Tree ");
                Console.WriteLine("5) Treap ");
                Console.WriteLine("6) Programm beenden ");
                eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Console.WriteLine("\nSetSortedArray wurde gewählt!");
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("\nSetSortedLinkedList wurde gewählt!");
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("\nBinSearchTree sortiert wurde gewählt!");
                }
                else if (eingabe == "4")
                {
                    Console.WriteLine("\nAVL-Tree sortiert wurde gewählt!");
                }
                else if (eingabe == "5")
                {
                    Console.WriteLine("\nTreap sortiert wurde gewählt!");
                }
                else if (eingabe == "6")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\nEs wurde keine gültige Option gewählt!");
                    keineKorrekteEingabe = true;
                }


            }
            while (keineKorrekteEingabe);

            return datenstruktur;
        }

        static void TestSection(IDictionary idict)
        {
            bool zurück = false;
            do
            {
                Console.WriteLine("\n\n\n=============================================");
                Console.WriteLine("Datenstruktur austesten ::: Wählen Sie eine Option:\n\n");
                Console.WriteLine("1) print");
                Console.WriteLine("2) Element einfügen");
                Console.WriteLine("3) Element löschen");
                Console.WriteLine("4) Element suchen");
                Console.WriteLine("5) zurück");

                string eingabe = Console.ReadLine();
                int zahl;

                if (eingabe == "1")
                {
                    idict.print();
                }
                else if (eingabe == "2")
                {
                    zahl = ganzePositiveZahlEingebenUndPruefen();
                    idict.insert(zahl);
                }
                else if (eingabe == "3")
                {
                    zahl = ganzePositiveZahlEingebenUndPruefen();
                    idict.delete(zahl);
                }
                else if (eingabe == "4")
                {
                    zahl = ganzePositiveZahlEingebenUndPruefen();
                    idict.search(zahl);
                }
                else if (eingabe == "5")
                {
                    zurück = true;
                }
                else
                {
                    Console.WriteLine("Keine gültige Option!");
                }
            }
            while (!zurück);

        }

        static int ganzePositiveZahlEingebenUndPruefen()
        {
            int zahl = 0;
            bool istKeineZahl = false;
            do
            {
                Console.WriteLine("Bitte eine positive ganze Zahl eingeben:");
                string key = Console.ReadKey().ToString();
                if (int.TryParse(key, out zahl))
                {
                    Console.WriteLine("{1} ist keine ganze positive Zahl! ");
                    istKeineZahl = true;
                }
            }
            while(istKeineZahl);
            return zahl;
        }

        

    }
}
