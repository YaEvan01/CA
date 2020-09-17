using System;
using System.Collections.Generic;
using System.Text;

namespace СА2
{
    class Table
    {
        public int Width { get; set; } = Settings.width;
        public int Length { get; set; } = Settings.length;
        public int MinValue { get; set; } = Settings.minValue;
        public int MaxValue { get; set; } = Settings.maxValue;

        int[] sums;

        int[,] table;

        int[,] modifiedTable;
        public Table()
        {
            modifiedTable = new int[Width, Length];
            table = new int[Width, Length];
            sums = new int[Length];
        }

        public int this[int width, int length]
        {
            get
            {
                return table[width, length];
            }
            set
            {
                table[width, length] = value;
            }
        }
        public void FillInTheTable(int minValue=1, int maxValue=4)
        {          
            Random random = new Random();
            for(int i =0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    table[i, j] = random.Next(MinValue,MaxValue+1);
                }
            }
        }
        public void DrawTable()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(table[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void DrawModifiedTable()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    modifiedTable[i, j] = MaxValue - table[i, j];
                    Console.Write(modifiedTable[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void FindSum()
        {            
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sums[j] += modifiedTable[i, j];
                }
            }
        }

        public void DrawSums()
        {
            FindSum();
            for (int i = 0; i <Length; i++)
            {
                Console.Write(sums[i]+" ");
            }
        }
    }
}
