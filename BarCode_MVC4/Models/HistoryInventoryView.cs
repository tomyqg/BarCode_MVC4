﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarCode_MVC4.Models
{
    public class HistoryInventoryView
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Prod { get; set; }
        public string Thickness { get; set; }
        public string Widt { get; set; }
        public Nullable<int> Leng { get; set; }
        public string Splice { get; set; }
        public string Ptno { get; set; }
        //public Nullable<System.DateTime> ProductDate { get; set; }
        public DateTime ProductDate { get; set; }
        public string CustomerNO { get; set; }
        public string PackNo { get; set; }
        public string StaffID { get; set; }
        //public Nullable<System.DateTime> TransactionDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string SrnmType { get; set; }
        public string CtlNo1 { get; set; }
        public string CtlName1 { get; set; }
        public string CtlNo2 { get; set; }
        public string CtlName2 { get; set; }
        public Nullable<double> NewWeight { get; set; }
        public Nullable<double> GrossWeight { get; set; }
        public string ZoneSN { get; set; }
        public string ZoneID { get; set; }
        public string Thickness2 { get; set; }
    }
}