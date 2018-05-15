using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml.XPath;
using System.IO;
using System.Globalization;

using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace $safeprojectname$
{
  
    public partial class Form1 : Form
    {
        typ_zaswiadczenie_szczepienia zasw; //Object containing data from XML "zaswiadczenie.xml"
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(typ_zaswiadczenie_szczepienia)); //construction of object for XML (de)serialization
        static bool XMLValid = true;
        String wybranaData;
        String wybranaData2;
        public Form1()
        {
            InitializeComponent();
        }


        private void XML_LOAD_BUTTON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xml file|*.xml";
            openFileDialog1.Title = "Wskaż plik XML";
            var name_xml="nazwa";
          if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                    name_xml = openFileDialog1.FileName;
                    sr.Close();
                }  
            try
            {
                 
                    using (StreamReader reader = new StreamReader(name_xml))
                    {
                        zasw = (typ_zaswiadczenie_szczepienia)xmlSerializer.Deserialize(reader);
                    }
                
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Nie znaleziono pliku XML ", "Błąd",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            textBox1.Text = zasw.wlasciciel_psa.imie + " " + zasw.wlasciciel_psa.nazwisko;
            textBox2.Text = zasw.wlasciciel_psa.adres.miejscowosc;
            textBox3.Text = zasw.wlasciciel_psa.adres.ulica;
            numericUpDown1.Value = Int32.Parse(zasw.wlasciciel_psa.adres.nr_domu);
            textBox5.Text = zasw.wlasciciel_psa.adres.gmina;
            textBox6.Text = zasw.wlasciciel_psa.adres.powiat;

            textBox7.Text = zasw.opis_psa.nazwa_psa;
            textBox8.Text = zasw.opis_psa.rasa;
            numericUpDown2.Value = Int32.Parse(zasw.opis_psa.wiek_psa);
            textBox11.Text = zasw.opis_psa.masc;
            textBox12.Text = zasw.opis_psa.znaki_szczegolne;

            textBox9.Text = zasw.zaswiadczenie.nr_zaswiadczenia;
            textBox10.Text = zasw.zaswiadczenie.miejscowosc_podpis;
            textBox14.Text = zasw.zaswiadczenie.lekarz_wystawiajacy.tytul_naukowy;
            textBox15.Text = zasw.zaswiadczenie.lekarz_wystawiajacy.imie_lek;
            textBox16.Text = zasw.zaswiadczenie.lekarz_wystawiajacy.nazwisko_lek;
            textBox13.Text = zasw.zaswiadczenie.data_wystawienia.ToString("d");
            label25.Text = zasw.zaswiadczenie.lekarz_wystawiajacy.tytul_naukowy + " " + zasw.zaswiadczenie.lekarz_wystawiajacy.imie_lek + " " + zasw.zaswiadczenie.lekarz_wystawiajacy.nazwisko_lek;
            

            if(zasw.opis_psa.plec=="samiec")
            {
                radioButton1.PerformClick();
            }
            else radioButton2.PerformClick();
            
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(zasw.informacja_weterynaryjna.Length);//odrered goods 
           for (int i = 0; i < zasw.informacja_weterynaryjna.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = zasw.informacja_weterynaryjna[i].data_szczepienia.ToString("d");
                dataGridView1.Rows[i].Cells[1].Value = zasw.informacja_weterynaryjna[i].nazwa_szczep;
                dataGridView1.Rows[i].Cells[2].Value = zasw.informacja_weterynaryjna[i].nr_serii;
                dataGridView1.Rows[i].Cells[3].Value = zasw.informacja_weterynaryjna[i].data_ważn.ToString("d");
                dataGridView1.Rows[i].Cells[4].Value = zasw.informacja_weterynaryjna[i].termin_n_szczepienia.ToString("d");
            }
         
        }
        //Callback function for serving the events of incorrect validation
        static void ValidationEventCallback(object sender, ValidationEventArgs e)
        {
            string msg;
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    MessageBox.Show(e.Message, "Validation Error", MessageBoxButtons.OK);
                    msg = "Walidacja nie przebiegła pomyślnie: Błąd\n" + e.Message;
                    Console.Write(e.Message);
                    MessageBox.Show(msg, "Walidacja: Błąd", MessageBoxButtons.OK);
                    XMLValid = false;
                    break;
                case XmlSeverityType.Warning:
                    MessageBox.Show(e.Message, "Validation Warning", MessageBoxButtons.OK);
                    msg = "Walidacja nie przebiegła pomyślnie: Ostrzeżenie\n" + e.Message;
                    MessageBox.Show(msg, "Walidacja: Ostrzeżenie", MessageBoxButtons.OK);
                    XMLValid = false;
                    break;
            }

        }

        private void VALIDE_SAVE_BUTTON_Click(object sender, EventArgs e)
        {
            updateSzczepienia();
            MemoryStream ms = new MemoryStream(); //creating a stream for storing XML file with modified data
            
            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = ("\t");

            XmlWriter writer = XmlWriter.Create(ms,writerSettings); //creating writer for writing XML file to stream
            xmlSerializer.Serialize(writer, zasw);
           

            
            XmlReaderSettings xrset = new XmlReaderSettings(); //definition of XML reader settings
            xrset.ValidationType = ValidationType.Schema; //validation based on XML Schema
            ms.Position = 0; //setting the pointer on beginning of memory stream
            XmlReader reader = XmlReader.Create(ms, xrset); //creating a reader for reading XML from memory stream

            XmlDocument xdoc = new XmlDocument(); //creating an XML document
            xdoc.Load(reader); //loading document from memory stream
            xdoc.Schemas.Add(null, @"SCHEMA_OFFICIAL.xsd"); //connecting the XML document with schema from "zamowienie.xsd"
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventCallback); //setting the event handler for handling incorrect validation events
            XMLValid = true; //setting the default value of XML validity flag for true
            xdoc.Validate(eventHandler); //performing validation

            //Writing the memory stream to a file "zamowienie_mod.xml" if the document is valid
            if (XMLValid)
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                
             
                
                saveFileDialog1.Filter = "XML FILE (*.xml)|*.xml";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                var save_xml="nazwa";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        // Code to write the stream goes here.
                        save_xml = saveFileDialog1.FileName;
                        myStream.Close();
                       var msg = "Zapisano pomyślnie : "+save_xml;
                        MessageBox.Show(msg, "Zapis", MessageBoxButtons.OK);
                    }
                }
              
                FileStream fs = new FileStream(save_xml, FileMode.Create);
                ms.Position = 0;
                ms.CopyTo(fs);
                fs.Close();
                //toolStripStatusLabel2.Text = "XML valid - marshalling to \"zamowienie_mod.xml\" file";
             //   toolStripStatusLabel2.Text = "Walidacja XML pomyślna - dane zapisano do pliku \"zamowienie_mod.xml\"";
            }
            else
            {
                //toolStripStatusLabel2.Text = "XML invalid";
               // toolStripStatusLabel2.Text = "Nieprawidłowe dane dokumentu";
            }
            ms.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            zasw.wlasciciel_psa.adres.miejscowosc = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            zasw.wlasciciel_psa.adres.ulica = textBox3.Text;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var a = Convert.ToDecimal(zasw.wlasciciel_psa.adres.nr_domu);
            
            a = numericUpDown1.Value;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            zasw.wlasciciel_psa.adres.gmina = textBox5.Text;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            zasw.wlasciciel_psa.adres.powiat = textBox6.Text;

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            zasw.zaswiadczenie.nr_zaswiadczenia = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            zasw.zaswiadczenie.miejscowosc_podpis = textBox10.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
          //  zasw.zaswiadczenie.data_wystawienia.ToString() = textBox13.Text;
        
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            zasw.zaswiadczenie.lekarz_wystawiajacy.tytul_naukowy = textBox14.Text;

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            zasw.zaswiadczenie.lekarz_wystawiajacy.imie_lek = textBox15.Text;

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            zasw.zaswiadczenie.lekarz_wystawiajacy.nazwisko_lek = textBox16.Text;

        }



        private void updateSzczepienia()
        {
            //zasw.informacja_weterynaryjna = new typ_szczepionka[dataGridView1.RowCount - 1];
            for (int i = 0; i < zasw.informacja_weterynaryjna.Length; i++)
            {
                zasw.informacja_weterynaryjna[i].data_szczepienia = DateTime.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                zasw.informacja_weterynaryjna[i].nazwa_szczep = dataGridView1.Rows[i].Cells[1].Value.ToString();
                zasw.informacja_weterynaryjna[i].nr_serii = dataGridView1.Rows[i].Cells[2].Value.ToString();
                zasw.informacja_weterynaryjna[i].data_ważn = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                zasw.informacja_weterynaryjna[i].termin_n_szczepienia= DateTime.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());  
               
              
              }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateSzczepienia();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateSzczepienia();
        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0 || dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
           

            
            //this.dataGridView1.CurrentCell.Value = wybranaData;
            //

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0 || dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                wybranaData = monthCalendar1.SelectionEnd.ToString("dd.MM.yyyy");
                this.dataGridView1.CurrentCell.Value = wybranaData;
                monthCalendar1.Visible = false;
            }
            
        }

        private void textBox13_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            wybranaData2 = monthCalendar2.SelectionEnd.ToString("dd.MM.yyyy");
            textBox13.Text = wybranaData2;
            monthCalendar2.Visible = false;

        }

        private void PDF_Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tworze PDF");
            var doc1 = new Document();
            //use a variable to let my code fit across the page...

            PdfWriter.GetInstance(doc1, new FileStream("Doc1.pdf", FileMode.Create));

            doc1.Open();

            doc1.Add(new Paragraph("Test PDF"));
            doc1.Close();
           
            Console.WriteLine("Stworzono PDF");

        }

        
        
        


       
     
       

    }
}
