using BusinessEntities;
using DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultSetMappers;

namespace BussinessRules
{
    public class BRSHMC_CAMP
    {
        private DASHMC_CAMP oDa;

        public BRSHMC_CAMP()
        {
            oDa = new DASHMC_CAMP();
        }
        /// <summary>
        /// OBTENER LA LISTA DE CAMPAÑAS
        /// </summary>
        /// <param name="oBe"></param>
        /// <returns></returns>
        public List<BESHMC_CAMP> P0010SHPR_CAMP_LIST(BESHMC_CAMP oBe)
        {
            using (var odr = oDa.P0010SHPR_CAMP_LIST(oBe))
            {
                var oList = new List<BESHMC_CAMP>();
                ((IList)oList).LoadFromReader<BESHMC_CAMP>(odr);
                return (oList);
            }
        }
    }
}
