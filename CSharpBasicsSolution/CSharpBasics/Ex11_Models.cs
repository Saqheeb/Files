using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class RDSDataModel
    {
        private string idNumber;
        private string counterPartyId;
        private string counterPartyType;

        //Properties
        public string IdNumber {/*Accessors*/	get; set; }
        public string CounterPartyId { get; set; }
        public string CounterPartyType { get; set; }

        /*
		//Getters and Settors method
        public void setIdnumber(string idNumber) { this.idNumber = idNumber; }
        public string getIdnumber() { return this.idNumber;}

        public void setCounterPartyId(string idNumber) { this.idNumber = idNumber; }
        public string getCounterPartyId() {  return this.counterPartyId;}

        public void setCounterPartyType(string idNumber) { this.idNumber = idNumber; }
        public string getCounterPartyType() { return this.counterPartyType; }
		*/
    }

    public class TDSDataModel
    {
        private string tradeId;
        private DateTime date;
        private int currTradeValDollar;
        private string counterPartyId;

        public string TradeId { get; set; }
        public DateTime Date { get; set; }  
        public int TradeValDollar { get; set; }
        public string CounterPartyId{ get; set; }

    }
    public class Ex11_Models
    {
        public static void Main(string[] args)
        {
            RDSDataModel obj = new RDSDataModel();
            obj.IdNumber = "509";
            string idNumber = obj.IdNumber;
            Console.WriteLine(idNumber);

            TDSDataModel obj2 = new TDSDataModel();
            obj2.TradeValDollar = 1999746;
            Console.WriteLine(obj2.TradeValDollar);

            obj2.Date = DateTime.Now;
            Console.WriteLine(obj2.Date.ToString("d"));
        }
    }
}
