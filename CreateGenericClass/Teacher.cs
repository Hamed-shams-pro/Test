using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericClass
{
    internal class Teacher : BaseEntity<byte>
    {
        public string FieldOfStudy { get; set; }
    }
}
