using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Program_CADCAM.Configuration
{
    internal class Connection
    {
        public static string? ConnectionString { get; private set; }

        public static void LoadConnectionString()
        {
            string configPath = Path.Combine(Application.StartupPath, "config.xml");

            if (!File.Exists(configPath))
            {
                MessageBox.Show("Database configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FileNotFoundException("Configuration file not found.", configPath);
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(configPath);

                XmlNode? node = doc.SelectSingleNode("/configuration/connectionString");

                if (node == null)
                {
                    MessageBox.Show("Connection string not found in configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("Connection string node not found in XML.");
                }

                ConnectionString = node.InnerText.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
