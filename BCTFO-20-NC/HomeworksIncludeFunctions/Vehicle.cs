namespace Homeworks
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public static Vehicle Parse(string data)
        {
            string[] csvData = data.Split(',');

            if (csvData.Length != 9)
                throw new FormatException("Incorrect Format");

            Vehicle result = new Vehicle();

            result.Make = csvData[0];
            result.Model = csvData[1];
            result.Cylinder = byte.Parse(csvData[2]);
            result.Engine = float.Parse(csvData[3]);
            result.Drive = csvData[4];
            result.Transmission = csvData[5];
            result.City = byte.Parse(csvData[6]);
            result.Combined = byte.Parse(csvData[7]);
            result.Highway = byte.Parse(csvData[8]);


            return result;
        }
    }
}
