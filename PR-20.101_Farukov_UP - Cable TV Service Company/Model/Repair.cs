//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_20._101_Farukov_UP___Cable_TV_Service_Company.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair
    {
        public int RepairID { get; set; }
        public int IDClient { get; set; }
        public string RepairDescription { get; set; }
        public Nullable<int> IDStaff { get; set; }
        public Nullable<int> RepairCost { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
