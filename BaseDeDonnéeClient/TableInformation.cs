using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonnéeClient
{
   public class TableInformation
    {
        private List<Type> ColumnsType = new List<Type>();
        private List<String> ColumnsName = new List<string>();
        private String TableName;

        public TableInformation(String tableName)
        {
            this.TableName = tableName;
        }

        public void AddType(Type type)
        {
            this.ColumnsType.Add(type);
        }

        public void AddColumnName(string name)
        {
            this.ColumnsName.Add(name);
        }

        public int GetCountName()
        {
            return ColumnsName.Count;
        }

        public int GetCountType()
        {
            return ColumnsType.Count;
        }

       public String GetColumnName(int i)
        {
            return ColumnsName[i];
        }
    }
}
