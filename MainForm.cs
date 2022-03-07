
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
            string date=this.dtpDate.Value.ToString("yyyy/MM/dd");   //發車時間

            string sql = $@"select ticket_id,ticketNo,runTime,startStation,endStation,price,ticketNum 
                from Ticket where runTime='{date}' ";
            this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);
        }
    }
}