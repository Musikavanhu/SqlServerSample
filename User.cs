using System;
using System.Collection.Generic;

namespace SqlServerSample
{
    public class UserID
    {
        public int UserID: { get; set; }
        public String FirstName { get; set;}
        public String LastName { get; set;}
        public virtual IList<Task> Tasks { get; set; }
        public String GetFullName()
            {
                return this.FirstName + "" + this.LastName;
            }
            public override string ToString()
            {
                return "User [id=" + this.UserID + ", name=" + this.GetFullName() + "]";
            }
        
    }
}