using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=FirstProject;integrated security=true;");


	public long updateBalance(long upBal,long accNo)
    {
		string updateBal = "update AccountTB set Balance_Amount="+upBal+" where Account_No=" + accNo + "";
		SqlCommand cmd = new SqlCommand(updateBal, con);
		con.Open();
		int i = cmd.ExecuteNonQuery();
		long i1 = Convert.ToInt64(i);
		con.Close();
		return upBal;
	}

	public long getBalance(long accNo)
    {
		long Balance =0;
		string checkBal = "select Balance_Amount from AccountTB where Account_No=" + accNo + "";
		SqlCommand cmd = new SqlCommand(checkBal, con);
		con.Open();
		SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
			Balance = Convert.ToInt64(dr["Balance_Amount"]);
        }
		//int bal = Convert.ToInt32(Balance);
		con.Close();
		return Balance;

	}
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
