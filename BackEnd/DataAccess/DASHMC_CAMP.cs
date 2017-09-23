using BusinessEntities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DASHMC_CAMP
    {
        private DAGenerics oDg;
        private Database oDb;
        private DbConnection oCon;

        /// <summary>
        /// CONTRUCTOR DE LA CLASE
        /// </summary>
        public DASHMC_CAMP()
        {
            oDg = new DAGenerics("manager");
        }
        /// <summary>
        /// OBTENER LA LISTA DE CAMPAÑAS
        /// </summary>
        /// <param name="oBe"></param>
        /// <returns></returns>
        public IDataReader P0010SHPR_CAMP_LIST(BESHMC_CAMP oBe)
        {
            try
            {
                oDb = oDg.getDataBase();
                oCon = oDg.getConnection();
                if (oCon.State == ConnectionState.Closed) oCon.Open();
                var ocmd = oDb.GetStoredProcCommand("P0010SHPR_CAMP_LIST", oBe.NUM_ACCI);

                ocmd.CommandTimeout = 2000;
                var odr = oDb.ExecuteReader(ocmd);
                return (odr);
            }
            finally
            {
                oCon.Close();
            }
        }
    }
}
