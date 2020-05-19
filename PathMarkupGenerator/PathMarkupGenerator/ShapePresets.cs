using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathMarkupGenerator
{
    public static class ShapePresets
    {
        public static List<ShapePreset> AllPresets;

        static ShapePresets()
        {
            AllPresets = new List<ShapePreset>()
            {
                new ShapePreset()
                {
                    Name = "Star",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 50,0 L 66.5,31.5 100,38.2 76.7,64.5 80.9,100 50,84.8 19.1,100 23.4,64.5 0,38.2 33.6,31.5 Z M 50,19.5 L 60.8,39.9 82.6,44.3 67.4,61.3 70.2,84.4 50,74.5 30,84.4 32.7,61.3 17.6,44.3 39.4,39.9 Z"
                },
                new ShapePreset()
                {
                    Name = "Rectangle",
                    ReferenceWidth = 10,
                    ReferenceHeight = 10,
                    PathData = "M 0,0 L 10,0 10,10 0,10"
                }

            };

        }
    }
}
