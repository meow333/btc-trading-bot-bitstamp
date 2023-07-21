namespace OkonkwoOandaV20.TradeLibrary.DataTypes.Instrument
{
   public class CandleStickGranularity
   {
    
      public const string Minutes01 = "M1";
      public const string Hours04 = "H4";


    }

    public class InstrumentType
   {
      public const string Currency = "CURRENCY";
      public const string ContractForDifference = "CFD";
      public const string Metal = "METAL";
   }

   public class WeeklyAlignment
   {
      public const string Monday = "Monday";
      public const string Tuesday = "Tuesday";
      public const string Wednesday = "Wednesday";
      public const string Thursday = "Thursday";
      public const string Friday = "Friday";
      public const string Saturday = "Saturday";
      public const string Sunday = "Sunday";
   }

   public class CandleStickPriceType
   {
      public const string Ask = "A";
      public const string Bid = "B";
      public const string Midpoint = "M";
   }
}
