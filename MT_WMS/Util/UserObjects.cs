using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    public class UserObjects
    {
        private string objectID;
        private string objectName;
        private string objectValue;
        private string valueDesc;
        [DataMember]
        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }

        [DataMember]
        public string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }

        [DataMember]
        public string ObjectValue
        {
            get { return objectValue; }
            set { objectValue = value; }
        }

        [DataMember]
        public string ValueDesc
        {
            get { return valueDesc; }
            set { valueDesc = value; }
        }
    }
}
