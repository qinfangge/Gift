//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NamespaceRef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comment = new HashSet<Comment>();
        }
    
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public Nullable<int> BlogID { get; set; }
    
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual BlogUser BlogUser { get; set; }
    }
}
