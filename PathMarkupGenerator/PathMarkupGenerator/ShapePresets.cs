﻿using System;
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
                },
                new ShapePreset()
                {
                    Name = "Material Design Gear",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 12,15.5 A 3.5,3.5 0 0 1 8.5,12 A 3.5,3.5 0 0 1 12,8.5 A 3.5,3.5 0 0 1 15.5,12 A 3.5,3.5 0 0 1 12,15.5 M 19.43,12.97 C 19.47,12.65 19.5,12.33 19.5,12 C 19.5,11.67 19.47,11.34 19.43,11 L 21.54,9.37 C 21.73,9.22 21.78,8.95 21.66,8.73 L 19.66,5.27 C 19.54,5.05 19.27,4.96 19.05,5.05 L 16.56,6.05 C 16.04,5.66 15.5,5.32 14.87,5.07 L 14.5,2.42 C 14.46,2.18 14.25,2 14,2 H 10 C 9.75,2 9.54,2.18 9.5,2.42 L 9.13,5.07 C 8.5,5.32 7.96,5.66 7.44,6.05 L 4.95,5.05 C 4.73,4.96 4.46,5.05 4.34,5.27 L 2.34,8.73 C 2.21,8.95 2.27,9.22 2.46,9.37 L 4.57,11 C 4.53,11.34 4.5,11.67 4.5,12 C 4.5,12.33 4.53,12.65 4.57,12.97 L 2.46,14.63 C 2.27,14.78 2.21,15.05 2.34,15.27 L 4.34,18.73 C 4.46,18.95 4.73,19.03 4.95,18.95 L 7.44,17.94 C 7.96,18.34 8.5,18.68 9.13,18.93 L 9.5,21.58 C 9.54,21.82 9.75,22 10,22 H 14 C 14.25,22 14.46,21.82 14.5,21.58 L 14.87,18.93 C 15.5,18.67 16.04,18.34 16.56,17.94 L 19.05,18.95 C 19.27,19.03 19.54,18.95 19.66,18.73 L 21.66,15.27 C 21.78,15.05 21.73,14.78 21.54,14.63 L 19.43,12.97 Z"
                },
                new ShapePreset()
                {
                    Name = "Material Design Play",
                    ReferenceWidth = 112,
                    ReferenceHeight = 112,
                    PathData = "M 0,0 V 112 L 88,56 L 0,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Material Design Plus Circular",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 75,55 H 55 V 75 H 45 V 55 H 25 V 45 H 45 V 25 H 55 V 45 H 75 M 50,0 A 50,50 0 0 0 0,50 A 50,50 0 0 0 50,100 A 50,50 0 0 0 100,50 A 50,50 0 0 0 50,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Material Design Plus Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 112,80 H 80 V 112 H 64 V 80 H 32 V 64 H 64 V 32 H 80 V 64 H 112 M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                }





            };

        }
    }
}
