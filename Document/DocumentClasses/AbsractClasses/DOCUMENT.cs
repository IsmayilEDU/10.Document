using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.Models.AbsractClasses
{
    internal class DOCUMENT     
    {
        //  Function of opened document
        public virtual string OpenDocument()
        {
            return "Document Opened";
        }

        //  Function of edit document
        public virtual string EditDocument()
        {
            return "Can Edit in Pro and Expert versions";
        }

        //  Function of save document
        public virtual string SaveDocument()
        {
            return "Can Save in Pro and Expert versions";
        }
    }
}
