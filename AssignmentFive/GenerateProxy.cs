﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssignmentFive
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/AssignmentFive")]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CityField;
        
        private int EmployeeIDField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string TitleField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID
        {
            get
            {
                return this.EmployeeIDField;
            }
            set
            {
                this.EmployeeIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="EC.WCFLABB3B", ConfigurationName="IEmployeeService")]
public interface IEmployeeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="EC.WCFLABB3B/IEmployeeService/GetEmployeeByID", ReplyAction="EC.WCFLABB3B/IEmployeeService/GetEmployeeByIDResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="EC.WCFLABB3B/IEmployeeService/GetEmployeeByIDFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    AssignmentFive.Employee GetEmployeeByID(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="EC.WCFLABB3B/IEmployeeService/GetEmployeeByID", ReplyAction="EC.WCFLABB3B/IEmployeeService/GetEmployeeByIDResponse")]
    System.Threading.Tasks.Task<AssignmentFive.Employee> GetEmployeeByIDAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="EC.WCFLABB3B/IEmployeeService/SaveEmployee", ReplyAction="EC.WCFLABB3B/IEmployeeService/SaveEmployeeResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="EC.WCFLABB3B/IEmployeeService/SaveEmployeeFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    void SaveEmployee(int id, string lastname, string firstname, string title, string address, string city);
    
    [System.ServiceModel.OperationContractAttribute(Action="EC.WCFLABB3B/IEmployeeService/SaveEmployee", ReplyAction="EC.WCFLABB3B/IEmployeeService/SaveEmployeeResponse")]
    System.Threading.Tasks.Task SaveEmployeeAsync(int id, string lastname, string firstname, string title, string address, string city);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IEmployeeServiceChannel : IEmployeeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<IEmployeeService>, IEmployeeService
{
    
    public EmployeeServiceClient()
    {
    }
    
    public EmployeeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public AssignmentFive.Employee GetEmployeeByID(int id)
    {
        return base.Channel.GetEmployeeByID(id);
    }
    
    public System.Threading.Tasks.Task<AssignmentFive.Employee> GetEmployeeByIDAsync(int id)
    {
        return base.Channel.GetEmployeeByIDAsync(id);
    }
    
    public void SaveEmployee(int id, string lastname, string firstname, string title, string address, string city)
    {
        base.Channel.SaveEmployee(id, lastname, firstname, title, address, city);
    }
    
    public System.Threading.Tasks.Task SaveEmployeeAsync(int id, string lastname, string firstname, string title, string address, string city)
    {
        return base.Channel.SaveEmployeeAsync(id, lastname, firstname, title, address, city);
    }
}
