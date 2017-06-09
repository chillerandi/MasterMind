using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MasterMind.Models
{
    public class Game_M
    {
        private string playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }       

        private int randomNumber;
        public int RandomNumber
        {
            get { return randomNumber; }
            set { randomNumber = value; }
        }        

        private int randomNumberCount;

        

        public int RandomNumberCount
        {
            get { return randomNumberCount; }
            set { randomNumberCount = value; }
        }

        private int userGuess;
        public int UserGuess
        {
            get { return userGuess; }
            set { userGuess = value; }
        }

        private int countHits;
        public int CountHits
        {
            get { return countHits; }
            set { countHits = value; }
        }

        public int GetRandomNumberCount()
        {  
            //Console.Write("Wie viele Zahlen wollen Sie benutzen ( 4- 10 ) ? ");
            int input = 5;
            //if(input < 4 || input > 10) {
            //    Console.Write(" Bitte wählen Sie eine Anzahl zwischen 4 und 10! ");
            //}
            //Console.Write("Die gewünschte Anzahl ist " + input);
            RandomNumberCount = input;
            return RandomNumberCount;
        }

        public int[] GenerateRandomNumber(int PCSize)
        {
            int singleNumber;
            int[] randomNumber = new int[PCSize];
            Random rnd = new Random();
            Console.Write("PC Number : ");
            for (int i = 0; i < PCSize; i++) {
                singleNumber = rnd.Next(1, 9);
                randomNumber[i] = singleNumber;
                Console.Write(singleNumber);
            }
            Console.WriteLine();
            return randomNumber;
        }
    }
}
