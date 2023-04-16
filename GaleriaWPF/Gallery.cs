using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaWPF
{
    public class Gallery
    {
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public string SubCat { get; set; }
        public string SubCatUrl { get; set; }
        public ObservableCollection<Photo> Photos { get; set; }
    }
}
