using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkAvailabilityApp
{
    internal class CarPark
    {
    }

    public class Rootobject
    {
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public DateTime Timestamp { get; set; }
        public List<Carpark_Data> Carpark_data { get; set; }
    }

    public class Carpark_Data
    {
        public List<Carpark_Info> Carpark_info { get; set; }
        public string Carpark_number { get; set; }
        public DateTime Update_datetime { get; set; }
    }

    public class Carpark_Info
    {
        public string Total_lots { get; set; }
        public string Lot_type { get; set; }
        public string Lots_available { get; set; }
    }

}
