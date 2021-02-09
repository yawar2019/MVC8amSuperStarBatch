using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true;");

        public List<EmployeeModel> GetEmployee() {

            List<EmployeeModel> listemp = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("sp_getRituEmployees",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)//2 ritu and vinod
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listemp.Add(emp);
            }
            return listemp;
        }

        public int SaveEmployee(string EmpName,int EmpSalary)
        {
            SqlCommand cmd = new SqlCommand("sp_insertRituEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

    }
}