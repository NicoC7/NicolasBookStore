using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NicolasBooks.DataAccess.Repository.IRepository
{
     public interface ISP_Call : IDisposable
    {
        //e.g.  first  row in the result set
        T Single<T>(string procedurename, DynamicParameters param = null);
        // execute  something to the database but not  retrive  anything
        void Execute(string procedurename, DynamicParameters param = null);
        //Retrieves the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        // Get all od the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        // Stored  proceedure that  returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);

    }
}
