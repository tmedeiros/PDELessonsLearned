//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LessonsLearned
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRCClient
    {
        public TRCClient()
        {
            this.Lessons = new HashSet<Lesson>();
            this.TempSearches = new HashSet<TempSearch>();
        }
    
        public string Client { get; set; }
    
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<TempSearch> TempSearches { get; set; }
    }
}