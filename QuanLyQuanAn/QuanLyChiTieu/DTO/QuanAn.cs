using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class QuanAn
    {
        public QuanAn()
        {

        }
        public QuanAn(int id, string name, string timeOpen, string timeClose, string typeFood, string phoneContact, string address)
        {
            this.ID = id;
            this.name = name;
            this.timeOpen = timeOpen;
            this.timeClose = timeClose;
            this.typeFood = typeFood;
            this.phoneContact = phoneContact;
            this.address = address;
        }
        public QuanAn(string name, string timeOpen, string timeClose, string typeFood, string phoneContact, string address)
        {
            this.name = name;
            this.timeOpen = timeOpen;
            this.timeClose = timeClose;
            this.typeFood = typeFood;
            this.phoneContact = phoneContact;
            this.address = address;
        }

        public int ID { get; set; }
        public string name { get; set; }
        public string typeFood { get; set; }
        public string timeOpen { get; set; }
        public string timeClose { get; set; }
        public string phoneContact { get; set; }
        public string address { get; set; }


    }
}
