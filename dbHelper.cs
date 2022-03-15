using System.Data;
using System.Data.SqlClient;

public class dbHelper
{
    /*
      新增、修改、刪除 的通用方法 
      查詢(有很多種)
    */

    private static string connstr = "server=.;uid=eyan;pwd=edwardms0816;database=TicketSystemDB";


    /// <summary>
    /// 執行添加、刪除、修改的通用方法
    /// </summary>
    /// <param name="sql">sql腳本</param>
    /// <param name=""></param>
    /// <param name="paras">參數</param>
    /// <returns></returns>
    public static int ExecuteNonQuery(string sql,params SqlParameter[] paras)   //新增、修改、刪除
    {
        int result = -1;
        //創建連接對象
        using (SqlConnection conn = new SqlConnection(connstr))
        {
            conn.Open();   //連線資料庫  
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add(paras);   //添加參數
            result = command.ExecuteNonQuery();
        }

        return result;
    }

    /// <summary>
    /// 執行返回第一行第一列
    /// </summary>
    /// <param name="sql"></param>
    /// <param name=""></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql, params SqlParameter[] paras)   //查詢返回第一行第一列
    {
        object obj = null;
        //創建連接對象
        using (SqlConnection conn = new SqlConnection(connstr))
        {
            conn.Open();   //連線資料庫  
            SqlCommand command = new SqlCommand(sql, conn);    //創建腳本對象
            command.Parameters.AddRange(paras);   //添加參數
            obj = command.ExecuteScalar();
        }   //using內程式執行完資源便會被釋放

        return obj;
    }

    /// <summary>
    /// 執行返回多行多列
    /// </summary>
    /// <param name="sql"></param>
    /// <param name=""></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)   //查詢返回多行多列
    {
        //連接式連接方式，和資料庫保持連接
        SqlConnection conn = new SqlConnection(connstr);
        
        conn.Open();   //連線資料庫
        SqlCommand command = new SqlCommand(sql, conn);
        command.Parameters.AddRange(paras);   //添加參數
        SqlDataReader reader= command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //System.Data.CommandBehavior.CloseConnection->避免外部關閉SqlDataReader時，command無法關閉資料庫
        //SqlDataReader建立在資料庫連接打開下
        return reader;
    }

    /// <summary>
    /// 執行返回臨時表DataTable
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static DataTable GetDataTable(string sql,params SqlParameter[] paras)
    {
        DataTable dt = new DataTable();
        //斷開式連接方式，不需要寫conn.Open()因為會自動打開關閉資料庫，另外也不需要寫conn.Close()
        using (SqlConnection conn = new SqlConnection(connstr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(paras);   //添加參數
            SqlDataAdapter adapter = new(command);   //創建數據適配器
            adapter.Fill(dt); 
        }
        return dt; 
    }
}

