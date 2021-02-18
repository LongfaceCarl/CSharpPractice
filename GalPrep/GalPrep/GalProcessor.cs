using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GalPrep
{
    class GalProcessor//
    {
        private int lineNumber = 0;//Records the current line but do not allow direct edit
        private List<GalLine> storyData = new List<GalLine>();//Each Line is processed in to a new type called GalLine

        private string speakerName = "";
        public int LineNumber//Converting lineNumber
        {
            //This is so the way user think about line number can be easilly
            //synchronized with the way the computer thinks without repeated
            //conversion, always access lineNumber from LineNumber.
            get { return lineNumber + 1; }
            set { lineNumber = value - 1; }
        }
        public void Initiate()
        {
            //File reading is handled at GalProperties, just more customized
            string rawDataFromFile = GalProperties.FileReader("");
            //Conversion to array
            string [] storyDataString = rawDataFromFile.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //Turn the array into an GalLine list, where each line was pre-processed on initialization
            for(int i = 0; i < storyDataString.Length; i++)
            {
                storyData.Add(new GalLine(storyDataString[i]));
            }
        }
        public bool ReachedEnd()
        {
            //Simple property to test when reach end in a more readable way
            //This also avoids repetedly typing the same thing again
            return (lineNumber >= storyData.Count); 
        }
        public void Next()
        {
            //When the end is not reached, line number will still be able to increase
            //This Test for end here actually does not work at all, since when on the
            //last line, this would still go over to the line that cannot be accessed

            //I guess you can say this is here as a reminder
            if (!ReachedEnd())
            {
                lineNumber += 1;
            }
        }
        public string CurrentLine()
        {
            //Getting the current line
            GalLine currentLine = storyData[lineNumber];
            //Do something is the current line is a command
            while (currentLine.isCommand)
            {
                //Execute the command
                PhraseCommand(currentLine.command, currentLine.parameters);
                Next();
                //When end reached, break
                if (ReachedEnd())
                {
                    break;
                }
                //If there is indeed a next line, read it
                currentLine = storyData[lineNumber];
            }
            //Set the line to print
            return speakerName + "> " + storyData[lineNumber].lineText;
        }
        public void PhraseCommand(string command, string[] parameters)
        {
            if (command == "/setSpeakerName")
            {
                speakerName = parameters[0];
            }
            if (command == "/skipToAfter")
            {
                LineNumber = Convert.ToInt32(parameters[0]);
            }
        }
    }
}
