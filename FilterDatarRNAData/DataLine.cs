using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterDatarRNAData
{
    class DataLine
    {
        int[] counts = null;
        int NumberOfHits = 0;
        //string[] otherData = null;
        string[] lineage = null;
        int sequenceLength = 0;
        Single percent = 0;

        public DataLine(string[] items, int length, int level, int firstCountColumn, int percentColumn, int taxonomyColumn, int sequenceColumn)
        {
            int datalength = items.Length;
            int readlength = length;
            counts = new int[readlength];
            int lineageLength = items.Length - taxonomyColumn;
            if (level < lineageLength + 1)
            { lineageLength = level; }

            lineage = new string[lineageLength];

            for (int index = firstCountColumn; index < firstCountColumn + counts.Length; index++)
            {
                int i = Convert.ToInt32(items[index]);
                counts[index - firstCountColumn] = i;
                NumberOfHits += i;
            }
            if (percentColumn != items.Length)
            { percent = Convert.ToSingle(items[percentColumn]); }
            else { percent = 100f; }

            if (sequenceColumn != items.Length)
            { sequenceLength = items[sequenceColumn].Length; }
            else { sequenceLength = -1; }

            Array.Copy(items, taxonomyColumn, lineage, 0, lineage.Length);

        }

        public string getKey { get { return string.Join("\t", lineage); } }
        public Single getPercent { get { return percent; } }
        public int getSize { get { return sequenceLength; } }
        public int[] getReads { get { return counts; } }


        public void AddReads(string[] items, int dataStart)
        {
            for (int index = 0; index < counts.Length; index++)
            {
                int i = Convert.ToInt32(items[index + dataStart]);
                counts[index] += i;
                NumberOfHits += i;
            }
        }

        public string Write()
        {
            StringBuilder sb = new StringBuilder(lineage[lineage.GetUpperBound(0)]);
            foreach (int i in counts)
            { sb.Append("\t" + i.ToString()); }
            sb.Append("\t" + getKey);

            return sb.ToString();
        }

        public string WriteProportions(int[] LibrarySizes)
        {
            StringBuilder sb = new StringBuilder(lineage[lineage.GetUpperBound(0)]);
            for (int index = 0; index < counts.Length; index++)
            {
                if (LibrarySizes[index] == 0)
                { sb.Append("\t0"); }
                else
                { sb.Append("\t" + ((Single)counts[index] / LibrarySizes[index]).ToString()); }
            }
            sb.Append("\t" + getKey);

            return sb.ToString();
        }

        public string WritePercent(int[] LibrarySizes)
        {
            StringBuilder sb = new StringBuilder(lineage[lineage.GetUpperBound(0)]);
            for (int index = 0; index < counts.Length; index++)
            {
                if (LibrarySizes[index] == 0)
                {
                    sb.Append("\t0");
                }
                else
                { sb.Append("\t" + ((Single)counts[index] * 100 / LibrarySizes[index]).ToString()); }
            }
            sb.Append("\t" + getKey);

            return sb.ToString();
        }

        public int getNumberofHits { get { return NumberOfHits; } }

        private int[] getSampleFilteredCounts(string[] FileNames, Dictionary<string, string> SampleKey)
        {
            int[] toexport = new int[SampleKey.Count];
            int index = 0;
            int sample = 0;

            foreach (string name in FileNames)
            {
                if (SampleKey.ContainsKey(name) == true)
                {
                    toexport[index] = counts[sample];
                    index++;
                }
                sample++;
            }
            return toexport;
        }

        public string WriteSampleFliteredtext(string[] FileNames, Dictionary<string, string> SampleKey)
        {
            string answer = lineage[lineage.GetUpperBound(0)];
            int sample = 0;
            foreach (string name in FileNames)
            {
                if (SampleKey.ContainsKey(name) == true)
                { answer += "\t" + counts[sample].ToString(); }
                sample++;
            }
            return answer + "\t" + getKey;
        }

        public string WriteSampleFliteredtextProportions(int[] LibrarySizes, string[] FileNames, Dictionary<string, string> SampleKey)
        {
            string answer = lineage[lineage.GetUpperBound(0)];
            int sample = 0;
            foreach (string name in FileNames)
            {
                if (SampleKey.ContainsKey(name) == true)
                {
                    if (LibrarySizes[sample] > 0)
                    { answer += "\t" + ((Single)counts[sample] / LibrarySizes[sample]).ToString(); }
                    else
                    { answer = "\t0"; }
                }
                sample++;
            }
            return answer + "\t" + getKey;
        }

        public string WriteSampleFliteredtextPercent(int[] LibrarySizes, string[] FileNames, Dictionary<string, string> SampleKey)
        {
            string answer = lineage[lineage.GetUpperBound(0)];
            int sample = 0;
            foreach (string name in FileNames)
            {
                if (SampleKey.ContainsKey(name) == true)
                {
                    if (LibrarySizes[sample] > 0)
                    { answer += "\t" + ((Single)counts[sample] * 100 / LibrarySizes[sample]).ToString(); }
                    else
                    { answer = "\t0"; }
                }
                sample++;
            }
            return answer + "\t" + getKey;
        }

        public int[] GetCounts(int[] Counts)
        {
            for (int index = 0; index < counts.Length; index++)
            { Counts[index] += counts[index]; }

            return Counts;
        }
    }
}