using System;
using System.Windows.Forms;

namespace AutoService
{

    public partial class FrmNewCar : Form
    {
        public NewCarClass NewCar = new NewCarClass();

        public FrmNewCar()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            // ook ? elivi klaviaturaya vurma. 
            // sen burda Caryear propertysine int vermisen. ama txtYear textboxunun
            // deyeri stringdir. demeli sen txtYear textobxundan gelen deyeri int e convert etmelisen.
            try
            {
                NewCar.OwnerName = txtName.Text;
                NewCar.SurName = txtSurname.Text;
                NewCar.CarYear = Convert.ToInt32(txtYear.Text);
                NewCar.CarMark = txtCarMark.Text;
                NewCar.CarPlate = txtPlate.Text;
                NewCar.Mail = txtEmail.Text;
                NewCar.ContactNumber = Convert.ToInt32(txtNumber.Text);
                NewCar.CarModel = txtCarModel.Text;
                

                DialogResult result = MessageBox.Show("Eminsiz?", "Xeberdarliq", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                // bu resultlari qarisdirma.

                // bu result (bu yazinin ustundeki) mesaj boxdan gelen cavabi alir. ok basilib ya cancel. ok ?ok
                
                // burda ok aliriq duzdu?beli. niye ora cancel gedir. ?form baglanir deye?. yox ora bildirmey lazimdir ki bura okdi.

                //nece bildirirdiy ?bilmirme. bilirsen.
                //bele
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK; // yeni bu formun cavabi okdur. 
                    this.Close();
                }
                // ne etdin ki alinmadi?hecne
                // axra kimi doldurmayanda oshibka verir.
                //cunki bosh gelen bir texti convert edirsen int'e o erorru verecek. bax o erroru yadunda saxla.
                // ne vaxt hemin erroru ( sozu)  gorsen bil ki bosh yazini covnert edirsen inte.baxaq....
            }

            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }

        }
    }
}
