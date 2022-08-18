using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Bookstore
    {
        private int isbn;
        private string bname;
        private string bauthor;
        private string btitle;
        private int bquant;
        public static int total = 0;
        private int bprice;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Bname
        {
            get { return bname; }
            set { bname = value; }
        }
        public string Bauthor
        {
            get { return bauthor; }
            set { bauthor = value; }

        }
        public string Btitle
        {
            get { return btitle; }
            set { btitle = value; }
        }

       
        public int Bquant
        {
            get { return bquant; }
            set
            {
                bquant = value;
                


            }
        }
        public int Bprice
        {
            get { return bprice; }
            set
            {
                bprice = value;
                total = total + (bprice * Bquant);
            }
        }





        public Bookstore(int isbn, string bname, string bauthor, int bquant, int bprice, string btitle)
        {
            this.Isbn = isbn;
            this.Bname = bname;
            this.Bauthor = bauthor;
            this.Bquant = bquant;
            this.Bprice = bprice;
            this.Btitle = btitle;
        }

        public void show()
        {
            Console.WriteLine("Isbn :" + Isbn);
            Console.WriteLine("Author name: " + Bauthor);
            Console.WriteLine("Book name: " + Bname);
            Console.WriteLine("Book price: " + bprice);
            Console.WriteLine("Book title: " +Btitle);
            Console.WriteLine("total price: "+total);
        }
    }
     


  }

