using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NguoiDungWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INguoiDungBLL" in both code and config file together.
    [ServiceContract]
    public interface INguoiDungBLL
    {
        [OperationContract]
        DataSet layDuLieu();
    }
}
