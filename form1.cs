  ﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<NewCarClass> NewCar = new List<NewCarClass>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        List<NewCarClass> CarList = new List<NewCarClass>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewCar CarNew = new FrmNewCar();
            DialogResult result = CarNew.ShowDialog();

            // listide cixarmaq lazimdir yuxari.
            // listi yuxari cixarmaqda meqsed odur ki, her defe bu buttona basanda list yeniden yaranmasin.
            // yeniden yaranda. 0 lanir. yuxarda yaradanda. 0 lanmir. bir defe yaranib. uje qalani onun ustune gelir. vessalam. isim var. helelik.
            dgTunedCars.DataSource = null;
            if (result == DialogResult.OK)
            {
                //burda yaziram ki. her defe yeni masin elave edilende. 
                // newcarclasin doldurmusan axi o terefde. hemin o melumatlari liste elave et.
                // suallara cavab ver
                //1. o melumatlari hansi formda doldurursan? NewCAr
                //2 o NewCar formunu hansi Formdan show etmisen?esas formdan hardasiz? esas form hansi formdu?form1 hani form1 ?
                // indi icinde yazisdigimiz ? duzdu?beli.
                // FrmNewCar CarNew = new FrmNewCar(); bu qaydada o formu ele almisan. sonra show elemisen. 
                // bu o demekdir ki o formun butun ozelliklerin ve o cumleden orada olan deyisenleride oxuya bilersen.
                // indi oxu gorum
                //meselen bele? meselen yox. Bele! basa dfusdun?aha. okey. indi bu listi doldur.
                CarList.Add(new NewCarClass {
                    CarMark = CarNew.NewCar.CarMark, // vergul ile ayirmaq lazimdir. ok.
                    CarModel = "Amg",
                    CarPlate = "54JG899"
                 // ok ?ok birce yoxluyaq
                    // list dolur. ama listi gride vermek lazimdir. kitabxanada var. baxaq.
                });
                // ikinci dusmur? cunki gridi her defe 0 lamaq lazimdir. 
               
                dgTunedCars.DataSource = CarList;
            }
        
        }
    }
}
