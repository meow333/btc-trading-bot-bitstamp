﻿using Newtonsoft.Json;
using OkonkwoOandaV20.Framework.JsonConverters;
using OkonkwoOandaV20.TradeLibrary.DataTypes.Transaction;

namespace OkonkwoOandaV20.TradeLibrary.DataTypes.Communications
{
   public class OrderPostResponse : Response
   {
      [JsonConverter(typeof(TransactionConverter))]
      public ITransaction orderCreateTransaction { get; set; }
      public OrderFillTransaction orderFillTransaction { get; set; }
      public OrderCancelTransaction orderCancelTransaction { get; set; }
      public Transaction.Transaction orderReissueTransaction { get; set; }
      public Transaction.Transaction orderReissueRejectTransaction { get; set; }
   }
}
 