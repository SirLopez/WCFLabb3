using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentFive
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract(Namespace = "EC.WCFLABB3B")]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployeeByID(int id);
        [OperationContract]
        void SaveEmployee(int id, string lastname, string firstname, string title, string address, string city);
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}
