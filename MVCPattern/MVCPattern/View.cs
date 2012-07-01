using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCPattern
{
    public partial class View : Form, IView
    {
        public Presenter presenter;
        public Model model;

        public View()
        {
            InitializeComponent();
            this.InitView();
        }

        private void InitView()
        {
            this.model = new Model();
            this.presenter = new Presenter(this, this.model);
            this.presenter.InitializePresenter();
        }

        private void DisplayModel(PresentationModel model)
        {
            this.textBox1.Text = model.Naam;
            this.textBox2.Text = model.LeeftijdInJaren;
        }

        public void UpgradeComplete(PresentationModel model)
        {
            DisplayModel(model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.model = new Model(textBox1.Text, Convert.ToInt16(textBox2.Text));
            this.presenter.UpdateLeeftijd(this.model);
        }

        public void PresenterInitializeComplete(PresentationModel model)
        {
            DisplayModel(model);
        }
    }
}