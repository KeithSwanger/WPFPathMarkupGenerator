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


        public static string ResizePathData(float refW, float refH, float inputOffsetW, float inputOffsetH, float targetW, float targetH, float outputOffsetW, float outputOffsetH, string data)
        {
            string[] parsedData = ParseString(data);
            List<string> finalProcessedData = new List<string>();

            Position lastPosition = new Position(0f + inputOffsetW, 0f + inputOffsetH);
            for (int i = 0; i < parsedData.Length; i++)
            {
                string d = parsedData[i];

                if (d == "M" || d == "m" || d == "L" || d == "l" || d == "C" || d == "c" || d == "Q" || d == "q" || d == "S" || d == "s" || d == "T" || d == "t")
                {
                    finalProcessedData.Add(d);


                    int j = i + 1;
                    while (j < parsedData.Length && parsedData[j].Contains(","))
                    {
                        string[] splitPos = parsedData[j].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        Position pos = new Position(float.Parse(splitPos[0]) + inputOffsetW, float.Parse(splitPos[1]) + inputOffsetH);

                        // if lower case is used, then this is a relative position, so offset the last position
                        if (char.IsLower(d[0]))
                        {
                            pos.x += lastPosition.x;
                            pos.y += lastPosition.y;
                        }

                        Position mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);
                        mappedPos.x += outputOffsetW;
                        mappedPos.y += outputOffsetH;

                        finalProcessedData.Add(mappedPos.ToString());

                        lastPosition = pos;
                        j++;
                    }

                }
                else if (d == "H" || d == "h")
                {
                    finalProcessedData.Add(d);

                    int j = i + 1;

                    Position pos = new Position(float.Parse(parsedData[j]) + inputOffsetW, lastPosition.y);
                    if (char.IsLower(d[0]))
                    {
                        pos.x += lastPosition.x;
                    }

                    Position mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);
                    mappedPos.x += outputOffsetW;

                    finalProcessedData.Add(mappedPos.x.ToString());

                    lastPosition = pos;
                }
                else if (d == "V" || d == "v")
                {
                    finalProcessedData.Add(d);

                    int j = i + 1;

                    Position pos = new Position(lastPosition.x, float.Parse(parsedData[j]) + inputOffsetH);
                    if (char.IsLower(d[0]))
                    {
                        pos.y += lastPosition.y;
                    }

                    Position mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);
                    mappedPos.y += outputOffsetH;

                    finalProcessedData.Add(mappedPos.y.ToString());

                    lastPosition = pos;
                }
                else if (d == "A" || d == "a")
                {
                    finalProcessedData.Add(d);
                    //int j = i + 1;

                    string[] splitArc = new string[7];

                    // Remove all all commas for better parsing
                    for(int j = i + 1, k = 0; j < parsedData.Length; j++)
                    {
                        if (char.IsLetter(parsedData[j][0]))
                        {
                            break; // no more data to be parsed for this arc
                        }

                        // split at commas and add to the split data
                        string[] splitString = parsedData[j].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        for(int l = 0; l < splitString.Length; l++)
                        {
                            splitArc[k] = splitString[l];
                            k++;
                        }
                    }

                    // Size
                    Position pos = new Position(float.Parse(splitArc[0]), float.Parse(splitArc[1]));
                    Position mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);
                    finalProcessedData.Add(mappedPos.ToString());

                    // Rotation Angle
                    finalProcessedData.Add(splitArc[2]);

                    // isLargeArcFlag
                    finalProcessedData.Add(splitArc[3]);


                    // sweepDirectionFlag
                    finalProcessedData.Add(splitArc[4]);

                    // End Point
                    pos = new Position(float.Parse(splitArc[5]) + inputOffsetW, float.Parse(splitArc[6]) + inputOffsetH);

                    if (char.IsLower(d[0]))
                    {
                        pos.x += lastPosition.x;
                        pos.y += lastPosition.y;
                    }

                    mappedPos = MapPointToTarget(refW, refH, targetW, targetH, pos);
                    mappedPos.x += outputOffsetW;
                    mappedPos.y += outputOffsetH;

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

            // TODO: Add relative output support, right now relative inputs only work as absolute outputs
            return resizedPathData.ToUpper();
        }

        static string[] ParseString(string data)
        {
            // Add space buffers for each path markup character if there is none so the data can be parsed correctly.
            string dataWithAddedSpaces = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (Char.IsLetter(data[i]))
                {
                    if (i > 0)
                    {
                        if (!Char.IsWhiteSpace(data[i - 1]))
                        {
                            dataWithAddedSpaces += " ";
                        }
                    }

                    dataWithAddedSpaces += data[i];

                    if(i < data.Length - 1)
                    {
                        if(!char.IsWhiteSpace(data[i + 1]))
                        {
                            dataWithAddedSpaces += " ";
                        }
                    }
                }
                else
                {
                    dataWithAddedSpaces += data[i];
                }
            }

            return dataWithAddedSpaces.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        static Position MapPointToTarget(float refW, float refH, float targetW, float targetH, Position positionToMap)
        {
            Position mappedPosition = new Position();

            mappedPosition.x = (positionToMap.x / refW) * targetW;
            mappedPosition.y = (positionToMap.y / refH) * targetH;

            return mappedPosition;
        }
    }
}
