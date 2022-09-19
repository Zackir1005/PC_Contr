using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Contr
{
    delegate void myDelegate(string _str);
    class PC
    {
        public string Name;
        private string nameOfDisplay, nameOfPCBox, nameOfKeyboard, nameOfMouse, empty = "<none>";
        public myDelegate myAction;
        public struct Example
        {
            public string Motherboard;
            public int PCMemory;
            public string Processor;
            public string Disc;
            public string PowSupUnit;
            public string PCBody;
        }
        public void inPCBox()
        {

            Example _inPCBox = new Example();
            Console.WriteLine("Введите имя материнской платы : ");
            _inPCBox.Motherboard = Console.ReadLine();
            Console.WriteLine("Введите количество Памяти (в гб): ");
            bool TrueFalse = true;
            do
            {
                try
                {
                    _inPCBox.PCMemory = Int32.Parse(Console.ReadLine());
                    TrueFalse = false;
                }
                catch
                {
                    Console.WriteLine("ОШИБКА!ПОПРОБУЙТЕ ЕЩЁ РАЗ!");
                }
            } while (TrueFalse);
            Console.WriteLine("Введите имя процессора : ");
            _inPCBox.Processor = Console.ReadLine();
            Console.WriteLine("Введите имя диска : ");
            _inPCBox.Disc = Console.ReadLine();
            Console.WriteLine("Введите имя блока питания : ");
            _inPCBox.PowSupUnit = Console.ReadLine();
            Console.WriteLine("Введите имя корпуса : ");
            _inPCBox.PCBody = Console.ReadLine();
            Console.WriteLine("\nB системный блок были добавлены:\n" +
            "Материнская плата - {0}\nПамять - {1} гб\nПроцессор - {2}\nДиск - {3}\nБлок питания - {4}\nКорпус - {5}",
            _inPCBox.Motherboard, _inPCBox.PCMemory, _inPCBox.Processor,
            _inPCBox.Disc, _inPCBox.PowSupUnit, _inPCBox.PCBody);
        }
        public PC()
        {
            Console.WriteLine("Введите имя ПК : ");
            Name = Console.ReadLine();
            nameOfDisplay = nameOfPCBox = nameOfKeyboard = nameOfMouse = empty;
        }
        public void PC_menu(int _number, string _name)
        {
            if (_number == 1)
            {
                myAction += addDisplay;
                myAction += addPCBox;
                myAction += addKeyboard;
                myAction += addMouse;
                Print(_name);
            }
        }
        private void Print(string _text)
        {
            myAction(_text);
        }
        public void addDisplay(string nameOfDisplay)
        {
            this.nameOfDisplay = nameOfDisplay;
            Console.WriteLine("К рабочему месту добавлен монитор {0}.", nameOfDisplay);

        }
        public void minusDisplay(string nameOfDisplay)
        {
            if (this.nameOfDisplay == nameOfDisplay)
            {
                this.nameOfDisplay = empty;
                Console.WriteLine("От рабочего места забран монитор {0}.", nameOfDisplay);
            }
            else
            {
                Console.WriteLine("У рабочего места нет монитора {0}.", nameOfDisplay);
            }


        }
        public void addPCBox(string nameOfPCBox)
        {
            this.nameOfPCBox = nameOfPCBox;
            Console.WriteLine("К рабочему месту добавлен системный блок {0}.", nameOfPCBox);

        }
        public void addKeyboard(string nameOfKeyboard)
        {
            this.nameOfKeyboard = nameOfKeyboard;
            Console.WriteLine("К рабочему месту добавлена клавиатура {0}.", nameOfKeyboard);
        }
        public void addMouse(string nameOfMouse)
        {
            this.nameOfMouse = nameOfMouse;
            Console.WriteLine("К рабочему месту добавлена мышь {0}.", nameOfMouse);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            var myPC = new PC();
            myPC.PC_menu(1, "Samsung");
            myPC.inPCBox();
            Console.ReadKey();

        }
    }
}
