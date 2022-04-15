using System;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Colorful;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace faqTools
{
    internal class Program
    {
        // fields
        static Random rand = new Random();

        // properties
        static char AsciiCharacter
        {
            get
            {
                int t = rand.Next(10);
                if (t <= 2)
                    // returns a number
                    return (char)('0' + rand.Next(10));
                else if (t <= 4)
                    // small letter
                    return (char)('a' + rand.Next(27));
                else if (t <= 6)
                    // capital letter
                    return (char)('A' + rand.Next(27));
                else
                    // any ascii character
                    return (char)(rand.Next(32, 255));
            }
        }

        // methods
        [STAThread]
        private static void Main(string[] args)
        {
            Colorful.Console.Title = "✘ faqTools ✘ faq#6067 ✘ Main Menu";
            Thread.Sleep(1000);
            for (; ; )
            {
                Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                Thread.Sleep(721);
                Colorful.Console.WriteLine();
                Colorful.Console.Write("| ", Color.SlateGray);
                Colorful.Console.Write("Hello And Welcome To The Best Cracking Tools Script\n\n");
                Colorful.Console.Write("| ", Color.SlateGray);

                Colorful.Console.Write("Which Forums Would You Like To Visit First [");
                Colorful.Console.Write(" 1", Color.SlateGray);
                Colorful.Console.Write(" = ");

                Colorful.Console.Write("COMBO TOOLS", Color.SlateGray);
                Colorful.Console.Write("/");
                Colorful.Console.Write(" 2", Color.SlateGray);
                Colorful.Console.Write(" = ");
                Colorful.Console.Write("PROXY TOOLS", Color.SlateGray);
                Colorful.Console.Write("/");
                Colorful.Console.Write(" 3", Color.SlateGray);
                Colorful.Console.Write(" = ");
                Colorful.Console.Write("DEVELOPER", Color.SlateGray);


                Colorful.Console.Write("]\n\n");
                Colorful.Console.Write(">>  ", Color.SlateGray);
                string FORUMS = Colorful.Console.ReadLine();
                if (FORUMS == "1")
                {
                    Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ COMBO TOOLS";
                    Colorful.Console.Clear();
                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                    Thread.Sleep(721);
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Combo Tools Section\n\n");

                    Colorful.Console.Write(" 0 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Go Back\n");
                    Colorful.Console.Write(" 1 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Sort Combo A-Z\n");
                    Colorful.Console.Write(" 2 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Duplicate Remover\n");
                    Colorful.Console.Write(" 3 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Combo Line Counter\n");

                    Colorful.Console.Write(" 4 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Split Combo\n");
                    Colorful.Console.Write(" 5 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Filter Combo by Email Domain\n");
                    Colorful.Console.Write(" 6 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Extract Combo Lines (for Non Combo Files)\n");
                    Colorful.Console.Write(" 7 ", Color.SlateGray);
                    Colorful.Console.Write(" ~ ");
                    Colorful.Console.Write("Parse Combo ( Delete LQ Lines )\n");


                    Colorful.Console.Write(" - ", Color.SlateGray);
                    Colorful.Console.Write("=");


                    Colorful.Console.Write(" Exit\n", Color.SlateGray);



                    Colorful.Console.Write(" >> ", Color.SlateGray);
                    string pick = Colorful.Console.ReadLine();

                    if (pick == "-")
                    {
                        Environment.Exit(0);
                    }

                    if (pick == "0")
                    {
                        Colorful.Console.Clear();
                    }

                    if (pick == "1")
                    {


                        Colorful.Console.Clear();
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Thread.Sleep(721);
                        Colorful.Console.WriteLine();
                        string nameOfFile = "combo.txt";
                        Directory.CreateDirectory("Output\\Sort Combo");
                        string nameOfNewFile = "Output\\Sort Combo\\SortedWords.txt";
                        try
                        {
                            List<string> lines = new List<string>(File.ReadAllLines(nameOfFile));

                            lines.Sort();

                            var newFile = File.Create(nameOfNewFile);
                            newFile.Close();

                            File.WriteAllLines(nameOfNewFile, lines);

                            foreach (var line in lines)
                            {
                                Colorful.Console.WriteLine(line);
                            }
                        }
                        catch
                        {
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Error ! There is No '");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write("' File .\n\n");

                            Thread.Sleep(1000);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("....");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Colorful.Console.Clear();
                            Thread.Sleep(1000);
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Finished !\n\n");

                            File.CreateText("combo.txt");
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Insert Your ");
                            Colorful.Console.Write("Combo ", Color.SlateGray);
                            Colorful.Console.Write("in ");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write(" and restart the program \n\n");
                            Colorful.Console.Write(">> ", Color.SlateGray);

                            Colorful.Console.ReadKey();
                            Environment.Exit(0);
                        }

                        Colorful.Console.Write("\n\n# ", Color.SlateGray);
                        Colorful.Console.Write("The Script Has Been Finished ,");
                        Colorful.Console.Write(" Press ", Color.SlateGray);
                        Colorful.Console.Write("To Continue ");
                        Colorful.Console.ReadKey();
                        Colorful.Console.Clear();
                    }

                    if (pick == "2")
                    {
                        Directory.CreateDirectory("Output\\Duplicate Remover");
                        File.CreateText("Output\\Duplicate Remover\\Duplicate Remover.txt");
                        string nameOfFile = "combo.txt";
                        // string nameOfNewFile = @"D:\downloads\ElynoTools\faqTools\faqTools\bin\Debug\netcoreapp3.1\DuplicatesRemover.txt";
                        try
                        {
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Thread.Sleep(721);

                            Colorful.Console.WriteLine(string.Empty);
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("INFO : Remove Duplicate Lines as combo\n\n");
                            Colorful.Console.WriteLine(string.Empty);
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Deleting Duplicate Lines... Please Wait !\n\n\n");
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("This may take a long time... Depending on the Combo Size !\n\n");
                            Colorful.Console.WriteLine(string.Empty);
                            string[] source = File.ReadAllLines("combo.txt");
                            Directory.CreateDirectory("Output\\AntiDuplicate");
                            File.WriteAllLines("Output\\AntiDuplicate\\Combo_AntiDup.txt", source.Distinct<string>().ToArray<string>());
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Duplicate Lines Deleted and Saved in Output");
                            Colorful.Console.WriteLine(string.Empty);
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Press Any Key to Return to Home Screen\n\n", Color.Orange);
                            Colorful.Console.Write(">> ", Color.SlateGray);

                            Colorful.Console.ReadLine();
                            Colorful.Console.Clear();
                        }
                        catch
                        {
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Error ! There is No '");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write("' File .\n\n");

                            Thread.Sleep(1000);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("....");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Colorful.Console.Clear();
                            Thread.Sleep(1000);
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Finished !\n\n");

                            File.CreateText("combo.txt");
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Insert Your ");
                            Colorful.Console.Write("Combo ", Color.SlateGray);
                            Colorful.Console.Write("in ");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write(" and restart the program \n\n");
                            Colorful.Console.Write(">> ", Color.SlateGray);

                            Colorful.Console.ReadKey();
                            Environment.Exit(0);
                        }

                    }

                    if (pick == "3")
                    {
                        int counter = 0;
                        string line;
                        try
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader("combo.txt");
                            while ((line = file.ReadLine()) != null)
                            {
                                System.Console.WriteLine(line);
                                counter++;
                            }

                            file.Close();
                            Colorful.Console.Write("There were ", Color.SlateGray);
                            System.Console.Write("{0} ", counter);
                            Colorful.Console.Write("lines\n\n", Color.SlateGray);
                        }
                        catch
                        {
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Error ! There is No '");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write("' File .\n\n");

                            Thread.Sleep(1000);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("....");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Colorful.Console.Clear();
                            Thread.Sleep(1000);
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Finished !\n\n");

                            File.CreateText("combo.txt");
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Insert Your ");
                            Colorful.Console.Write("Combo ", Color.SlateGray);
                            Colorful.Console.Write("in ");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write(" and restart the program \n\n");
                            Colorful.Console.Write(">> ", Color.SlateGray);

                            Colorful.Console.ReadKey();
                            Environment.Exit(0);
                        }


                        Colorful.Console.Write("# ", Color.SlateGray);
                        Colorful.Console.Write("The Script Has Been Finished ,");
                        Colorful.Console.Write(" Press ", Color.SlateGray);
                        Colorful.Console.Write("To Continue ");
                        Colorful.Console.ReadKey();
                        Colorful.Console.Clear();
                    }

                    if (pick == "4")
                    {
                        Directory.CreateDirectory("Output\\Split");
                        Colorful.Console.Clear();
                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ COMBO TOOLS";
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("Please enter Number of Lines for each ");
                        Colorful.Console.Write("Split ", Color.SlateGray);
                        Colorful.Console.Write(":\n");
                        Colorful.Console.Write(">> ", Color.SlateGray);
                        string value = Colorful.Console.ReadLine();
                        int num = Convert.ToInt32(value);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("Parsing", Color.SlateGray);
                        Colorful.Console.Write(" Combo... , ");
                        Colorful.Console.Write("Please Wait !\n", Color.SlateGray);
                        Colorful.Console.WriteLine("This may take a long time... Depending on the Combo Size !");
                        Colorful.Console.WriteLine(string.Empty);
                        StreamReader streamReader = new StreamReader("combo.txt");
                        try
                        {
                            int num2 = 0;
                            while (!streamReader.EndOfStream)
                            {
                                int num3 = 0;
                                StreamWriter streamWriter = new StreamWriter("Output\\Split\\Combo Split" + ++num2 + ".txt");
                                try
                                {
                                    streamWriter.AutoFlush = true;
                                    while (!streamReader.EndOfStream && ++num3 < num)
                                    {
                                        streamWriter.WriteLine(streamReader.ReadLine());
                                    }
                                }
                                catch
                                {
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("| ", Color.SlateGray);
                                    Colorful.Console.Write("Error ! There is No '");
                                    Colorful.Console.Write("combo.txt", Color.SlateGray);
                                    Colorful.Console.Write("' File .\n\n");

                                    Thread.Sleep(1000);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write(".");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write("..");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write("...");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write("....");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write(".");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write("..");
                                    Thread.Sleep(730);
                                    Colorful.Console.Clear();
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("Creating ");
                                    Colorful.Console.Write("File", Color.SlateGray);
                                    Colorful.Console.Write("...");
                                    Colorful.Console.Clear();
                                    Thread.Sleep(1000);
                                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                                    Colorful.Console.Write("| ", Color.SlateGray);
                                    Colorful.Console.Write("Finished !\n\n");

                                    File.CreateText("combo.txt");
                                    Colorful.Console.Write("| ", Color.SlateGray);

                                    Colorful.Console.Write("Insert Your ");
                                    Colorful.Console.Write("Combo ", Color.SlateGray);
                                    Colorful.Console.Write("in ");
                                    Colorful.Console.Write("combo.txt", Color.SlateGray);
                                    Colorful.Console.Write(" and restart the program \n\n");
                                    Colorful.Console.Write(">> ", Color.SlateGray);

                                    Colorful.Console.ReadKey();
                                    Environment.Exit(0);
                                }
                                finally
                                {
                                    ((IDisposable)streamWriter).Dispose();
                                }
                            }
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                        Colorful.Console.Write("Combo ");
                        Colorful.Console.Write("converted ", Color.SlateGray);
                        Colorful.Console.Write("and ");
                        Colorful.Console.Write("Saved ", Color.SlateGray);
                        Colorful.Console.Write("in Output\n");
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.WriteLine("Press Any Key to Return to Home Screen", Color.SlateGray);
                        Colorful.Console.ReadLine();
                        Colorful.Console.Clear();
                    }

                    if (pick == "5")
                    {
                        Directory.CreateDirectory("Output\\Filter Combo");
                        Colorful.Console.Clear();
                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ COMBO TOOLS";
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("INFO: for now, Filter is ");
                        Colorful.Console.Write("limited\n\n", Color.SlateGray);
                        Colorful.Console.Write(">>", Color.SlateGray);

                        Colorful.Console.Write(" GMAIL ");
                        Colorful.Console.Write(" - ", Color.SlateGray);
                        Colorful.Console.Write("HOTMAIL");
                        Colorful.Console.Write(" - ", Color.SlateGray);
                        Colorful.Console.Write("YAHOO");
                        Colorful.Console.Write(" - ", Color.SlateGray);
                        Colorful.Console.Write("OTHERS ");
                        Colorful.Console.Write("<<\n", Color.SlateGray);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("Filtering", Color.SlateGray);

                        Colorful.Console.WriteLine(" Combo... Please Wait !");
                        Colorful.Console.Write("This may take a ");
                        Colorful.Console.Write("long time", Color.SlateGray);
                        Colorful.Console.Write("... Depending on the Combo Size !\n");
                        Colorful.Console.WriteLine("You can see that is working in the Output Folder !");
                        Colorful.Console.WriteLine(string.Empty);
                        Regex regex = new Regex(".*@hotmail.*");
                        Regex regex2 = new Regex(".*@yahoo.*");
                        Regex regex3 = new Regex(".*@gmail.*");
                        Regex regex4 = new Regex("^(?!.*(@hotmail|@gmail|@yahoo)).*$");
                        StreamReader streamReader = new StreamReader("combo.txt");
                        try
                        {
                            string input;
                            while ((input = streamReader.ReadLine()) != null)
                            {
                                foreach (object obj in regex.Matches(input))
                                {
                                    Match match = (Match)obj;
                                    File.AppendAllText("Output\\Filter Combo\\Hotmail.txt", string.Concat(new object[]
                                    {
                        match,
                        Environment.NewLine
                                    }));
                                }
                                foreach (object obj2 in regex2.Matches(input))
                                {
                                    Match match2 = (Match)obj2;
                                    File.AppendAllText("Output\\Filter Combo\\Yahoo.txt", string.Concat(new object[]
                                    {
                        match2,
                        Environment.NewLine
                                    }));
                                }
                                foreach (object obj3 in regex3.Matches(input))
                                {
                                    Match match3 = (Match)obj3;
                                    File.AppendAllText("Output\\Filter Combo\\Gmail.txt", string.Concat(new object[]
                                    {
                        match3,
                        Environment.NewLine
                                    }));
                                }
                                foreach (object obj4 in regex4.Matches(input))
                                {
                                    Match match4 = (Match)obj4;
                                    File.AppendAllText("Output\\Filter Combo\\Others.txt", string.Concat(new object[]
                                    {
                        match4,
                        Environment.NewLine
                                    }));
                                }
                            }
                        }
                        catch
                        {
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Error ! There is No '");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write("' File .\n\n");

                            Thread.Sleep(1000);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("....");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write(".");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("..");
                            Thread.Sleep(730);
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("Creating ");
                            Colorful.Console.Write("File", Color.SlateGray);
                            Colorful.Console.Write("...");
                            Colorful.Console.Clear();
                            Thread.Sleep(1000);
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Finished !\n\n");

                            File.CreateText("combo.txt");
                            Colorful.Console.Write("| ", Color.SlateGray);

                            Colorful.Console.Write("Insert Your ");
                            Colorful.Console.Write("Combo ", Color.SlateGray);
                            Colorful.Console.Write("in ");
                            Colorful.Console.Write("combo.txt", Color.SlateGray);
                            Colorful.Console.Write(" and restart the program \n\n");
                            Colorful.Console.Write(">> ", Color.SlateGray);

                            Colorful.Console.ReadKey();
                            Environment.Exit(0);
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                        Colorful.Console.WriteLine("Combo Filtered and Saved in Output", Color.LimeGreen);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.WriteLine("Press Any Key to Return to Home Screen", Color.Orange);
                        Colorful.Console.ReadLine();
                        Colorful.Console.Clear();
                    }

                    if (pick == "6")
                    {
                        Colorful.Console.Clear();
                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ COMBO TOOLS";
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("Extracting Combos... Please Wait !\n\n");
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.WriteLine("This may take a long time... Depending on the Combo Size !\n");
                        Colorful.Console.WriteLine(string.Empty);
                        Regex regex = new Regex("[a-zA-Z0-9._\\-]{4,25}@[a-zA-Z0-9]{2,15}.[a-zA-Z0-9]{2,6}:[a-zA-Z0-9.@$_\\-]{6,25}");
                        StreamReader streamReader = new StreamReader("combo.txt");
                        try
                        {
                            string input;
                            while ((input = streamReader.ReadLine()) != null)
                            {
                                foreach (object obj in regex.Matches(input))
                                {
                                    Match match = (Match)obj;
                                    Directory.CreateDirectory("Output\\Extracted Combo");
                                    File.AppendAllText("Output\\Extracted Combo\\Combo_Extracted.txt", string.Concat(new object[]
                                    {
                        match,
                        Environment.NewLine
                                    }));
                                }
                            }
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                        Colorful.Console.WriteLine("Combos Extracted and Saved in Output", Color.LimeGreen);
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.WriteLine("Press Any Key to Return to Home Screen", Color.Orange);
                        Colorful.Console.ReadLine();
                        Colorful.Console.Clear();
                    }

                    if (pick == "7")
                    {
                        Colorful.Console.Clear();
                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ COMBO TOOLS";
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Colorful.Console.WriteLine(string.Empty);

                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("Parsing Combo... Please Wait !\n\n");

                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("This may take a long time... Depending on the Combo Size !\n");
                        Colorful.Console.WriteLine(string.Empty);
                        Regex regex = new Regex("[a-zA-Z0-9._\\-]{4,25}@[a-zA-Z0-9]{2,15}.[a-zA-Z0-9]{2,6}:[a-zA-Z0-9.@$_\\-]{6,25}");
                        StreamReader streamReader = new StreamReader("combo.txt");
                        try
                        {
                            string input;
                            while ((input = streamReader.ReadLine()) != null)
                            {
                                foreach (object obj in regex.Matches(input))
                                {
                                    Match match = (Match)obj;
                                    Directory.CreateDirectory("Output\\ComboParsed");
                                    File.AppendAllText("Output\\ComboParsed\\Combo_Parsed.txt", string.Concat(new object[]
                                    {
                        match,
                        Environment.NewLine
                                    }));
                                }
                            }
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                        Colorful.Console.Write("| ", Color.SlateGray);

                        Colorful.Console.Write("Duplicate Lines Deleted and Saved in Output\n\n");
                        Colorful.Console.WriteLine(string.Empty);
                        Colorful.Console.Write("| ", Color.SlateGray);

                        Colorful.Console.Write("Press Any Key to Return to Home Screen\n\n", Color.Orange);
                        Colorful.Console.Write(">> ", Color.SlateGray);

                        Colorful.Console.ReadLine();
                        Colorful.Console.Clear();
                    }

                    if (FORUMS == "2")
                    {

                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ PROXY TOOLS";
                        Colorful.Console.Clear();
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Thread.Sleep(721);
                        Colorful.Console.WriteLine();
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("PROXY Tools Section\n\n");
                        Colorful.Console.Write(" 0 ", Color.SlateGray);
                        Colorful.Console.Write(" ~ ");
                        Colorful.Console.Write("Go Back\n");
                        Colorful.Console.Write(" 1 ", Color.SlateGray);
                        Colorful.Console.Write(" ~ ");
                        Colorful.Console.Write("PROXY SCRAPER\n");
                        Colorful.Console.Write(" 2 ", Color.SlateGray);
                        Colorful.Console.Write(" ~ ");
                        Colorful.Console.Write("PROXY CHECKER ");
                        Colorful.Console.Write("[", Color.SlateGray);
                        Colorful.Console.Write(" NOT WORKING ");
                        Colorful.Console.Write("]\n", Color.SlateGray);




                        string choose = Colorful.Console.ReadLine();

                        if (choose == "0")
                        {
                            Colorful.Console.Clear();
                        }

                        if (choose == "1")
                        {
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Thread.Sleep(721);
                            Colorful.Console.WriteLine();
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Which proxy protocol would you like? [", Color.GhostWhite);
                            Colorful.Console.Write("HTTP", Color.SlateGray);
                            Colorful.Console.Write("/");
                            Colorful.Console.Write("SOCKS4", Color.SlateGray);
                            Colorful.Console.Write("/");
                            Colorful.Console.Write("SOCKS5", Color.SlateGray);




                            Colorful.Console.Write("]", Color.GhostWhite);
                            Colorful.Console.WriteLine();
                            Colorful.Console.WriteLine();
                            Colorful.Console.Write(">> ", Color.SlateGray);
                            string text = Colorful.Console.ReadLine();
                            Colorful.Console.WriteLine();
                            Colorful.Console.Write("");
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Timeout? [", Color.GhostWhite);
                            Colorful.Console.Write("this must be between 50 - 10000", Color.SlateGray);
                            Colorful.Console.Write("]", Color.GhostWhite);
                            Colorful.Console.Write(">> ", Color.SlateGray);
                            int num = Convert.ToInt32(Colorful.Console.ReadLine());
                            Colorful.Console.WriteLine();
                            Colorful.Console.WriteLine();
                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Scraping.. ", Color.GhostWhite);
                            WebClient webClient = new WebClient();
                            DateTime.Now.ToString().Replace(":", "-");
                            string value = webClient.DownloadString(string.Format("https://api.proxyscrape.com/?request=displayproxies&proxytype={0}&timeout={1}", text, num));
                            Thread.Sleep(500);
                            Directory.CreateDirectory("Output\\Proxy");
                            using (StreamWriter streamWriter = File.AppendText(string.Format("Output\\Proxy\\Timeout - {0} Protocol - {1} .txt", num.ToString(), text)))
                            {
                                streamWriter.WriteLine(value);
                            }
                            Colorful.Console.WriteLine();
                            Colorful.Console.Write("\n# ", Color.SlateGray);
                            Colorful.Console.Write("The Script Has Been Finished ,");
                            Colorful.Console.Write(" Press ", Color.SlateGray);
                            Colorful.Console.Write("To Continue ");
                            Colorful.Console.ReadKey();
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine();
                        }

                        if (choose == "2")
                        {
                            Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ PROXY TOOLS";
                            Colorful.Console.Clear();
                            Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                            Thread.Sleep(721);

                            Colorful.Console.Write("| ", Color.SlateGray);
                            Colorful.Console.Write("Proxy Checker isnt Working Currently !\n\n");
                            Colorful.Console.Write(">> ", Color.SlateGray);
                            Colorful.Console.ReadLine();

                        }
                    }

                    if (FORUMS == "3")
                    {
                        Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ DEVELOPER";
                        Colorful.Console.Clear();
                        Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                        Thread.Sleep(721);
                        Colorful.Console.WriteLine();
                        Colorful.Console.Write("| ", Color.SlateGray);
                        Colorful.Console.Write("The Developer Of This Script is: ");
                        Colorful.Console.Write("VXDON#2602\n\n", Color.SlateGray);
                    }
                }

                if (FORUMS == "2")
                {
                    Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ PROXY TOOLS";
                    Colorful.Console.Clear();
                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                    Thread.Sleep(721);
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Which proxy protocol would you like? [", Color.GhostWhite);
                    Colorful.Console.Write("HTTP", Color.SlateGray);
                    Colorful.Console.Write("/");
                    Colorful.Console.Write("SOCKS4", Color.SlateGray);
                    Colorful.Console.Write("/");
                    Colorful.Console.Write("SOCKS5", Color.SlateGray);


                    Colorful.Console.Write("]", Color.GhostWhite);
                    Colorful.Console.WriteLine();
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write(">> ", Color.SlateGray);
                    string text = Colorful.Console.ReadLine();
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("");
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Timeout? [", Color.GhostWhite);
                    Colorful.Console.Write("this must be between 50 - 10000", Color.SlateGray);
                    Colorful.Console.Write("]", Color.GhostWhite);
                    Colorful.Console.Write(">> ", Color.SlateGray);
                    int num = Convert.ToInt32(Colorful.Console.ReadLine());
                    Colorful.Console.WriteLine();
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Scraping.. ", Color.GhostWhite);
                    WebClient webClient = new WebClient();
                    DateTime.Now.ToString().Replace(":", "-");
                    string value = webClient.DownloadString(string.Format("https://api.proxyscrape.com/?request=displayproxies&proxytype={0}&timeout={1}", text, num));
                    Thread.Sleep(500);
                    Directory.CreateDirectory("Output\\Proxy");
                    using (StreamWriter streamWriter = File.AppendText(string.Format("Output\\Proxy\\Timeout - {0} Protocol - {1} .txt", num.ToString(), text)))
                    {
                        streamWriter.WriteLine(value);
                    }
                    Colorful.Console.WriteLine();
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Finished scraping", Color.GhostWhite);
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Press X to exit, P to scrape a different protocol");
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write(">> ", Color.SlateGray);
                    string a = Colorful.Console.ReadLine().ToUpper();
                    Colorful.Console.Clear();
                    if (a == "X")
                    {
                        Environment.Exit(0);

                    }
                    else
                    {
                        //
                    }
                }
            
                if (FORUMS == "3")
                {
                    Colorful.Console.Title = "faqTools ✘ faq#6067 ✘ Developer Section";
                    Colorful.Console.Clear();
                    Colorful.Console.WriteLine("\n\t\t  █████▒▄▄▄        █████  ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ \n\t\t▓██   ▒▒████▄    ▒██▓  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ \n\t\t▒████ ░▒██  ▀█▄  ▒██▒  ██░▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   \n\t\t░▓█▒  ░░██▄▄▄▄██ ░██  █▀ ░░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒\n\t\t░▒█░    ▓█   ▓██▒░▒███▒█▄   ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒\n\t\t ▒ ░    ▒▒   ▓▒█░░░ ▒▒░ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░\n\t\t ░       ▒   ▒▒ ░ ░ ▒░  ░     ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░\n\t\t ░ ░     ░   ▒      ░   ░   ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  \n\t\t             ░  ░    ░                 ░ ░      ░ ░      ░  ░      ░  \n\t\t                                                                      \n\n", Color.SlateGray);
                    Thread.Sleep(721);
                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Salman Alwan  ", Color.GhostWhite);
                    Colorful.Console.Write("aka", Color.SlateGray);
                    Colorful.Console.Write("Justfaq is the Developer of this tool.");

                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Github:  ", Color.GhostWhite);
                    Colorful.Console.Write("Justfaq", Color.SlateGray);

                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Instagram: ", Color.GhostWhite);
                    Colorful.Console.Write("salman.alwan", Color.SlateGray);
                    Colorful.Console.Write("/", Color.GhostWhite);
                    Colorful.Console.Write("justtfaq", Color.SlateGray);

                    Colorful.Console.WriteLine();
                    Colorful.Console.Write("");
                    Colorful.Console.Write("| ", Color.SlateGray);
                    Colorful.Console.Write("Press ", Color.GhostWhite);
                    Colorful.Console.Write("any", Color.SlateGray);
                    Colorful.Console.Write(" key to continue...", Color.GhostWhite);
                    
                    var num = Colorful.Console.ReadLine();
                    Colorful.Console.Clear();

                }
            }
        }
    }
}



