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
    
    public partial class TSPL_HR_RAISE_TRAVEL_REQUISITION_ENTRY
    {
        public string Travel_Req_Code { get; set; }
        public Nullable<System.DateTime> Document_Date { get; set; }
        public int Is_Domesctic { get; set; }
        public int Is_International { get; set; }
        public string Travel_Purpose { get; set; }
        public Nullable<System.DateTime> Travel_Period_From { get; set; }
        public Nullable<System.DateTime> Travel_Period_To { get; set; }
        public string Travel_Category_Code { get; set; }
        public string Loc_From_Travel { get; set; }
        public string Loc_To_Travel { get; set; }
        public Nullable<System.DateTime> Departure_Date { get; set; }
        public Nullable<System.DateTime> Arrival_Date { get; set; }
        public string Travel_Mode_Code { get; set; }
        public string Travel_Class_Code_Travel { get; set; }
        public string Flight_No_Travel { get; set; }
        public string Coupon_No_Travel { get; set; }
        public string Booked_By_Travel { get; set; }
        public string Travel_Request { get; set; }
        public string Booked_By_Name_Travel { get; set; }
        public string Remarks_Travel { get; set; }
        public Nullable<System.DateTime> Date_Of_Stay_From_Hotel { get; set; }
        public Nullable<System.DateTime> Date_Of_Stay_To_Hotel { get; set; }
        public string Hotel_Rating_Code_Hotel { get; set; }
        public string Travel_Room_Type { get; set; }
        public int Days { get; set; }
        public int Night { get; set; }
        public Nullable<System.DateTime> Period_From_Car { get; set; }
        public Nullable<System.DateTime> Period_To_Car { get; set; }
        public string Loc_From_Car { get; set; }
        public string Loc_To_Car { get; set; }
        public string Travel_Car_Code { get; set; }
        public double Amount { get; set; }
        public string Remarks_Car { get; set; }
        public int Approved { get; set; }
        public string Approved_By { get; set; }
        public Nullable<System.DateTime> Approved_Date { get; set; }
        public int Rejected { get; set; }
        public string Rejected_By { get; set; }
        public Nullable<System.DateTime> Rejected_Date { get; set; }
        public string Travel_Booking_For { get; set; }
        public string Comp_Code { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public string Modified_By { get; set; }
        public System.DateTime Modified_Date { get; set; }
    
        public virtual TSPL_HR_HOTEL_RATING_MASTER TSPL_HR_HOTEL_RATING_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_CITY_MASTER TSPL_HR_TRAVEL_CITY_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_CITY_MASTER TSPL_HR_TRAVEL_CITY_MASTER1 { get; set; }
        public virtual TSPL_HR_TRAVEL_CITY_MASTER TSPL_HR_TRAVEL_CITY_MASTER2 { get; set; }
        public virtual TSPL_HR_TRAVEL_CITY_MASTER TSPL_HR_TRAVEL_CITY_MASTER3 { get; set; }
        public virtual TSPL_HR_TRAVEL_CATEGORY_MASTER TSPL_HR_TRAVEL_CATEGORY_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_MODE_TYPE_MASTER TSPL_HR_TRAVEL_MODE_TYPE_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_CLASS_TYPE_MASTER TSPL_HR_TRAVEL_CLASS_TYPE_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_ROOM_TYPE_MASTER TSPL_HR_TRAVEL_ROOM_TYPE_MASTER { get; set; }
        public virtual TSPL_HR_TRAVEL_CAR_TYPE_MASTER TSPL_HR_TRAVEL_CAR_TYPE_MASTER { get; set; }
    }
}
