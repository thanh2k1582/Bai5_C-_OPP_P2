using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QLKS
    {
        private List<Nguoi> ListKhachThue = null;
        public QLKS()
        {
            ListKhachThue = new List<Nguoi>();
        }
        public void NhapKs()
        {
            KhachSan ks = new KhachSan();
            Console.Write("Nhap thong tin khach hang thue phong: \n");
            Console.Write("Nhap ten: ");
            ks.Ten = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi: ");
            ks.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so CMND: ");
            ks.SoCMND = Convert.ToString(Console.ReadLine());

            ListKhachThue.Add(ks);
        }

        public void XuatKS(List<Nguoi> listKT)
        {
            foreach (Nguoi nguoi in listKT)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Thong tin khach thue");
                Console.WriteLine("Ten: {0}", nguoi.Ten);
                Console.WriteLine("Tuoi: {0}", nguoi.Tuoi);
                Console.WriteLine("So CMND: {0}", nguoi.SoCMND);
            }
            Console.WriteLine();
        }

        //find SoCMND
        public Nguoi FindBySoCMND(string ID)
        {
            Nguoi searchResult = null;
            foreach (Nguoi Sach in ListKhachThue)
            {
                if (Sach.SoCMND == ID)
                {
                    searchResult = Sach;
                }
            }
            return searchResult;
        }
        //delete
        public bool DeleteBySoCMND(string ID)
        {
            bool IsDeleted = false;
            Nguoi nguoi = FindBySoCMND(ID);
            if (nguoi != null)
            {
                IsDeleted = ListKhachThue.Remove(nguoi);
            }
            return IsDeleted;
        }

        public List<Nguoi> timKiemKH(String keyword)
        {
            List<Nguoi> searchResult = new List<Nguoi>();
            foreach (Nguoi nguoi in ListKhachThue)
            {
                if (nguoi.SoCMND.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(nguoi);
                }
            }
            return searchResult;
        }

        public List<Nguoi> getListKhachThue()
        {
            return ListKhachThue;
        }
    }
}
