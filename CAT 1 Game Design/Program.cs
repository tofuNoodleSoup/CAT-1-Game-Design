using System;namespace testingforcat{    class Program    {        static void Main(string[] args)        {            gameTitle();        }        public static void gameTitle()        {            string yourName;            Console.WriteLine("(in this game, click any key to continue!)");            Console.ReadKey(true);            Console.WriteLine("(yeah, just like that!)");            Console.ReadKey(true);            Console.Clear();            Console.WriteLine("(sometimes you will be asked to answer things, so type it in and then press enter.)");            Console.WriteLine("What's your name?");            yourName = Console.ReadLine();            Console.WriteLine("Hello " + yourName + "! (and yeah just like that!)");            Console.ReadKey(true);            Console.WriteLine("(have fun!)");            Console.ReadKey(true);            Console.Clear();            first();        }        public static void first()        {

            string choice;
            Console.WriteLine("A fruity breeze saunters through the field. The sun is blooming in the sky and " +
               "soft clouds beam down at you.");
            Console.ReadKey(true);
            Console.WriteLine("The surrounding forest stands tall, the creaking branches sway, " +
                "their shrill sounds hang ominously in the air.");
            Console.ReadKey(true);
            Console.WriteLine("You choose to focus on the crip grass, densely " +
                "shrouded in brightly smiling flowers.");
            Console.ReadKey(true);
            Console.WriteLine("They move around you and their lush petals brush against your legs.");
            Console.ReadKey(true);
            Console.WriteLine("You should collect flowers for Grandma, she's sick after all and flowers might cheer her up.");
            Console.ReadKey(true);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Yes, collect flowers");
            Console.WriteLine("2. No, do not collect flowers");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
           switch (choice)
            {
                case "1":
                case "yes":
                case "yes, collect flowers":
                case "yes collect flowers":

                    { //path 1
                        Console.Clear();
                        Console.WriteLine("As you pick a lovely flower, a strong green stem, and dusky purple blossoms," +
                            " you find yourself staring into a bush of the most delicious berries you have ever seen.");
                        Console.ReadKey(true);
                        Console.WriteLine("You pause and recall your Grandmother saying that she was interested in making jam, but she lacked fruits.");
                        Console.ReadKey(true);
                        Console.WriteLine("They do look good, and you are rather hungry. What Grandma doesn’t know can hurt her, right?");
                        Console.ReadKey(true);
                        Console.WriteLine("Do you take them for Grandma or eat them now?");
                        Console.WriteLine("1. Eat them now");
                        Console.WriteLine("2. Save them for Grandma");
                        Console.WriteLine("Choice: ");
                        choice = Console.ReadLine();
                        option1a();
                        break;

                    }
                case "2":
                case "no":
                case "no, do not collect flowers":
                case "no dont collect flowers":
                    { //path 2
                       
                        Console.Clear();
                        Console.WriteLine("You run to Grandma's house, red tints your cheeks, and your breath comes out in heavy pants.");
                        Console.ReadKey(true);
                        Console.WriteLine("You knock twice, and the door swings open with a shudder.");
                        Console.ReadKey(true);
                        Console.WriteLine("You stare into her eyes, smiling warmly at her.");
                        Console.ReadKey(true);
                        Console.WriteLine("...But her eyes seemed less vibrant, her skin was more sallow, her back was hunched," +
                        " her ears were more bat-like.");
                        Console.ReadKey(true);
                        Console.WriteLine("Concern invades your thoughts.");
                        Console.ReadKey(true);
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("1. Offer her the berries, and say \"Maybe these will make you feel better, Grandma.\"");
                        Console.WriteLine("2. Don't offer her the berries and say \"What big ears you have, Grandma.\"");
                        choice = Console.ReadLine().ToLower();
                        switch (choice)
                        {
                            case "1":
                            case "offer":
                            case "offer her the berries":
                                {
                                    option1b1();
                                    break;
                                }
                            case "2":
                            case "dont offer":
                            case "dont offer her the berries":
                                {
                                    option1b2();
                                    break;
                                }
                        }
                       
                        break;
                    }
            }




        }        public static void option1a()        {            string choice;
            Console.Clear();
            Console.WriteLine("You smile to yourself.");
            Console.ReadKey(true);
            Console.WriteLine("You deserve these berries, you have worked so hard over the" +
                " last few days and you deserve a treat.");
            Console.ReadKey(true);
            Console.WriteLine("You take a generous handful of the small fruit and start to chew.");
            Console.ReadKey(true);
            Console.WriteLine("It is a burst of flavour, fireworks in your mouth. As you continue chewing you notice how sweet they are," +
                " how you have never had something so tasty, how everything around you seems brighter, how it practically" +
                " takes your breath away.");
            Console.ReadKey(true);
            Console.WriteLine("But the guilt of not giving them to you Grandmother still gnaws at you.");
            Console.ReadKey(true);
            Console.WriteLine("Do you spit them out and give the rest to Grandma?");
            Console.WriteLine("1. Spit them out.");
            Console.WriteLine("2. Continue eating and enjoy them");
            choice = Console.ReadLine();
            switch (choice)
            {
               case "1":
                case "spit":
                case "spit them out":
                   
                {
                       
                        break;
                }
                case "2":
                case "continue eating":
                case "continue eating and enjoy them":
                    {
                        Console.Clear();
                        Console.WriteLine("Oh no, the berries were poison, you selfish monster. ");
                        Console.ReadKey(true);
                        Console.WriteLine("DISHONOUR ON YOU, DISHONOUR ON YOUR FAMILY, DISHONOUR ON YOU COW!");
                        Console.ReadKey(true);
                        Console.WriteLine("You die.");
                        Console.ReadKey(true);
                        Console.WriteLine("(lol rip)");
                        Console.ReadKey(true);
                        gameEnd();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please enter a valid option!");
                        break;

                    }
            }


        }        public static void option1b1()
        {
            Console.Clear();
            Console.WriteLine("You reach your hand into your pocket and pull out the berries.");
            Console.ReadKey(true);
            Console.WriteLine("You slowly move them towards grandma, opening your palm and offering them to her.");
            Console.ReadKey(true);
            Console.WriteLine("She smiles up at you and swallows them in one gulp.");
            Console.ReadKey(true);
            Console.WriteLine("Suddenly, her legs collapse beneath her, falling to the ground with a vile thud.");
            Console.ReadKey(true);
            Console.WriteLine("You jump backwards, screaming.");
            Console.ReadKey(true);
            Console.WriteLine("You realise the lifeless body on the ground isn’t your grandma but, in fact, a dead wolf.");
            Console.ReadKey(true);
            Console.WriteLine("In a panicked state, you reach for a gun and shoot the wolf twice in the head for good measure.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("You win");
            Console.ReadKey(true);
            Console.WriteLine("You get turned into a whale.");
        }        public static void option1b2()
        {

        }        public static void gameEnd()        {
            string playAgain;
            Console.WriteLine("play again?");
            playAgain = Console.ReadLine().ToLower();
            switch (playAgain)
            {
                case "yes":
                case "y":
                    {
                        Console.WriteLine("see if you can win!");
                        Console.ReadKey(true);
                        first();
                        break;
                    }
                case "no":
                case "n":
                    {
                        Console.WriteLine("oh k bye i guess...");
                        Console.ReadKey(true);
                        break;
                    }
            }
           
        }        }}
