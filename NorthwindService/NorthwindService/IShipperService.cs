﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShipperService" in both code and config file together.
    [ServiceContract(Namespace = "EC.WCFLABB3")]
    public interface IShipperService
    {
        [OperationContract]
        Shipper GetShipperByID(int id);

        [OperationContract]
        void SaveShipper(int id, string companyName, string phone);
    }

    [DataContract]
    public class Shipper
    {
        [DataMember]
        public int ShipperID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}