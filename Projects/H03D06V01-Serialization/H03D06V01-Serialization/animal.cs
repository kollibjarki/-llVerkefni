using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace H03D06V02_SeralizeClass
{
    [Serializable]
    class Animal : IDeserializationCallback
    {

        public int age { get; set; }
        public string name { get; set; }
        [NonSerialized]
        public int ageInDogYears;
        void IDeserializationCallback.OnDeserialization(object sender)
        {
            ageInDogYears = age * 7;
        }

    }
}
