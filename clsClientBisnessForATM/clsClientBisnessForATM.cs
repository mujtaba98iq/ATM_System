using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using clsAccessLayerForATM;

namespace clsClientBisnessForATM
{
    public class clsClient
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Balance { get; set; }
        public string AccNumber { get; set; }
        public int PinCode { get; set; }

        public clsClient() 
        { 
            AccNumber = string.Empty;
            PinCode = 0;
            Balance = "";
            PersonID = 0;
        }
        public clsClient(int ID, string AccNumber,int PinCode,int PersonID, string Balance)
        {
            this.ID = ID;
            this.AccNumber = AccNumber;
            this.PinCode   = PinCode;
            this.Balance   = Balance;
            this.PersonID  = PersonID;
        }

        static public bool WithDraw(string AccNumber, float Ammont)
        {
            return clsAccessATM.WithDraw(AccNumber, Ammont);
        }
        static public bool ChangePinCode(string AccNumber, int NewPinCode)
        {
            return clsAccessATM.ChangePinCode(AccNumber, NewPinCode);
        }
        static public bool Deposit(string AccNumber, float Ammont)
        {
            return clsAccessATM.Deposit(AccNumber, Ammont);
        }
        static public bool Login(string AccNumber, string PinCode)
        {
            return clsAccessATM.Login(AccNumber, PinCode);
        }

        static public int FindIDByAccNumber(string AccNumber)
        {
            return clsAccessATM.GetIDByUserName(AccNumber);
        }
        static public clsClient FindClientByAccNumber(string  AccNumber)
        {
            clsAccessATM.stClient Client=new clsAccessATM.stClient();
            int ID = 0;

            
             if(clsAccessATM.GetClientInfoByAccNumber(ID, ref Client))
            {
                return new clsClient(ID, Client.AccNumber, Client.PinCode, Client.PersonID, Client.Balance);
            }
             return null;
        }
        static public clsClient FindClientByID(int ID)
        {
            clsAccessATM.stClient Client = new clsAccessATM.stClient();


            if (clsAccessATM.GetClientInfoByAccNumber(ID, ref Client))
            {
                return new clsClient(ID, Client.AccNumber, Client.PinCode, Client.PersonID, Client.Balance);
            }
            return null;
        }

    }
}
