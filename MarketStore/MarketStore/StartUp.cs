namespace MarketStore
{
    using System;
    using MarketStore.Cards;

    public class StartUp
    {
        static void Main()
        {
            //With the examples below I aim to cover all the posibilities.
           

            //Example 1
            var bronzeCard = new BronzeCard("Daniel Ivanov",0, 150);
            Console.WriteLine(bronzeCard.ToString());

            //Example 2
            var silverCard = new SilverCard("Pesho Peshev",600, 850);
            Console.WriteLine(silverCard.ToString());

            //Example 3
            var goldCard = new GoldCard("Ivan Ivanov",1500, 1300);
            Console.WriteLine(goldCard.ToString());

            //Example 4
            var silverCard2 = new SilverCard("Mariq Lubeva",150, 500);
            Console.WriteLine(silverCard2.ToString());

            //Example 5 
            var bronzeCard2 = new BronzeCard("Christian Dior",150, 700);
            Console.WriteLine(bronzeCard2.ToString());

            //Example 6 
            var bronzeCard3 = new BronzeCard("Petar Jordanov",301, 600);
            Console.WriteLine(bronzeCard3.ToString());

            //Example 7
            var goldCard2 = new GoldCard("Ken Sanchez",300, 1000);
            Console.WriteLine(goldCard2.ToString());

            //Error Example
            var errorCard = new GoldCard("",-1, -1);

        }
    }
}
