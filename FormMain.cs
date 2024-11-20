using GetStartedWinForms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace TaskManager
{
    public partial class FormMain : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        private ProductsContext? dbContext;
        public FormMain()
        {
            InitializeComponent();
        }
        //база
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
        //база

        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;           //экземпл€р, который может пригодитьс€ при загрузке других форм
            f.Dock = DockStyle.Fill;      //вызываем метод loadform(new FormName());
            this.panelMain.Controls.Add(f); //в какой-нибудь кнопке
            this.panelMain.Tag = f;
            f.Show();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;
                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }
}
