using System;
using System.Collections.Generic;

namespace NetworkInterface_Manager.NetShellSettings
{
    public class NetworkInterfaceSettingsManager
    {
        public static List<NetworkInterfaceSettings> networkInterfaceConfigs = new List<NetworkInterfaceSettings>();

        public static String XMLPath = "networkInterfaceConfigs.xml";

        public static void LoadList() {
            if (System.IO.File.Exists(XMLPath)) {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<NetworkInterfaceSettings>));
                System.IO.StreamReader file = new System.IO.StreamReader(XMLPath);
                networkInterfaceConfigs = (List <NetworkInterfaceSettings>)reader.Deserialize(file);
                file.Close();
            }
        }

        public static void SaveList(){
            Console.WriteLine("Hello"); 
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<NetworkInterfaceSettings>));
            System.IO.FileStream file = System.IO.File.Create(XMLPath);
            writer.Serialize(file, networkInterfaceConfigs);
            file.Close();
        }

    }
}
