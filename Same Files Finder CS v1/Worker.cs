using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Same_Files_Finder_CS_v1
{
    class Worker
    {
        public delegate void Update(String current);
        public delegate void Finished(Dictionary<string, List<string>> d);

        string dir;
        Thread rt;
        List<FileInfo> files;
        Dictionary<string, List<string>> ans;
        public event Update update;
        public event Finished finished;

        public Worker(String dir)
        {
            this.dir = dir;
            files = new List<FileInfo>();
            ans = new Dictionary<string, List<string>>();
            rt = new Thread(work);
        }

        public void start()
        {
            rt.Start();
        }

        private void work()
        {
            in_dir(new DirectoryInfo(dir));
            files.Sort(compare);
            string s = "";
            Int64 size = 0;
            List<string> l = new List<string>();
            foreach (FileInfo f in files)
            {
                if (size == f.Length && s == f.Name)
                {
                    l.Add(f.FullName);
                    continue;
                }
                    
                if(l.Count > 1)
                {
                    ans.Add(s + ":" + size, l);
                }
                l = new List<string>();
                l.Add(f.FullName);
                size = f.Length;
                s = f.Name;
            }
            finished(ans);
        }
        void in_dir(DirectoryInfo d)
        {
            update(d.FullName);
            foreach(FileInfo f in d.GetFiles())
            {
                files.Add(f);
            }
            foreach(DirectoryInfo di in d.GetDirectories())
            {
                if(di != d.Parent)
                    in_dir(di);
            }
        }

        int compare_by_name(FileInfo f1, FileInfo f2)
        {
            return f1.Name.CompareTo(f2.Name);
        }

        int compare_by_size(FileInfo f1, FileInfo f2)
        {
            return (int)(f1.Length - f2.Length);
        }

        int compare(FileInfo f1, FileInfo f2)
        {
            int rv = compare_by_size(f1, f2);
            if (rv != 0)
                return rv;
            return compare_by_name(f1, f2);
        }
    }
}
