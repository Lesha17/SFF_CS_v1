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
            files.Sort(compare_by_name);

            for (int i = 0; i < files.Count - 1; ++i)
            {
                string s = files[i].Name;
                List<string> l = new List<string>();
                while (i < files.Count && s == files[i].Name)
                {
                    l.Add(files[i++].FullName);
                }
                i--;
                if (l.Count > 1)
                {
                    ans.Add(s, l);
                }
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
    }
}
