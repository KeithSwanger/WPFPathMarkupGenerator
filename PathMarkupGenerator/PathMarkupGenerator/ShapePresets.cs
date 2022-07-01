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
                },
                new ShapePreset()
                {
                    Name = "Rounded Square",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Check-Bold (Michael Richins)",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 9,20.42 L 2.79,14.21 L 5.62,11.38 L 9,14.77 L 18.88,4.88 L 21.71,7.71 L 9,20.42 Z"
                },
                new ShapePreset()
                {
                    Name = "Close-Thick (Austin Andrews)",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 20,6.91 L 17.09,4 L 12,9.09 L 6.91,4 L 4,6.91 L 9.09,12 L 4,17.09 L 6.91,20 L 12,14.91 L 17.09,20 L 20,17.09 L 14.91,12 L 20,6.91 Z"
                },
                new ShapePreset()
                {
                    Name = "Right Arrow No Tail",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 15.2,12 L 9.5,17.5 L 11.92,19.92 L 19.84,12 L 11.92,4.08 L 9.5,6.5 L 15.2,12 H 4 Z"
                },
                new ShapePreset()
                {
                    Name = "Dots Horizontal",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 16,12 A 2,2 0 0 1 18,10 A 2,2 0 0 1 20,12 A 2,2 0 0 1 18,14 A 2,2 0 0 1 16,12 M 10,12 A 2,2 0 0 1 12,10 A 2,2 0 0 1 14,12 A 2,2 0 0 1 12,14 A 2,2 0 0 1 10,12 M 4,12 A 2,2 0 0 1 6,10 A 2,2 0 0 1 8,12 A 2,2 0 0 1 6,14 A 2,2 0 0 1 4,12 Z"
                },
                new ShapePreset()
                {
                    Name = "Gear (Material Design)",
                    ReferenceWidth = 24,
                    ReferenceHeight = 24,
                    PathData = "M 12,15.5 A 3.5,3.5 0 0 1 8.5,12 A 3.5,3.5 0 0 1 12,8.5 A 3.5,3.5 0 0 1 15.5,12 A 3.5,3.5 0 0 1 12,15.5 M 19.43,12.97 C 19.47,12.65 19.5,12.33 19.5,12 C 19.5,11.67 19.47,11.34 19.43,11 L 21.54,9.37 C 21.73,9.22 21.78,8.95 21.66,8.73 L 19.66,5.27 C 19.54,5.05 19.27,4.96 19.05,5.05 L 16.56,6.05 C 16.04,5.66 15.5,5.32 14.87,5.07 L 14.5,2.42 C 14.46,2.18 14.25,2 14,2 H 10 C 9.75,2 9.54,2.18 9.5,2.42 L 9.13,5.07 C 8.5,5.32 7.96,5.66 7.44,6.05 L 4.95,5.05 C 4.73,4.96 4.46,5.05 4.34,5.27 L 2.34,8.73 C 2.21,8.95 2.27,9.22 2.46,9.37 L 4.57,11 C 4.53,11.34 4.5,11.67 4.5,12 C 4.5,12.33 4.53,12.65 4.57,12.97 L 2.46,14.63 C 2.27,14.78 2.21,15.05 2.34,15.27 L 4.34,18.73 C 4.46,18.95 4.73,19.03 4.95,18.95 L 7.44,17.94 C 7.96,18.34 8.5,18.68 9.13,18.93 L 9.5,21.58 C 9.54,21.82 9.75,22 10,22 H 14 C 14.25,22 14.46,21.82 14.5,21.58 L 14.87,18.93 C 15.5,18.67 16.04,18.34 16.56,17.94 L 19.05,18.95 C 19.27,19.03 19.54,18.95 19.66,18.73 L 21.66,15.27 C 21.78,15.05 21.73,14.78 21.54,14.63 L 19.43,12.97 Z"
                },
                new ShapePreset()
                {
                    Name = "Gear (Small Margin) (Material Design)",
                    ReferenceWidth = 22,
                    ReferenceHeight = 22,
                    PathData = "M 11,14.5 A 3.5,3.5 0 0 1 7.5,11 A 3.5,3.5 0 0 1 11,7.5 A 3.5,3.5 0 0 1 14.5,11 A 3.5,3.5 0 0 1 11,14.5 M 18.43,11.97 C 18.47,11.65 18.5,11.33 18.5,11 C 18.5,10.67 18.47,10.34 18.43,10 L 20.54,8.37 C 20.73,8.22 20.78,7.95 20.66,7.73 L 18.66,4.27 C 18.54,4.05 18.27,3.96 18.05,4.05 L 15.56,5.05 C 15.04,4.66 14.5,4.32 13.87,4.07 L 13.5,1.42 C 13.46,1.18 13.25,1 13,1 H 9 C 8.75,1 8.54,1.18 8.5,1.42 L 8.13,4.07 C 7.5,4.32 6.96,4.66 6.44,5.05 L 3.95,4.05 C 3.73,3.96 3.46,4.05 3.34,4.27 L 1.34,7.73 C 1.21,7.95 1.27,8.22 1.46,8.37 L 3.57,10 C 3.53,10.34 3.5,10.67 3.5,11 C 3.5,11.33 3.53,11.65 3.57,11.97 L 1.46,13.63 C 1.27,13.78 1.21,14.05 1.34,14.27 L 3.34,17.73 C 3.46,17.95 3.73,18.03 3.95,17.95 L 6.44,16.94 C 6.96,17.34 7.5,17.68 8.13,17.93 L 8.5,20.58 C 8.54,20.82 8.75,21 9,21 H 13 C 13.25,21 13.46,20.82 13.5,20.58 L 13.87,17.93 C 14.5,17.67 15.04,17.34 15.56,16.94 L 18.05,17.95 C 18.27,18.03 18.54,17.95 18.66,17.73 L 20.66,14.27 C 20.78,14.05 20.73,13.78 20.54,13.63 L 18.43,11.97 Z"
                },
                new ShapePreset()
                {
                    Name = "Minus Circular (Material Design)",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 75,55 H 25 V 45 H 75 M 50,0 A 50,50 0 0 0 0,50 A 50,50 0 0 0 50,100 A 50,50 0 0 0 100,50 A 50,50 0 0 0 50,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Minus Rounded Box (Material Design)",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 112,80 H 32 V 64 H 112 M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0"
                },
                new ShapePreset()
                {
                    Name = "Pencil (Material Design)",
                    ReferenceWidth = 18,
                    ReferenceHeight = 18,
                    PathData = "M 17.71,4.04 C 18.1,3.65 18.1,3 17.71,2.63 L 15.37,0.29 C 15,-0.1 14.35,-0.1 13.96,0.29 L 12.12,2.12 L 15.87,5.87 M 0,14.25 V 18 H 3.75 L 14.81,6.93 L 11.06,3.18 L 0,14.25 Z"
                },
                new ShapePreset()
                {
                    Name = "Pencil Rounded Box (Material Design)",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 115.55,47.2 C 117.5,45.25 117.5,42 115.55,40.15 L 103.85,28.45 C 102,26.5 98.75,26.5 96.8,28.45 L 87.6,37.6 L 106.35,56.35 M 27,98.25 V 117 H 45.75 L 101.05,61.65 L 82.3,42.9 L 27,98.25 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0"
                },
                new ShapePreset()
                {
                    Name = "Play (Material Design)",
                    ReferenceWidth = 112,
                    ReferenceHeight = 112,
                    PathData = "M 0,0 V 112 L 88,56 L 0,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Pause (Material Design)",
                    ReferenceWidth = 112,
                    ReferenceHeight = 112,
                    PathData = "M 72,112 H 104 V 0 H 72 M 8,112 H 40 V 0 H 8 V 112 Z"
                },
                new ShapePreset()
                {
                    Name = "Plus Circular (Material Design)",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 75,55 H 55 V 75 H 45 V 55 H 25 V 45 H 45 V 25 H 55 V 45 H 75 M 50,0 A 50,50 0 0 0 0,50 A 50,50 0 0 0 50,100 A 50,50 0 0 0 100,50 A 50,50 0 0 0 50,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Plus Rounded Box (Material Design)",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 112,80 H 80 V 112 H 64 V 80 H 32 V 64 H 64 V 32 H 80 V 64 H 112 M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Trash Can (Material Design)",
                    ReferenceWidth = 18,
                    ReferenceHeight = 18,
                    PathData = "M 16,1 H 12.5 L 11.5,0 H 6.5 L 5.5,1 H 2 V 3 H 16 M 3,16 A 2,2 0 0 0 5,18 H 13 A 2,2 0 0 0 15,16 V 4 H 3 V 16 Z"
                },
                new ShapePreset()
                {
                    Name = "Trash Can Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 107,32 H 89.5 L 84.5,27 H 59.5 L 54.5,32 H 37 V 48 H 107 M 42,107 A 10,10 0 0 0 52,117 H 92 A 10,10 0 0 0 102,107 V 60 H 42 V 107 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Undo (Material Design)",
                    ReferenceWidth = 22,
                    ReferenceHeight = 22,
                    PathData = "M 11.5,7 C 8.85,7 6.45,8 4.6,9.6 L 1,6 V 15 H 10 L 6.38,11.38 C 7.77,10.22 9.54,9.5 11.5,9.5 C 15.04,9.5 18.05,11.81 19.1,15 L 21.47,14.22 C 20.08,10.03 16.15,7 11.5,7 Z"
                },
                new ShapePreset()
                {
                    Name = "Restore (Material Design)",
                    ReferenceWidth = 16,
                    ReferenceHeight = 16,
                    PathData = "M 8,13 C 5.95,13 4.19,11.76 3.42,10 H 5.13 C 5.76,10.9 6.81,11.5 8,11.5 A 3.5,3.5 0 0 0 11.5,8 A 3.5,3.5 0 0 0 8,4.5 C 6.65,4.5 5.5,5.28 4.9,6.4 L 6.5,8 H 2.5 V 4 L 3.8,5.3 C 4.69,3.92 6.23,3 8,3 A 5,5 0 0 1 13,8 A 5,5 0 0 1 8,13 Z"
                },
                new ShapePreset()
                {
                    Name = "Restore Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 76,117 C 57.55,117 41.71,105.84 34.78,90 H 50.17 C 55.84,98.1 65.29,103.5 76,103.5 A 31.5,31.5 0 0 0 107.5,72 A 31.5,31.5 0 0 0 76,40.5 C 63.85,40.5 53.5,47.52 48.1,57.6 L 62.5,72 H 26.5 V 36 L 38.2,47.7 C 46.21,35.28 60.07,27 76,27 A 45,45 0 0 1 121,72 A 45,45 0 0 1 76,117 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0"
                },
                new ShapePreset()
                {
                    Name = "Stopwatch (Material Design)",
                    ReferenceWidth = 240,
                    ReferenceHeight = 240,
                    PathData = "M 120,200 A 70,70 0 0 1 50,130 A 70,70 0 0 1 120,60 A 70,70 0 0 1 190,130 A 70,70 0 0 1 120,200 M 190.3,73.9 L 204.5,59.7 C 200,54.6 195.5,50 190.4,45.6 L 176.2,60 C 160.7,47.4 141.2,40 120,40 A 90,90 0 0 0 30,130 A 90,90 0 0 0 120,220 C 170,220 210,179.7 210,130 C 210,108.8 202.6,89.3 190.3,73.9 M 110,140 H 130 V 80 H 110 M 150,10 H 90 V 30 H 150 V 10 Z"
                },
                new ShapePreset()
                {
                    Name = "Stopwatch Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 72,112 A 35,35 0 0 1 37,77 A 35,35 0 0 1 72,42 A 35,35 0 0 1 107,77 A 35,35 0 0 1 72,112 M 107.15,48.95 L 114.25,41.85 C 112,39.3 109.75,37 107.2,34.8 L 100.1,42 C 92.35,35.7 82.6,32 72,32 A 45,45 0 0 0 27,77 A 45,45 0 0 0 72,122 C 97,122 117,101.85 117,77 C 117,66.4 113.3,56.65 107.15,48.95 M 67,82 H 77 V 52 H 67 M 87,17 H 57 V 27 H 87 V 17 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Alert Sharp Exclamation (Material Design)",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 1,70.3 L 9.4,50 L 1,29.7 L 21.3,21.3 L 29.7,1 L 50,9.4 L 70.3,1 L 78.7,21.3 L 99,29.7 L 90.6,50 L 99,70.3 L 78.7,78.7 L 70.3,99 L 50,90.6 L 29.7,99 L 21.3,78.7 L 1,70.3 M 55,75 V 65 H 45 V 75 H 55 M 55,55 V 25 H 45 V 55 H 55 Z"
                },
                new ShapePreset()
                {
                    Name = "Alert Sharp Hourglass (Material Design)",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 1,70.3 L 9.4,50 L 1,29.7 L 21.3,21.3 L 29.7,1 L 50,9.4 L 70.3,1 L 78.7,21.3 L 99,29.7 L 90.6,50 L 99,70.3 L 78.7,78.7 L 70.3,99 L 50,90.6 L 29.7,99 L 21.3,78.7 L 1,70.3 M 32.6,20.6 V 38.6 H 32.6 V 38.6 L 44.6,50.6 L 32.6,62.6 V 62.6 H 32.6 V 80.6 H 68.6 V 62.6 H 68.6 V 62.6 L 56.6,50.6 L 68.6,38.6 V 38.6 H 68.6 V 20.6 H 32.6 M 62.6,64.1 V 74.6 H 38.6 V 64.1 L 50.6,52.1 L 62.6,64.1 M 50.6,49.1 L 38.6,37.1 V 26.6 H 62.6 V 37.1 L 50.6,49.1 Z"
                },
                new ShapePreset()
                {
                    Name = "Alert (Material Design)",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 82,82 V 24.5 H 63.25 V 82 H 82 M 82,120.75 V 100.75 H 63.25 V 120.75 H 82 Z"

                },
                new ShapePreset()
                {
                    Name = "Alert Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 82,82 V 24.5 H 63.25 V 82 H 82 M 82,120.75 V 100.75 H 63.25 V 120.75 H 82 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Continue",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 24,84 V 60 H 48 V 40.64 V 84 H 20 Z M 60,84 V 60 H 92 V 40.64 L 123.36,72 L 92,103.36 V 84 H 60 Z"
                },
                new ShapePreset()
                {
                    Name = "Continue Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 24,84 V 60 H 48 V 40.64 V 84 H 20 Z M 60,84 V 60 H 92 V 40.64 L 123.36,72 L 92,103.36 V 84 H 60 Z M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z"
                },
                new ShapePreset()
                {
                    Name = "Hourglass (Material Design)",
                    ReferenceWidth = 100,
                    ReferenceHeight = 100,
                    PathData = "M 21,1 V 31 H 21 V 31 L 41,51 L 21,71 V 71 H 21 V 101 H 81 V 71 H 81 V 71 L 61,51 L 81,31 V 31 H 81 V 1 H 21 M 71,73.5 V 91 H 31 V 73.5 L 51,53.5 L 71,73.5 M 51,48.5 L 31,28.5 V 11 H 71 V 28.5 L 51,48.5 Z"
                }
                ,
                new ShapePreset()
                {
                    Name = "Hourglass Rounded Box",
                    ReferenceWidth = 144,
                    ReferenceHeight = 144,
                    PathData = "M 128,0 H 16 C 7.12,0 0,7.12 0,16 V 128 A 16,16 0 0 0 16,144 H 128 A 16,16 0 0 0 144,128 V 16 C 144,7.12 136.8,0 128,0 Z M 39.52,17.12 V 50.72 H 39.52 V 50.72 L 61.92,73.12 L 39.52,95.52 V 95.52 H 39.52 V 129.12 H 106.72 V 95.52 H 106.72 V 95.52 L 84.32,73.12 L 106.72,50.72 V 50.72 H 106.72 V 17.12 H 39.52 M 95.52,98.32 V 117.92 H 50.72 V 98.32 L 73.12,75.92 L 95.52,98.32 M 73.12,70.32 L 50.72,47.92 V 28.32 H 95.52 V 47.92 L 73.12,70.32 Z"
                }

            };

        }
    }
}
