﻿using System;
using System.IO;
using GM.Shared.Models;
using GM.Shared.Utilities;

namespace GM.Backend.ProcessTranscriptLib
{
    public class ProcessTranscripts
    {
        string datafiles;

        public ProcessTranscripts(string _datafiles)
        {
            datafiles = _datafiles;
        }

        public bool Process(string filename)
        {
            bool created;
            MeetingInfo mi = new MeetingInfo(filename);
            string meetingFolder = mi.MeetingFolder(datafiles);
            if (!(created = Directories.Create(meetingFolder)))
            {
                Console.WriteLine("ProcessTranscripts.cs - ERROR: Could not create meeting folder. It may already exist.");
                return false;
            }

            // Step 1 - Copy PDF to meeting directory

            FileInfo infile = new FileInfo(filename);
            string outfile = meetingFolder + "\\" + "T1-PDF.pdf";
            File.Copy(filename, outfile);

            // Step 2 - Convert the PDF file to text

            string text = ConvertPdfToText.Convert(outfile);
            outfile = meetingFolder + "\\" + "T2-TXT.txt";
            File.WriteAllText(outfile, text);

            // Step 3 - Fix the transcript: Put in common format

            // Make the specific fixes to the philly data
            Specific_Philadelphia_PA_USA philly = new Specific_Philadelphia_PA_USA("2016-03-17", meetingFolder);
            string transcript = philly.Fix(text);

            // Convert the fixed transcript to JSON
            ConvertToJson.Convert(ref transcript);
            outfile = meetingFolder + "\\" + "T3-ToBeTagged.json";
            File.WriteAllText(outfile, transcript);

            return true;
        }

    }
}