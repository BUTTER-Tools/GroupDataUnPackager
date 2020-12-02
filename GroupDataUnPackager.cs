using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using GroupDataObj;
using System.Text;

namespace GroupDataUnPackager
{
    public class GroupDataUnPackager : Plugin
    {


        public string[] InputType { get; } = { "GroupData" };
        public string OutputType { get; } = "String";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "Text" } };
        public bool InheritHeader { get; } = false;

        #region Plugin Details and Info

        public string PluginName { get; } = "Group Data Un-Packager";
        public string PluginType { get; } = "Dyads & Groups";
        public string PluginVersion { get; } = "1.0.1";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Takes a GroupData input and unpacks it into separate Strings per person. This can be useful if you have used the \"Conversation Splitter\" plugin and would then like to do other analyses to each speaker's text individually. For example, you may want to measure Readability scores for each person independently, or you may want to save each person's texts to a separate file.";
        public string PluginTutorial { get; } = "https://youtu.be/E63oRr9lvd0";
        public bool TopLevel { get; } = false;
        
        private bool aggregateText { get; set; } = true;


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_GroupDataUnPackager(aggregateText))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    aggregateText = form.aggregateText;
                }
            }

        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;


            for (int i = 0; i < Input.ObjectList.Count; i++)
            {

                GroupData group = (GroupData)Input.ObjectList[i];

                //if we're opting to aggregate peoples' texts, then we do it this way
                if (aggregateText)
                {
                    for (int j = 0; j < group.People.Count; j++)
                    {
                        //build out the person's text into a single string
                        StringBuilder personText = new StringBuilder();
                        for (int personTurn = 0; personTurn < group.People[j].text.Count; personTurn++) personText.AppendLine(group.People[j].text[personTurn]);

                        pData.StringList.Add(personText.ToString());
                        pData.SegmentID.Add(group.People[j].id);
                        pData.SegmentNumber.Add(Input.SegmentNumber[i]);
                    }
                }
                //otherwise, we do it this way
                else
                {

                    Dictionary<string, int> personPositions = new Dictionary<string, int>();
                    //first, we start out by figuring out where in the "people" list each person is
                    for (int j = 0; j < group.People.Count; j++)
                    {
                        personPositions.Add(group.People[j].id, j);
                    }

                    for (ulong j = 0; j < (ulong)group.TurnTracker.Count; j++)
                    {

                        //group.TurnTracker[j] = where a person is in the group.People list
                        
                        //text
                        pData.StringList.Add(
                                                group.People[personPositions[group.TurnTracker[j].Item1]].text[group.TurnTracker[j].Item2]
                                            );
                        //speaker tag
                        pData.SegmentID.Add(group.People[personPositions[group.TurnTracker[j].Item1]].id);
                        pData.SegmentNumber.Add(j+1);

                    }
                }


            }


            return (pData);

        }



        public void Initialize() { }

        public bool InspectSettings()
        {
            return true;
        }

        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }




        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            aggregateText = Boolean.Parse(SettingsDict["aggregateText"]);
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("aggregateText", aggregateText.ToString());
            return (SettingsDict);
        }
        #endregion

    }
}
