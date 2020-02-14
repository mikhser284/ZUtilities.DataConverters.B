using System;
using System.Globalization;
using System.Linq;

namespace ZUtilities.DataConverters.B
{
    public enum ItemStatus
    {
        Undefined = 0,
        Selected = 1,
        Converted = 2
    }

    public class InputData
    {
        public String Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public Double X { get; set; }

        public Double Y { get; set; }

        public Double? Z { get; set; }

        public Double? CoefA { get; set; }

        public Double? CoefB { get; set; }
        
        public ItemStatus Status { get; set; }

        public String SourceFilePath { get; set; }

        public String DestinationFilePath { get; set; }

        public InputData()
        {
            Status = ItemStatus.Undefined;
            SourceFilePath = String.Empty;
            DestinationFilePath = String.Empty;
        }

        public static Boolean TryParse(String stringValue, out InputData parsingResult)
        {
            parsingResult = null;
            if(String.IsNullOrEmpty(stringValue)) return false;
            var splitedString = stringValue.Split(',').ToList();
            splitedString.ForEach(x => x = x.Trim());
            if(splitedString.Count < 4) return false;
            Boolean isParsingSuccesful = true;
            InputData inputData = new InputData();
            try
            {
                inputData.Description = splitedString[0];
                inputData.TimeStamp = DateTime.Parse(splitedString[1]);
                inputData.X = Double.Parse(splitedString[2], CultureInfo.InvariantCulture);
                inputData.Y = Double.Parse(splitedString[3], CultureInfo.InvariantCulture);
                if(splitedString.Count > 4) inputData.Z = Double.TryParse(splitedString[4], NumberStyles.Any, CultureInfo.InvariantCulture, out Double z) ? (Double?)z : null;
                if(splitedString.Count > 5) inputData.CoefA = Double.TryParse(splitedString[5], NumberStyles.Any, CultureInfo.InvariantCulture, out Double coefA) ? (Double?)coefA : null;
                if(splitedString.Count > 6) inputData.CoefB = Double.TryParse(splitedString[6], NumberStyles.Any, CultureInfo.InvariantCulture, out Double coefB) ? (Double?)coefB : null;
            }
            catch(Exception ex) { isParsingSuccesful = false; }
            if(isParsingSuccesful) parsingResult = inputData;
            return isParsingSuccesful;
        }

        public String AsOutputString() => FormattableString.Invariant($"{X:0.000} {Y:0.000}");
    }
}
