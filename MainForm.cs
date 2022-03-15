using System.Data.SqlClient;
using System.Data;
namespace TicketSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //獲取用戶輸入條件
            string start=this.cboStart.Text;   //出發站
            string end = this.cboEnd.Text;   //目的地
            string date=this.dtpDate.Text;   //發車時間

            //select convert(varchar,runTime,111) from Ticket;   格式化日期
            string sql = @"select ticket_id,ticketNo,runTime,startStation,endStation,price,ticketNum from Ticket
                where convert(datetime,runTime,111)=convert(varchar,@date,111)";
            //this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);

            //查詢出發地、目的地
            sql += start != "" ? "and startStation=@startStation" : " ";
            sql += end != "" ? "and endStation=@endStation" : " ";

            SqlParameter[] paras = {
                new SqlParameter("@date",Convert.ToDateTime(date)),    //把字符串轉成日期
                new SqlParameter("@startStation",start),
                new SqlParameter("@endStation",end)
            };

            this.dgvTicket.DataSource=dbHelper.GetDataTable(sql,paras);
        }
    }
}