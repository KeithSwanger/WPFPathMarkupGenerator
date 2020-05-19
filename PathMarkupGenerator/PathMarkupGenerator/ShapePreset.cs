using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace PathMarkupGenerator
{
    public class ShapePreset
    {
        public string Name { get; set; }
        public int ReferenceWidth { get; set; }
        public int ReferenceHeight { get; set; }
        public string PathData { get; set; }
    }

    
}
