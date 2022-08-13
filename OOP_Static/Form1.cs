using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
     * STATIC CLASS
     * Eger nesneye bagimli islemler gerceklestirmiyorsaniz - yani amac sadece belirli bir duruma hizmet eden birden fazla ogeyi bir araya toplamak ise - ilgili sınıfı static olarak isaretleyebilir ve icerisindeki tum ogelere instance'dan bagimsiz olarak ulasabilirsiniz...
     *
     * Static sınıflar icerisinde yalnizca static ogeler barinabilir (field, property, method...)
     *
     * Static bir class baska bir classtan kalitim alamaz! Ancak .NET Framework mantigi geregi, tum sınıflar System.Object sınıfından kalitim alirlar. Static sınıflar da bu kalitim islemine dahildir...
     *
     * Static sınıflara en guzel iki ornek Math ve File sınıflaridir. Ayni amaca (Math => Matematiksel islemlerin bir arada tutulmasi; File => Dosya bazli islemler gerceklestiren birden fazla islemin bir arada tutulmasi) hizmet eden ogeleri icerisinde barindiran ve hizlica ulasmamizi saglayan siniflardir.
     *
     * Ancak her sinif static olarak isaretlenmemelidir. Cunku tanimlamis oldugunuz her static sinif size ufak da olsa performans kaybi olarak donecektir...
     */

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = PyhsicsLibrary.ReadOnly;

            PyhsicsLibrary.Kaldir();
        }
    }
}
