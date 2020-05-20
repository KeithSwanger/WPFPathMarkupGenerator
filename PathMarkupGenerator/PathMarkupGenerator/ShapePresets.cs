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
                    PathData = "M 50,0 L 66.5,31.5 100,38.2 76.7,64.5 80.9,100 50,84.8 19.1,100 23.4,64.5 0,38.2 33.6,31.5 Z"
                },
                new ShapePreset()
                {
                    Name = "Hollow Star",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 50,0 L 66.5,31.5 100,38.2 76.7,64.5 80.9,100 50,84.8 19.1,100 23.4,64.5 0,38.2 33.6,31.5 Z M 50,19.5 L 60.8,39.9 82.6,44.3 67.4,61.3 70.2,84.4 50,74.5 30,84.4 32.7,61.3 17.6,44.3 39.4,39.9 Z"
                },
                new ShapePreset()
                {
                    Name = "Circle",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,50 A 50,50 0 1 1 100,50 M 0,50 A 50,50 0 1 0 100,50 Z"
                },
                new ShapePreset()
                {
                    Name = "Hollow Circle 1%",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,50 A 50,50 0 1 1 100,50 M 0,50 A 50,50 0 1 0 100,50 Z M 1,50 A 49,49 0 1 1 99,50 M 1,50 A 49,49 0 1 0 99,50 Z"
                },
                new ShapePreset()
                {
                    Name = "Hollow Circle 10%",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,50 A 50,50 0 1 1 100,50 M 0,50 A 50,50 0 1 0 100,50 Z M 10,50 A 40,40 0 1 1 90,50 M 10,50 A 40,40 0 1 0 90,50 Z"
                },
                new ShapePreset()
                {
                    Name = "Hollow Circle 15%",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,50 A 50,50 0 1 1 100,50 M 0,50 A 50,50 0 1 0 100,50 Z M 15,50 A 35,35 0 1 1 85,50 M 15,50 A 35,35 0 1 0 85,50 Z"
                },
                new ShapePreset()
                {
                    Name = "Hollow Circle 20%",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,50 A 50,50 0 1 1 100,50 M 0,50 A 50,50 0 1 0 100,50 Z M 20,50 A 30,30 0 1 1 80,50 M 20,50 A 30,30 0 1 0 80,50 Z"
                },
                new ShapePreset()
                {
                    Name = "Square",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 0,0 L 100,0 100,100 0,100 Z"
                }

            };

        }
    }
}
