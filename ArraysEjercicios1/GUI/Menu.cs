using ArraysEjercicios1.GUI;

namespace ArraysEjercicios1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector crearVector = new Vector();
            crearVector.ShowDialog();
        }
    }
}