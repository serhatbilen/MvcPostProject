//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitirmeProjem.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Like
    {
        public int Id { get; set; }
        public Nullable<int> LikedUser_Id { get; set; }
        public Nullable<int> Post_Id1 { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
