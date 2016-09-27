using Pantanir.PantanirDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantanir
{
    class PantanirRepository
    {
        public PantanirDataSet.PantanirDataTable GetAllPantanir()
        {
            PantanirTableAdapter pta = new PantanirTableAdapter();
            return pta.GetData();
        }

        public int AddPontun(string vvNafn, string vvKt, DateTime afhD, string afhm)
        {
            PantanirTableAdapter pta = new PantanirTableAdapter();
            return pta.Insert(vvNafn, vvKt, afhD, afhm);
        }

        public PantanirDataSet.PontunarLinurDataTable GetAllVorulinur()
        {
            PontunarLinurTableAdapter plta = new PontunarLinurTableAdapter();
            return plta.GetData();
        }

        public PantanirDataSet.PontunarLinurDataTable GetAllVorulinurForPontun(int id)
        {

            return GetAllVorulinur();
        }

        public int AddVorulina(string voruheiti, float verd, float fjoldi, int pontunId)
        {
            PontunarLinurTableAdapter pvlta = new PontunarLinurTableAdapter();
            return pvlta.Insert(voruheiti, verd, fjoldi, pontunId);
        }
    }
}
