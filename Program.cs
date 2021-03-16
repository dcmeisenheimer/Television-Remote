using System;

namespace Television_Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to accept user input
            int channel, volume, station;

            //Declare and instatiate a television object
            Television bigScreen = new Television("Toshiba", 55);

            //Turn the power on
            bigScreen.Power();

            //Display the state of the television
            Console.WriteLine(bigScreen.ToString());

            //Prompt the user for input and store it in the station variable
            Console.Write("What channel do you want? ");
            station = int.Parse(Console.ReadLine());

            //Change the channel on the television
            bigScreen.SetChannel(station);

            //Increase the volumne of the television
            bigScreen.IncreaseVolume();
            volume = bigScreen.GetVolume();

            //Display the current channel and volumne
            Console.WriteLine("Channel: " + bigScreen.GetChannel() + " Volume: " + volume);

            Console.WriteLine("Too loud!  Lowering the volume.");

            //Decrease the volume
            for (int x = 0; x < 6; x++)
            {
                bigScreen.DecreaseVolume();
            }

            //Display the current channel and volumne
            Console.WriteLine("Channel: " + bigScreen.GetChannel() + " Volume: " + bigScreen.GetVolume());

            //create blank line
            Console.WriteLine("");

            //HERE IS WHERE YOU DO TASK 5
            Television portable = new Television("Sharp" , 19); //used to declare and initiate a television object
            portable.Power();

            System.Console.WriteLine(portable.ToString()); //displays the state of the television

            System.Console.Write("What channel do you want? "); //prompts the user for input and stores it in the channel variable
            channel = int.Parse(Console.ReadLine());

            portable.SetChannel(channel); //change the channel on the television

            portable.DecreaseVolume();  //used to decrease the volume    
            portable.DecreaseVolume();

            System.Console.WriteLine("Channel: " + portable.GetChannel() + " Volume: " + portable.GetVolume()); //display the current channel and volume of second tv

            Console.ReadKey();
        }
    }
}
