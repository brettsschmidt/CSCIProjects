using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI234_Project_Schmidt
{
    public class Exercise
    {
        public int ExerID { get; set; }
        public string ExerName { get; set; }
        public string ExerVideo { get; set; }
        public string ExerDesc { get; set; }
        public string ExerCat { get; set; }
        public int AddUserID { get; set; }
        public string AddDTM { get; set; }
        public int ChgUserID { get; set; }
        public string ChgDTM { get; set; }
        public string Photo { get; set; }
        public string ExerStatCD { get; set; }

        public Exercise()
        {

        }
        STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT001_EXER_MASTERTableAdapter ExerInfo = new STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT001_EXER_MASTERTableAdapter();

        public Exercise(int exerID)
        {


            
            
            try
            {
                

                ExerID = ExerInfo.getByID(exerID)[0].EXER_ID;
                ExerName = (string)ExerInfo.getByID(exerID)[0].EXER_NAME_AK1;


                if(!ExerInfo.getByID(exerID)[0].IsEXER_VIDEO_AK2Null())
                ExerVideo = (string)ExerInfo.getByID(exerID)[0].EXER_VIDEO_AK2;

                if(!ExerInfo.getByID(exerID)[0].IsEXER_DESCNull())
                ExerDesc = (string)ExerInfo.getByID(exerID)[0].EXER_DESC;

                ExerCat = (string)ExerInfo.getByID(exerID)[0].EXER_CAT_CD;

                if(!ExerInfo.getByID(exerID)[0].IsEXER_ADD_USER_IDNull())
                AddUserID = ExerInfo.getByID(exerID)[0].EXER_ADD_USER_ID;
                AddDTM = (string)ExerInfo.getByID(exerID)[0].EXER_ADD_DTM.ToString();
                if(!ExerInfo.getByID(exerID)[0].IsEXER_CHG_USER_IDNull())
                ChgUserID = ExerInfo.getByID(exerID)[0].EXER_CHG_USER_ID;


                if(!ExerInfo.getByID(exerID)[0].IsEXER_CHG_DTMNull())
                ChgDTM = (string)ExerInfo.getByID(exerID)[0].EXER_CHG_DTM.ToString();

                if (!ExerInfo.getByID(exerID)[0].IsEXER_PHOTONull())
                Photo = (string)ExerInfo.getByID(exerID)[0].EXER_PHOTO;
                ExerStatCD = (string)ExerInfo.getByID(exerID)[0].EXER_STAT_CD;

            }
            catch(Exception E)
            {
                throw new FileLoadException( );
            }
        }

        public void updateExercise()
        {
            try
            {
                ExerInfo.UpdateQuery(ExerName, ExerVideo, ExerDesc, ExerCat, 4, ExerID);
            }
            catch(Exception E)
            {
                throw new ArgumentException();
            }


        }

        public void Purge()
        {
            if(ExerStatCD != "A")
            {
                ExerInfo.PurgeQuery(ExerID);
            }
        }

        public void Delete()
        {
            if (ExerStatCD == "A")
            {
                ExerInfo.DeleteQuery(ExerID);
            }
            else
            {
                ExerInfo.UndeleteQuery(ExerID);
            }
        }

        public void insertExercise()
        {
            try
            {
                ExerInfo.InsertQuery(ExerName, ExerVideo, ExerDesc, ExerCat, 4, 4);
            }
            catch(Exception E)
            {
                throw new ArgumentException();
            }
        }




    }
}
