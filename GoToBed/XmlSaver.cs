using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GoToBed
{
    public class XmlSaver
    {

        public static void SaveData(TimeSpan preferredTime, bool preferredEnabled, bool preferredSexer, bool runOnStartup)
        {

            GoToBedData data = new GoToBedData();
            data.preferredTime = preferredTime.ToString();
            data.preferredEnabled = preferredEnabled;
            data.preferredSexer = preferredSexer;
            data.runOnStartup = runOnStartup;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GoToBedData));

            try
            {
                using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\bedData.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, data);
                }
            } catch (FileNotFoundException) { }

        }

        public static GoToBedData LoadData()
        {

            GoToBedData data = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GoToBedData));
            try
            {
                using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\bedData.xml", FileMode.Open))
                {
                    data = xmlSerializer.Deserialize(fs) as GoToBedData;
                }
            } catch(FileNotFoundException) { }
            if (data == null) return null; else return data;

        }

    }

    public class GoToBedData
    {
        public string preferredTime;
        public bool preferredEnabled;
        public bool preferredSexer;
        public bool runOnStartup;
    }

}
