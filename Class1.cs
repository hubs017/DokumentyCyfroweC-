﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     Ten kod został wygenerowany przez narzędzie.
    //     Wersja wykonawcza:4.0.30319.42000
    //
    //     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
    //     kod zostanie ponownie wygenerowany.
    // </auto-generated>
    //------------------------------------------------------------------------------

    using System.Xml.Serialization;

    // 
    // This source code was auto-generated by xsd, Version=4.6.1055.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("zaswiadczenie_szczepienia", Namespace = "", IsNullable = false)]
    public partial class typ_zaswiadczenie_szczepienia
    {

        private typ_zaswiadczenie zaswiadczenieField;

        private typ_wlasciciel_psa wlasciciel_psaField;

        private typ_opis_psa opis_psaField;

        private typ_szczepionka[] informacja_weterynaryjnaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public typ_zaswiadczenie zaswiadczenie
        {
            get
            {
                return this.zaswiadczenieField;
            }
            set
            {
                this.zaswiadczenieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public typ_wlasciciel_psa wlasciciel_psa
        {
            get
            {
                return this.wlasciciel_psaField;
            }
            set
            {
                this.wlasciciel_psaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public typ_opis_psa opis_psa
        {
            get
            {
                return this.opis_psaField;
            }
            set
            {
                this.opis_psaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("szczepionka", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public typ_szczepionka[] informacja_weterynaryjna
        {
            get
            {
                return this.informacja_weterynaryjnaField;
            }
            set
            {
                this.informacja_weterynaryjnaField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_zaswiadczenie
    {

        private string nr_zaswiadczeniaField;

        private string miejscowosc_podpisField;

        private System.DateTime data_wystawieniaField;

        private typ_lekarz_wystawiajacy lekarz_wystawiajacyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string nr_zaswiadczenia
        {
            get
            {
                return this.nr_zaswiadczeniaField;
            }
            set
            {
                this.nr_zaswiadczeniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string miejscowosc_podpis
        {
            get
            {
                return this.miejscowosc_podpisField;
            }
            set
            {
                this.miejscowosc_podpisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime data_wystawienia
        {
            get
            {
                return this.data_wystawieniaField;
            }
            set
            {
                this.data_wystawieniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public typ_lekarz_wystawiajacy lekarz_wystawiajacy
        {
            get
            {
                return this.lekarz_wystawiajacyField;
            }
            set
            {
                this.lekarz_wystawiajacyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_lekarz_wystawiajacy
    {

        private string tytul_naukowyField;

        private string imie_lekField;

        private string nazwisko_lekField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tytul_naukowy
        {
            get
            {
                return this.tytul_naukowyField;
            }
            set
            {
                this.tytul_naukowyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string imie_lek
        {
            get
            {
                return this.imie_lekField;
            }
            set
            {
                this.imie_lekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nazwisko_lek
        {
            get
            {
                return this.nazwisko_lekField;
            }
            set
            {
                this.nazwisko_lekField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_szczepionka
    {

        private string nazwa_szczepField;

        private string nr_seriiField;

        private System.DateTime data_ważnField;

        private System.DateTime termin_n_szczepieniaField;

        private System.DateTime data_szczepieniaField;

        private bool data_szczepieniaFieldSpecified;

        private bool termin_n_szczepieniaSpecified;

        private bool data_ważnSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nazwa_szczep
        {
            get
            {
                return this.nazwa_szczepField;
            }
            set
            {
                this.nazwa_szczepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string nr_serii
        {
            get
            {
                return this.nr_seriiField;
            }
            set
            {
                this.nr_seriiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime data_ważn
        {
            get
            {
                return this.data_ważnField;
            }
            set
            {
                this.data_ważnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime termin_n_szczepienia
        {
            get
            {
                return this.termin_n_szczepieniaField;
            }
            set
            {
                this.termin_n_szczepieniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime data_szczepienia
        {
            get
            {
                return this.data_szczepieniaField;
            }
            set
            {
                this.data_szczepieniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool data_szczepieniaSpecified
        {
            get
            {
                return this.data_szczepieniaFieldSpecified;
            }
            set
            {
                this.data_szczepieniaFieldSpecified = value;
            }
        }


    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_opis_psa
    {

        private string nazwa_psaField;

        private string rasaField;

        private string plecField;

        private string wiek_psaField;

        private string mascField;

        private string znaki_szczegolneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nazwa_psa
        {
            get
            {
                return this.nazwa_psaField;
            }
            set
            {
                this.nazwa_psaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rasa
        {
            get
            {
                return this.rasaField;
            }
            set
            {
                this.rasaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string plec
        {
            get
            {
                return this.plecField;
            }
            set
            {
                this.plecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string wiek_psa
        {
            get
            {
                return this.wiek_psaField;
            }
            set
            {
                this.wiek_psaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string masc
        {
            get
            {
                return this.mascField;
            }
            set
            {
                this.mascField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string znaki_szczegolne
        {
            get
            {
                return this.znaki_szczegolneField;
            }
            set
            {
                this.znaki_szczegolneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_adres
    {

        private string miejscowoscField;

        private string ulicaField;

        private string nr_domuField;

        private string gminaField;

        private string powiatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string miejscowosc
        {
            get
            {
                return this.miejscowoscField;
            }
            set
            {
                this.miejscowoscField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string nr_domu
        {
            get
            {
                return this.nr_domuField;
            }
            set
            {
                this.nr_domuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string gmina
        {
            get
            {
                return this.gminaField;
            }
            set
            {
                this.gminaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string powiat
        {
            get
            {
                return this.powiatField;
            }
            set
            {
                this.powiatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class typ_wlasciciel_psa
    {

        private string imieField;

        private string nazwiskoField;

        private typ_adres adresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string imie
        {
            get
            {
                return this.imieField;
            }
            set
            {
                this.imieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nazwisko
        {
            get
            {
                return this.nazwiskoField;
            }
            set
            {
                this.nazwiskoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public typ_adres adres
        {
            get
            {
                return this.adresField;
            }
            set
            {
                this.adresField = value;
            }
        }
    }
}
