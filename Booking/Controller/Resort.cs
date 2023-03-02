using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using m = Booking.Model;

namespace Booking.Controller
{
    public class Resort
    {
        public List<m.Resort> GetResorts()
        {
            DatabaseHelper.Database db = new DatabaseHelper.Database();
            DataTable dt = db.GetResorts();
            return ConvertDTToList(dt);
        }

        public List<m.Resort> GetResort(int id)
        {
            DatabaseHelper.Database db = new DatabaseHelper.Database();
            DataTable dt = db.GetResort(id);
            return ConvertDTToList(dt);
        }

        public List<m.Resort> ConvertDTToList(DataTable dt)
        {
            List<m.Resort> resortsList = new List<m.Resort>();
            foreach (DataRow row in dt.Rows)
            {
                resortsList.Add(new m.Resort
                {
                    Id = Convert.ToInt16(row["id"]),
                    Name = row["name"].ToString(),
                    Description = row["description"].ToString(),
                    Photo = row["photo"].ToString(),
                    Price = Convert.ToDecimal(row["price"])
                });
            }
            return resortsList;
        }
    }
}