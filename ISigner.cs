using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiSign
{
    public interface ISigner
    {
       byte[] Sign(byte[] file);
    }
}
