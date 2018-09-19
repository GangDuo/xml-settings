using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Xml.Settings
{
    public class Destination
    {
        /**
         * <?xml version="1.0" encoding="utf-8" ?>
         * <destinations>
         *   <destination>p1@example.co.jp</destination>
         *   <destination>p2@example.co.jp</destination>
         * </destinations>
         */
        public static List<string> Load(string path)
        {
            var destinations = new List<string>();
            using (var sr = new StreamReader(path))
            {
                var document = XElement.Load(sr);
                foreach (var dst in document.Descendants("destination"))
                {
                    Debug.WriteLine(dst.Value);
                    destinations.Add(dst.Value);
                }
            }
            return destinations;
        }
    }
}
