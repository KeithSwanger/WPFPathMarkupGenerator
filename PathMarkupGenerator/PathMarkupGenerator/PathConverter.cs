using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace PathMarkupGenerator
{
    public static class PathConverter
    {


        public static string ResizePathData(float refW, float refH, float targetW, float targetH, string data)
        {
            string[] parsedData = ParseString(data);
            List<string> finalProcessedData = new List<string>();

            Vector2 lastPosition = new Vector2(0f, 0f);
            for (int i = 0; i < parsedData.Length; i++)
            {
                string d = parsedData[i];

                if (d == "M" || d == "m" || d == "L" || d == "l" || d == "C" || d == "c" || d == "Q" || d == "q" || d == "S" || d == "s")
                {
                    finalProcessedData.Add(d);


                    int j = i + 1;
                    while (j < parsedData.Length && parsedData[j].Contains(","))
                    {
                        string[] splitPos = parsedData[j].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        Vector2 pos = new Vector2(float.Parse(splitPos[0]), float.Parse(splitPos[1]));

                        // if lower case is used, then this is a relative position, so offset the last position
                        if (char.IsLower(d[0]))
                        {
                            pos.x += lastPosition.x;
                            pos.y += lastPosition.y;
                        }

                        Vector2 mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);

                        finalProcessedData.Add(mappedPos.ToString());

                        lastPosition = pos;
                        j++;
                    }

                }
                else if (d == "H" || d == "h")
                {
                    finalProcessedData.Add(d);

                    int j = i + 1;

                    Vector2 pos = new Vector2(float.Parse(parsedData[j]), lastPosition.y);
                    if (char.IsLower(d[0]))
                    {
                        pos.x += lastPosition.x;
                    }

                    Vector2 mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);

                    finalProcessedData.Add(mappedPos.x.ToString());

                    lastPosition = pos;
                }
                else if (d == "V" || d == "v")
                {
                    finalProcessedData.Add(d);

                    int j = i + 1;

                    Vector2 pos = new Vector2(lastPosition.x, float.Parse(parsedData[j]));
                    if (char.IsLower(d[0]))
                    {
                        pos.y += lastPosition.y;
                    }

                    Vector2 mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);

                    finalProcessedData.Add(mappedPos.y.ToString());

                    lastPosition = pos;
                }
                else if (d == "A" || d == "a")
                {
                    finalProcessedData.Add(d);
                    int j = i + 1;

                    // Size
                    string[] splitPos = parsedData[j].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Vector2 pos = new Vector2(float.Parse(splitPos[0]), float.Parse(splitPos[1]));

                    Vector2 mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);

                    finalProcessedData.Add(mappedPos.ToString());
                    j++;

                    // Rotation Angle
                    finalProcessedData.Add(parsedData[j]);
                    j++;

                    // isLargeArcFlag
                    finalProcessedData.Add(parsedData[j]);
                    j++;

                    // sweepDirectionFlag
                    finalProcessedData.Add(parsedData[j]);
                    j++;

                    // End Point
                    if (char.IsLower(d[0]))
                    {
                        pos.x += lastPosition.x;
                        pos.y += lastPosition.y;
                    }

                    mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);

                    finalProcessedData.Add(mappedPos.ToString());

                    lastPosition = pos;
                }
                else if (d == "Z" || d == "z")
                {
                    finalProcessedData.Add(d);
                }

            }


            string resizedPathData = "";

            for (int i = 0; i < finalProcessedData.Count; i++)
            {
                resizedPathData += finalProcessedData[i];

                if((i + 1) != finalProcessedData.Count)
                {
                    resizedPathData += " ";
                }
            }

            return resizedPathData;
        }

        static string[] ParseString(string data)
        {
            return data.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        static Vector2 MapPointToTarget(float refW, float refH, float targetW, float targetH, Vector2 positionToMap)
        {
            Vector2 mappedPosition = new Vector2();

            mappedPosition.x = (positionToMap.x / refW) * targetW;
            mappedPosition.y = (positionToMap.y / refH) * targetH;

            return mappedPosition;
        }
    }
}
