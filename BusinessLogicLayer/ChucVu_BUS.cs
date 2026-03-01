using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayChucVu()
        {
            return ChucVu_DAO.LayChucVu();
        }
    }
}
