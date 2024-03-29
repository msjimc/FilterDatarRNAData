﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterDatarRNAData
{
    public partial class Form1 : Form
    {
        string DataFile = "";
        int numberOfSamples = -1;
        string titles = "";
        string titleNames = "";
        string titlesExtraBits = "";
        string[] titleColumns;
        int fromSize = 0;
        int tooSize = 1000;
        int identityCutoff = 98;
        int taxonomicLevel = 10;
        Dictionary<string, DataLine> dls;//= null;

        public Form1()
        {
            InitializeComponent();
        }

        private void setValues()
        {
            fromSize = (int)nudFrom.Value -1;
            tooSize = (int)nudToo.Value+1;
            identityCutoff = (int)nudPercentIdentity.Value;
            taxonomicLevel = (int)nudTaxonomyLevel.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataFile = FileString.OpenAs("Select the OTU counts data file", "*.txt;*.xls|*.txt;*.xls");
            if (System.IO.File.Exists(dataFile) == false)
            { return; }

            btnImport.Enabled=false;

            System.IO.StreamReader fr = null;
            try
            {
                fr = new System.IO.StreamReader(dataFile);
                string line = fr.ReadLine();
                string[] items = line.Split('\t');
                titleColumns = items;
                if (items.Length  > 0)
                {
                    cboDataStart.Items.Clear();
                    cboDataEnd.Items.Clear();
                    cboSequenceColumn.Items.Clear();
                    cboTaxonomyStart.Items.Clear();

                    cboDataStart.Items.Add("Select column");
                    cboDataEnd.Items.Add("Select column");
                    cboSequenceColumn.Items.Add("Select column");
                    cboPercent.Items.Add("Select column");
                    cboTaxonomyStart.Items.Add("Select column");

                    foreach (string item in items)
                    {
                        cboDataStart.Items.Add(item);
                        cboDataEnd.Items.Add(item);
                        cboSequenceColumn.Items.Add(item);
                        cboPercent.Items.Add(item);
                        cboTaxonomyStart.Items.Add(item);
                    }

                    cboDataStart.SelectedIndex = 0;
                    cboDataEnd.SelectedIndex = 0;
                    cboSequenceColumn.Items.Add("No sequence data");

                    int setIndex = 0;
                    for (int index = 0; index < cboSequenceColumn.Items.Count; index++)
                    {
                        string columnName = cboSequenceColumn.GetItemText(cboSequenceColumn.Items[index]).ToLower();
                        if (columnName.StartsWith("sequence") == true)
                        { setIndex = index; }
                    }
                    cboSequenceColumn.SelectedIndex = setIndex;

                    cboPercent.Items.Add("No alignment data");
                    setIndex = 0;
                    for (int index = 0; index < cboPercent.Items.Count; index++)
                    {
                        string columnName = cboPercent.GetItemText(cboPercent.Items[index]).ToLower();
                        if (columnName.StartsWith("percent") == true)
                        { setIndex = index; }
                    }
                    cboPercent.SelectedIndex = setIndex;

                    setIndex = 0;
                    for (int index = 0; index < cboTaxonomyStart.Items.Count; index++)
                    {
                        string columnName = cboTaxonomyStart.GetItemText(cboTaxonomyStart.Items[index]).ToLower();
                        if (columnName.StartsWith("superkingdom") == true)
                        { setIndex = index; }
                    }
                    cboTaxonomyStart.SelectedIndex = setIndex;

                    setIndex = 0;
                    for (int index = 0; index < cboPercent.Items.Count; index++)
                    {
                        string columnName = cboPercent.GetItemText(cboPercent.Items[index]).ToLower();
                        if (columnName.StartsWith("percent") == true)
                        { setIndex = index; }
                    }
                    cboPercent.SelectedIndex = setIndex;

                    DataFile = dataFile;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Could not read file" + "\n" + ex.Message, "Error"); }
            finally
            { if (fr.BaseStream != null) { fr.Close(); } }

        }

        private void processFile()
        {
            this.Enabled = false;
            btnExport.Enabled = false;
            btnFiltered.Enabled = false;
            System.IO.StreamReader fr = null;

            try
            {
                setValues();

                fr = new System.IO.StreamReader(DataFile);

                dls = new Dictionary<string, DataLine>();


                string line = fr.ReadLine();
                string[] items = line.Split('\t');
                titles = line;
                //int length = 0;
                //for (int index = 0; index<items.Length; index++)
                //{
                //    if (items[index].Equals("Sequence") == true && length == 0)
                //    { length = index+1; }
                //}
                //numberOfSamples = length;

                numberOfSamples = cboDataEnd.SelectedIndex + 1 - cboDataStart.SelectedIndex;

                string[] sampleNames = new string[numberOfSamples];
                Array.Copy(items, cboDataStart.SelectedIndex - 1, sampleNames, 0, sampleNames.Length);
                titleNames = string.Join("\t", sampleNames);
                titlesExtraBits = line.Substring(line.LastIndexOf("\tKingdom\t") + 1);
                int newAdd = 0;
                int repeat = 0;
                int wrongSize = 0;
                int poorHit = 0;
                int lines = 0;
                int counter = 0;

                int dataStart = cboDataStart.SelectedIndex - 1;
                int percentColumn = cboPercent.SelectedIndex - 1;
                int taxonomyColumn = cboTaxonomyStart.SelectedIndex - 1;
                int sequenceColumn = cboSequenceColumn.SelectedIndex -1;

                while (fr.Peek() > 0)
                {
                    lines++;
                    counter++;

                    line = fr.ReadLine();
                    items = line.Split('\t');
                    if (items[items.GetUpperBound(0)].ToLower().StartsWith("no info") == false && string.IsNullOrEmpty(items[items.GetUpperBound(0)]) == false)
                    {
                        DataLine dl = new DataLine(items, numberOfSamples, taxonomicLevel, dataStart, percentColumn, taxonomyColumn, sequenceColumn);

                        if (fromSize < dl.getSize && tooSize > dl.getSize)
                        {
                            if (identityCutoff <= dl.getPercent)
                            {
                                string key = dl.getKey;

                                if (dls.ContainsKey(key) == false)
                                {
                                    dls.Add(key, dl);
                                    newAdd++;
                                }
                                else
                                {
                                    dls[key].AddReads(items, dataStart);
                                    repeat++;
                                }

                            }
                            else { poorHit++; }
                        }
                        else { wrongSize++; }
                    }
                    else
                    { poorHit++; }

                    if (counter > 1000)
                    {
                        counter = 0;
                        lblResults.Text = "Lines read: " + lines.ToString() + "\nOTUs added: " + newAdd.ToString() + " \nSequence wrong size: " + wrongSize.ToString() + "\nPoor blast hit: " + poorHit.ToString();
                        Application.DoEvents();
                    }
                }

                int retainedHits = 0;
                foreach (DataLine dl in dls.Values)
                {
                    retainedHits += dl.getNumberofHits;
                }
                lblResults.Text = "Lines read: " + lines.ToString() + "\nOTUs added: " + newAdd.ToString() + " \nSequence wrong size: " + wrongSize.ToString() + "\nPoor blast hit: " + poorHit.ToString() + "\nTotal number of hits: " + retainedHits.ToString();

                btnFiltered.Enabled = true;
                btnExport.Enabled = true;
            }
            catch (Exception ex) { }
            finally
            {
                this.Enabled = true;
                if (fr.BaseStream != null) { fr.Close(); }
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string exportFile = FileString.SaveAs("Enter name of file to save data too", "*.xls|*.xls");
            if (exportFile.Equals("Cancel") == true) { return; }

            System.IO.StreamWriter fw = null;

            try
            {
                fw = new System.IO.StreamWriter(exportFile);
                fw.WriteLine(WriteTitles(titles, taxonomicLevel, cboDataStart.SelectedIndex - 1));

                if (rboAbsolute.Checked == true)
                {
                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.Write()); }
                }
                else if (rboProportions.Checked == true)
                {
                    int[] librarySizes = new int[numberOfSamples];
                    foreach (DataLine dl in dls.Values)
                    { librarySizes = dl.GetCounts(librarySizes); }

                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.WriteProportions(librarySizes)); }
                }
                else if (rboPercent.Checked == true)
                {
                    int[] librarySizes = new int[numberOfSamples];
                    foreach (DataLine dl in dls.Values)
                    { librarySizes = dl.GetCounts(librarySizes); }

                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.WritePercent(librarySizes)); }
                }
                else { throw new Exception("Value not found"); }

            }
            catch (Exception ex)
            { }
            finally
            { if (fw != null) { fw.Close(); } }

        }

        private string WriteTitles(string title, int levels, int dataStart)
        {

            string[] items = titlesExtraBits.Split('\t');
            if (levels > items.Length)
            { levels = items.Length; }
            string[] partList = new string[levels];
            Array.Copy(items, 0, partList, 0, levels);

            for (int index = 0; index < dataStart; index++)
            { title = title.Substring(title.IndexOf('\t') + 1); }
            title = "Name\t" + title;

            string theTile = title.Substring(0, title.IndexOf("Sequence") -1) + "\t" + string.Join("\t", partList);
            return theTile;

        }

        private void btnFiltered_Click(object sender, EventArgs e)
        {
            string sampleKey = FileString.OpenAs("Select the files of sample names v file names", "(*.txt)|*.txt");
            if (System.IO.File.Exists(sampleKey) == false) { return; }

            Dictionary<string, string> keys = new Dictionary<string, string>();
            string filtered = "";
            System.IO.StreamReader fr = null;
            try
            {
                fr = new System.IO.StreamReader(sampleKey);
                string line = null;
                string[] items = null;
                fr.ReadLine();
                while (fr.Peek() > 0)
                {
                    line = fr.ReadLine();
                    items = line.Split('\t');
                    if (keys.ContainsKey(items[1].Trim()) == false)
                    {
                        keys.Add(items[1].Trim(), items[0].Trim());
                    }
                }
                items = titleNames.Split('\t');

                int counter = 0;
                foreach (string f in items)
                {
                    if (keys.ContainsKey(f) == true)
                    { filtered += keys[f] + "\t"; counter++; }
                }
            }
            catch (Exception ex) { return; }
            finally { if (fr != null) { fr.Close(); } }

            string exportFile = FileString.SaveAs("Enter name of file to save data too", "*.xls|*.xls");
            if (exportFile.Equals("Cancel") == true) { return; }

            System.IO.StreamWriter fw = null;

            try
            {
                fw = new System.IO.StreamWriter(exportFile);

                string titleBits = WriteTitles(titles, taxonomicLevel, cboDataStart.SelectedIndex - 1);
                fw.WriteLine("Fasta Names\t" + filtered + titleBits.Substring(titleBits.IndexOf("\tKingdom\t") + 1));

                if (rboAbsolute.Checked == true)
                {
                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.WriteSampleFliteredtext(titleNames.Split('\t'), keys)); }
                }
                else if (rboPercent.Checked ==true)
                {
                    int[] librarySizes = new int[numberOfSamples];
                    foreach (DataLine dl in dls.Values)
                    { librarySizes = dl.GetCounts(librarySizes); }

                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.WriteSampleFliteredtextPercent(librarySizes, titleNames.Split('\t'), keys)); }
                }
                else if (rboProportions.Checked==true)
                {
                    int[] librarySizes = new int[numberOfSamples];
                    foreach (DataLine dl in dls.Values)
                    { librarySizes = dl.GetCounts(librarySizes); }

                    foreach (DataLine dl in dls.Values)
                    { fw.WriteLine(dl.WriteSampleFliteredtextProportions(librarySizes, titleNames.Split('\t'), keys)); }
                }
            }
            catch (Exception ex)
            { }
            finally
            { if (fw != null) { fw.Close(); } }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTaxonomyName.SelectedIndex = 31 - 1;
        }

        private void nudTaxonomyLevel_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)nudTaxonomyLevel.Value;
            cboTaxonomyName.SelectedIndex = value - 1;
            testImportSelection();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void testImportSelection()
        {
            if (cboDataEnd.SelectedIndex > 0 && cboDataStart.SelectedIndex>0 && cboSequenceColumn.SelectedIndex>0 && cboTaxonomyName.SelectedIndex > 0 && cboPercent.SelectedIndex > 0)
            { btnImport.Enabled=true; }
            else
            { btnImport.Enabled = false; }
        }

        private void cboDataStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            testImportSelection();
        }

        private void cboDataEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            testImportSelection();
        }

        private void cboSequenceColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            testImportSelection();
        }
        private void cboPercent_SelectedIndexChanged(object sender, EventArgs e)
        {
            testImportSelection();
        }
        private void cboTaxonomyStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nudTaxonomyLevel.Minimum = 1;
                cboTaxonomyName.Items.Clear();
                int index = cboTaxonomyStart.SelectedIndex - 1;
                for (int item = index; item < titleColumns.Length; item++)
                { cboTaxonomyName.Items.Add(titleColumns[item]); }
                nudTaxonomyLevel.Maximum = cboTaxonomyName.Items.Count;
                nudTaxonomyLevel.Value = nudTaxonomyLevel.Maximum;
                nudTaxonomyLevel.Enabled = true;
                testImportSelection();
            }
            catch (Exception ex)
            {; }// MessageBox.Show("An error occured: " + ex.Message); }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            processFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}