using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SRP
{
    public class WorkReport: IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));


        //public void SaveToFile(string directoryPath, string fileName) {
        //    if (!Directory.Exists(directoryPath))
        //        Directory.CreateDirectory(directoryPath);

        //    File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        //}
    }
}
