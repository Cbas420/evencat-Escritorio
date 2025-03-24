using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evencat
{
    public partial class formSpacesManagement : Form
    {
        public formSpacesManagement()
        {
            InitializeComponent();

            // Verificar si las fuentes están cargadas
            if (FontManager.FontCollection.Families.Length == 0)
            {
                MessageBox.Show("Las fuentes no se han cargado correctamente.");
            }





        }

        private void formSpacesManagement_Load(object sender, EventArgs e)
        {
            FormSelectOption formSelectOption = new FormSelectOption();

            textBoxSpaceName.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            float titleFontSize = labelSpacesManagement.Font.Size;


            labelSpacesManagement.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);


            float spaceNameSize = textBoxSpaceName.Font.Size;


            labelSpacesManagement.Left = (Width - labelSpacesManagement.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxSpaceName, 35, "Space name");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateActivity, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateSpace, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxCurrentState, 10, "Current state");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            dataGridViewSpaces.Left = (panelDataGridView.Width - dataGridViewSpaces.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;

            textBoxSpaceName.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);

            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);

            formSelectOption.Show();

        }

        private void textSpaceName_Leave(object sender, EventArgs e)
        {
            // Deseleccionar el texto
            textBoxSpaceName.SelectionLength = 0;
        }

        private void buttonCreateActivity_Click(object sender, EventArgs e)
        {
            FormUsersManagement formUsersManagement = new FormUsersManagement();

            formUsersManagement.Show();
        }
    }
}
