﻿using DataAccessLAyer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int LLPersonelEkle(EntityPersonel personel)
        {
            if (personel.Ad != "" && personel.Soyad != "" && personel.Maas >= 1500 && personel.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEkle(personel);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {

                return false;

            }
        }

        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            if (ent.Ad != "" && ent.Ad.Length >= 3 && ent.Maas >= 3000)
            {
                return DALPersonel.PersonelGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
