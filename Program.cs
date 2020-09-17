using System;

namespace СА2
{
    class Program
    {        
        static void Main(string[] args)
        {
            Table table = new Table();

            table.FillInTheTable(table.MinValue,table.MaxValue);

            Console.WriteLine("Исходная матрица предпочтений:");

            table.DrawTable();

            Console.WriteLine("Модифицированная предпочтений матрица предпочтений");

            table.DrawModifiedTable();

            Console.WriteLine("Cуммы преобразованных оценок по каждой из альтернатив: ");

            table.DrawSums();

            Console.WriteLine("Cумма всех оценокfgergrgegre");
        }
    }
}
