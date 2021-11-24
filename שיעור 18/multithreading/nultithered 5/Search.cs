using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nultithered_5
{
    internal class Search
    {
        public string Drive { get; set; }
        public string SearchTerm { get; set; }
        List<string> Extensions { get; set; } = new List<string>() { ".txt" };

        public Search(string drive, string searchTerm)
        {
            Drive = drive;
            SearchTerm = searchTerm;
        }

        public static event Action<string> Searchvalue;
        public void search()
        {
            Searchindir(@Drive + ":\\");
            var drive1 = Directory.GetDirectories(@Drive + ":\\");
            foreach (var dir in drive1)
            {
                Searchindir(dir);
            }
        }
        public void Searchindir(string dir)
        {
            var dir1 = new DirectoryInfo(dir);
            try
            {
                var result = dir1.GetFiles();
                string? line = string.Empty;
                foreach (var item in result)
                {
                    if (item.Name.Contains(Extensions[0]))
                    {
                        using (var reader = new StreamReader(item.FullName))
                        {
                            while (line != null)
                            {
                                line = reader.ReadLine();
                                if (line == null)
                                {

                                    var str = $"not found in {item.FullName}";
                                    Searchvalue(str);
                                    break;
                                }
                                if (line.Contains(SearchTerm)) { var str = $"found in {item.FullName}"; Searchvalue(str); break; }


                            }
                        }
                    }
                    else
                    {
                        var str = $"{item.FullName} is not txt file";
                        Searchvalue(str);
                    }
                }
            }
            catch
            {
                return;
            }
        }


    }
}

