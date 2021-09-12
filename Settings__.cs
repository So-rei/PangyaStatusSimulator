using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangyaStatusSimulator
{
    /*
    class Settings
    {
        //セーブデータをデータセットで作れないか？
        int[] mset = new int[39];
        string msavename;
        int mID;
        
        public Settings()
        {
            //int[] set = new int[38];
        }
        public Settings( int set1 , int set2 , int set3 , int set4 , int set5 , int set6 , int set7 , int set8 , int set9 , int set10,
                         int set11, int set12, int set13, int set14, int set15, int set16, int set17, int set18, int set19, int set20,
                         int set21, int set22, int set23, int set24, int set25, int set26, int set27, int set28, int set29, int set30,
                         int set31, int set32, int set33, int set34, int set35, int set36, int set37, int set38, string savename, int ID)
        {
            mset[1] = set1;
            mset[2] = set2;
            mset[3] = set3;
            mset[4] = set4;
            mset[5] = set5;
            mset[6] = set6;
            mset[7] = set7;
            mset[8] = set8;
            mset[9] = set9;
            mset[10] = set10;
            mset[11] = set11;
            mset[12] = set12;
            mset[13] = set13;
            mset[14] = set14;
            mset[15] = set15;
            mset[16] = set16;
            mset[17] = set17;
            mset[18] = set18;
            mset[19] = set19;
            mset[20] = set20;
            mset[21] = set21;
            mset[22] = set22;
            mset[23] = set23;
            mset[24] = set24;
            mset[25] = set25;
            mset[26] = set26;
            mset[27] = set27;
            mset[28] = set28;
            mset[29] = set29;
            mset[30] = set30;
            mset[31] = set31;
            mset[32] = set32;
            mset[33] = set33;
            mset[34] = set34;
            mset[35] = set35;
            mset[36] = set36;
            mset[37] = set37;
            mset[38] = set38;
            //これをforloopで作れないのか？
            msavename = savename;
            mID = ID;
        }
        #region＜public int set＞
        public int set1
        {
            set
            {
                mset[1] = value;
            }
            get
            {
                return mset[1];
            }
        }
        public int set2
        {
            set
            {
                mset[2] = value;
            }
            get
            {
                return mset[2];
            }
        }
        public int set3
        {
            set
            {
                mset[3] = value;
            }
            get
            {
                return mset[3];
            }
        }
        public int set4
        {
            set
            {
                mset[4] = value;
            }
            get
            {
                return mset[4];
            }
        }
        public int set5
        {
            set
            {
                mset[5] = value;
            }
            get
            {
                return mset[5];
            }
        }
        public int set6
        {
            set
            {
                mset[6] = value;
            }
            get
            {
                return mset[6];
            }
        }
        public int set7
        {
            set
            {
                mset[7] = value;
            }
            get
            {
                return mset[7];
            }
        }
        public int set8
        {
            set
            {
                mset[8] = value;
            }
            get
            {
                return mset[8];
            }
        }
        public int set9
        {
            set
            {
                mset[9] = value;
            }
            get
            {
                return mset[9];
            }
        }
        public int set10
        {
            set
            {
                mset[10] = value;
            }
            get
            {
                return mset[10];
            }
        }
        public int set11
        {
            set
            {
                mset[11] = value;
            }
            get
            {
                return mset[11];
            }
        }
        public int set12
        {
            set
            {
                mset[12] = value;
            }
            get
            {
                return mset[12];
            }
        }
        public int set13
        {
            set
            {
                mset[13] = value;
            }
            get
            {
                return mset[13];
            }
        }
        public int set14
        {
            set
            {
                mset[14] = value;
            }
            get
            {
                return mset[14];
            }
        }
        public int set15
        {
            set
            {
                mset[15] = value;
            }
            get
            {
                return mset[15];
            }
        }
        public int set16
        {
            set
            {
                mset[16] = value;
            }
            get
            {
                return mset[16];
            }
        }
        public int set17
        {
            set
            {
                mset[17] = value;
            }
            get
            {
                return mset[17];
            }
        }
        public int set18
        {
            set
            {
                mset[18] = value;
            }
            get
            {
                return mset[18];
            }
        }
        public int set19
        {
            set
            {
                mset[19] = value;
            }
            get
            {
                return mset[19];
            }
        }
        public int set20
        {
            set
            {
                mset[20] = value;
            }
            get
            {
                return mset[20];
            }
        }
        public int set21
        {
            set
            {
                mset[21] = value;
            }
            get
            {
                return mset[21];
            }
        }
        public int set22
        {
            set
            {
                mset[22] = value;
            }
            get
            {
                return mset[22];
            }
        }
        public int set23
        {
            set
            {
                mset[23] = value;
            }
            get
            {
                return mset[23];
            }
        }
        public int set24
        {
            set
            {
                mset[24] = value;
            }
            get
            {
                return mset[24];
            }
        }
        public int set25
        {
            set
            {
                mset[25] = value;
            }
            get
            {
                return mset[25];
            }
        }
        public int set26
        {
            set
            {
                mset[26] = value;
            }
            get
            {
                return mset[26];
            }
        }
        public int set27
        {
            set
            {
                mset[27] = value;
            }
            get
            {
                return mset[27];
            }
        }
        public int set28
        {
            set
            {
                mset[28] = value;
            }
            get
            {
                return mset[28];
            }
        }
        public int set29
        {
            set
            {
                mset[29] = value;
            }
            get
            {
                return mset[29];
            }
        }
        public int set30
        {
            set
            {
                mset[30] = value;
            }
            get
            {
                return mset[30];
            }
        }
        public int set31
        {
            set
            {
                mset[31] = value;
            }
            get
            {
                return mset[31];
            }
        }
        public int set32
        {
            set
            {
                mset[32] = value;
            }
            get
            {
                return mset[32];
            }
        }
        public int set33
        {
            set
            {
                mset[33] = value;
            }
            get
            {
                return mset[33];
            }
        }
        public int set34
        {
            set
            {
                mset[34] = value;
            }
            get
            {
                return mset[34];
            }
        }
        public int set35
        {
            set
            {
                mset[35] = value;
            }
            get
            {
                return mset[35];
            }
        }
        public int set36
        {
            set
            {
                mset[36] = value;
            }
            get
            {
                return mset[36];
            }
        }
        public int set37
        {
            set
            {
                mset[37] = value;
            }
            get
            {
                return mset[37];
            }
        }
        public int set38
        {
            set
            {
                mset[38] = value;
            }
            get
            {
                return mset[38];
            }
        }
        #endregion
        public string savename
        {
            set
            {
                msavename = value;
            }
            get
            {
                return msavename;
            }
        }
        public int ID
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

    }*/
}
