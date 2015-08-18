using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;

namespace Cha
{
    public class Data
    {
        // ==============================================================
        // org: public static void AddPhoto(int albumId, Photo photo)
        public static void AddPhoto(Photo photo)
        {
            using (SqlConnection conn = new SqlConnection(clsGVar.ConString1))
            {
                using (SqlCommand cmd = new SqlCommand("InsertPhoto", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
        //public int Loc { get; set; }                // 1
        //public int Grp { get; set; }                // 2
        //public int Co { get; set; }                 // 3
        //public int Year { get; set; }               // 4
        //public int Frm { get; set; }                // 5
        //public int DocType { get; set; }            // 6
        //public int DocID { get; set; }              // 7
        //public int Fiscal { get; set; }             // 8

                    // ------------------ Header Fields -----------------------------
                    // 1- Add the Loc parameter and set the value
                    cmd.Parameters.AddWithValue("@loc", photo.Loc);
                    // 2- Add the Group parameter and set the value
                    cmd.Parameters.AddWithValue("@grp", photo.Grp);
                    // 3- Add the Company parameter and set the value
                    cmd.Parameters.AddWithValue("@co", photo.Co);
                    // 4- Add the year parameter and set the value
                    cmd.Parameters.AddWithValue("@year", photo.Year);
                    // 5- Add the Form parameter and set the value
                    cmd.Parameters.AddWithValue("@frm", photo.Frm);
                    // 6- Add the Document/Voucher Type parameter and set the value
                    cmd.Parameters.AddWithValue("@doctype", photo.DocType);
                    // 7- Add the Document/Voucher ID/Number parameter and set the value
                    cmd.Parameters.AddWithValue("@docid", photo.DocID);
                    // 8- Add the Fiscal Period parameter and set the value
                    cmd.Parameters.AddWithValue("@fiscal", photo.Fiscal);
                    // ------------------ Data Fields -------------------------------
                    // 1- Add the Sequence Order parameter and set the value
                    cmd.Parameters.AddWithValue("@so", photo.SoID);
                    // 2- Add the Title parameter and set the value
                    cmd.Parameters.AddWithValue("@title", photo.Title);
                    // 3- Add the short title parameter and set the value
                    cmd.Parameters.AddWithValue("@st", photo.St);
                    // 4- Add the File Name parameter and set the value
                    cmd.Parameters.AddWithValue("@name", photo.Name);
                    // 5- Add the File Extension parameter and set the value
                    cmd.Parameters.AddWithValue("@ext", photo.Ext);
                    // 6- Add the File Length/Disk space used parameter and set the value
                    cmd.Parameters.AddWithValue("@length", photo.Length);
                    // 7- Add the image Thumbnail parameter and set the value
                    // CFTTB: cmd.Parameters.AddWithValue("@attach_thumbnail", photo.Thumbnail);
                    // 8- Add the image parameter and set the value
                    cmd.Parameters.AddWithValue("@_img", photo.Img);

                    // Add the return value parameter
                    //SqlParameter param = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                    //param.Direction = ParameterDirection.ReturnValue;

                    // Execute the insert
                    cmd.ExecuteNonQuery();

                    // Return value will be the index of the newly added photo
                    //photo.Id = (int)cmd.Parameters["RETURN_VALUE"].Value;
                }
            }
        }

    }
}
