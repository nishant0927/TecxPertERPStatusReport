//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecxPertERPStatusReport.WebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSPL_APP_SERVER_CONFIG
    {
        public int Server_Id { get; set; }
        public string Server_Name { get; set; }
        public string Domain_IP { get; set; }
        public int Port_No { get; set; }
        public string Comm_Protocol { get; set; }
        public Nullable<int> Conn_Open_Timeout { get; set; }
        public Nullable<int> Conn_Close_Timeout { get; set; }
        public Nullable<int> Conn_Send_Timeout { get; set; }
        public Nullable<int> Conn_Receive_Timeout { get; set; }
        public Nullable<int> Operation_Timeout { get; set; }
        public Nullable<int> maxBufferPoolSize { get; set; }
        public Nullable<int> maxBufferSize { get; set; }
        public Nullable<int> maxReceivedMessageSize { get; set; }
        public Nullable<int> transferMode { get; set; }
        public Nullable<int> maxStringContentLength { get; set; }
        public Nullable<int> maxArrayLength { get; set; }
        public Nullable<int> maxBytesPerRead { get; set; }
        public Nullable<int> maxNameTableCharCount { get; set; }
    }
}
