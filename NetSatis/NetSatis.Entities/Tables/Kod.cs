using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Kod:IEntity
    {
        public int Id { get; set; }
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }
    }
}
