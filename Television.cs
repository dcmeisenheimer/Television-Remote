namespace Television_Class_
{
    public class Television
    {
        readonly string manufacture; //used to set manufacture name
        readonly int screenSize; //used to set screensize value
        int channel, volume;  //variables needed to set channel and volume
        bool powerOn = false;  //state is false until user powers on TV

        //constructor to set size & manufacture also used to give the variables set values 
        public Television(string brand, int size)
        {
            manufacture = brand;
            screenSize = size;
            powerOn = false;
            volume = 20;
            channel = 2;
        }
        //used to set the channel by making it equal to station
        public void SetChannel(int station)
        { 
            channel = station;
        }
        //used to get the channel by returning channel
        public int GetChannel()
        {
            return channel;
        }
        //to turn off and on the tv using powerOn
        public void Power()
        {
            powerOn =!powerOn;
        }
        //used to increase the volume by 1 using volume++
        public void IncreaseVolume()
        {
            volume++;
        }
        public void DecreaseVolume() //used tp decrease the volume by 2 using volume --
        {
            volume-- ;
        }

        public int GetVolume() //used to get and return the volume 
        {
            return volume;
        }
        public string GetManufacture() //get the manufacturers name and return it
        {
            return manufacture;
        }

        public int GetScreenSize() // get the size of screen and return it
        {
            return screenSize;
        }

        public override string ToString() //used to override the toString method to return the message for user
        {
            string powerSwitch = powerOn == true? "on" : "off";
            string prompt = string.Format("A {0} inch {1} has been turned {2}" , screenSize, manufacture, powerSwitch);
            return prompt;
        }
    }
}