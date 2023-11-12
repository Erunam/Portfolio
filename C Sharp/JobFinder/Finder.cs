using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace JobFinder
{
    class Finder
    {
        private string Folder;
        private List<string[]> JobList;

        public List<string[]> Rows
        {
            get{return this.JobList;}
        }

        public Finder(string Folder)
        {
            this.Folder = Folder;
            this.JobList = new List<string[]>();
        }
        private string[] GetZipFilesList(string path)
        {
            string[] ZipFilesList = Directory.GetFiles(path);
            return ZipFilesList;
        }
        private void GetJobs(string name, string JobNumber)
        {
            ZipFile zipfile = new ZipFile(name);
            if (JobNumber == @"" || JobNumber == @"*")
            {
                foreach (ZipEntry e in zipfile)
                {
                    AddEntryToList(e);
                }
            }
            else
            {
                foreach (ZipEntry e in zipfile)
                {
                    string[] jobname = e.Name.Split('/'); // bug fix
                    if (e.IsFile & jobname[1].StartsWith(JobNumber, StringComparison.OrdinalIgnoreCase))
                    {
                        AddEntryToList(e);
                    }
                }
            }
        }
        private void AddEntryToList(ZipEntry e)
        {
            DateTime date = e.DateTime;
            string[] jobname = e.Name.Split('/');
            jobname[1] = jobname[1].Remove(jobname[1].Length - 4, 4);
            this.JobList.Add(new string[3] { jobname[1], date.ToString("dd-MM-yy"), jobname[0] + ".zip" });
        }
        public void Find(string JobNumber)
        {
            string[] ZipFilesList = GetZipFilesList(this.Folder);
            foreach (string e in ZipFilesList)
            {
                    GetJobs(e, JobNumber);
            }
        }
        public string GetJob(string[] JobInfo, string tempfolder)
        {
            string basefile = this.Folder + @"\" + JobInfo[2];
            string jobname = JobInfo[0] + @".pdf";

            FastZip fastzipfile = new FastZip();
            fastzipfile.ExtractZip(basefile, tempfolder, jobname);

            ZipFile zipfile = new ZipFile(basefile);
            foreach (ZipEntry e in zipfile)
            {
                if (e.Name.Contains(jobname))
                {
                    return e.Name;
                }
            }
            return "null";
        }
    }
}
