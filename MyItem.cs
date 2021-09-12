using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangyaStatusSimulator
{
    class MyItem
    {
        string mname;
        string mID;
        int mdata01;
        int mdata02;
        int mdata03;
        int mdata04;
        int mdata05;

        public MyItem()
        {
        }
        public MyItem(string ID, string name, int data_01, int data_02, int data_03, int data_04, int data_05)
        {
            mID = ID;
            mname = name;
            mdata01 = data_01;
            mdata02 = data_02;
            mdata03 = data_03;
            mdata04 = data_04;
            mdata05 = data_05;
        }
        public string ID
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
        public int data_01
        {
            set
            {
                mdata01 = value;
            }
            get
            {
                return mdata01;
            }
        }
        public int data_02
        {
            set
            {
                mdata02 = value;
            }
            get
            {
                return mdata02;
            }
        }
        public int data_03
        {
            set
            {
                mdata03 = value;
            }
            get
            {
                return mdata03;
            }
        }
        public int data_04
        {
            set
            {
                mdata04 = value;
            }
            get
            {
                return mdata04;
            }
        }
        public int data_05
        {
            set
            {
                mdata05 = value;
            }
            get
            {
                return mdata05;
            }
        }
    }
}