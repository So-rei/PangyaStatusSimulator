using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangyaStatusSimulator
{
    class MyItem_clubrank
    {
        string mname;
        int mID;

        public MyItem_clubrank()
        {
        }
        public MyItem_clubrank(int IDc, string name)
        {
            mID = IDc;
            mname = name;
        }
        public int IDc
        {
            set
            {
                mID = value;
            }
            get
            {
                return mID;
            }
        }
        public string name
        {
            set
            {
                mname = value;
            }
            get
            {
                return mname;
            }
        }
    }
}