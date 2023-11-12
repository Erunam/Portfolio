using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLDataBindingTest
{
    public partial class Form1 : Form
    {
        // połączenie z bazą danych
        private MySqlConnection conn = new MySqlConnection(); 

        //Server=localhost; Port=3306; Database=rainbowstainedglass; User Id=RainbowAdmin; Password=ekhelebeth72;

        //DataSet - reprezentacja danych bazy w pamięci komputera
        private DataSet data = new DataSet();

        private MySqlDataAdapter da = new MySqlDataAdapter(); // pośrednik między DataSet a bazą
        //używa metodę Fill() i komendę Select do ściągnięcia danych z bazy do DataSet
        private MySqlCommand SelectCommand = new MySqlCommand(); // wyrażenie sql na wybór dla DataAdapter.SelectCommand
        //używa poniższych komend (properties) dla wysłania danych z DataSet do bazy
        private MySqlCommand InsertCommand = new MySqlCommand(); // wyrażenie sql na wstawienie dla DataAdapter.InsertCommand
        private MySqlCommand UpdateCommand = new MySqlCommand(); // wyrażenie sql na aktualizację rekordu dla DataAdapter.UpdateCommend
        private MySqlCommand DeleteCommand = new MySqlCommand(); // wyrażenie sql na usunięcie rekordu dla DataAdapter.DeleteCommand
        private MySqlCommandBuilder CommandBuilder = new MySqlCommandBuilder(); // object automatycznie generujący zapytania

        public Form1()
        {
            InitializeComponent();

            string connectionstring = "Server=localhost; Port=3306; Database=rainbowstainedglass; User Id=RainbowAdmin; Password=ekhelebeth72;";
            
            // użyjemy konstruktora DataAdapter żeby otworzyć połączenie i ściągnąć dane z zapytanie sql
            // this.da = new MySqlDataAdapter(query, connectionstring);
            
            // CommandBuilder generuje komendy w momencie gdy są potrzebne
            // używa do tego aktualnej komendy SELECT
            // warunkiem jest aby tabela posiadała unikalny klucz lub index
            CommandBuilder.DataAdapter = da;
            
            // to samo można zrobić nieco dłużej, ale czasem jest wygodniej
            conn.ConnectionString = connectionstring;
            // tutaj przypiszemy połączenie do zapytania
            SelectCommand.Connection = conn;
            //typ zapytania
            SelectCommand.CommandType = CommandType.Text;
            // a teraz treść zapytania
            SelectCommand.CommandText =
                "SELECT * FROM componentandpart";
            // przypisujemy zestaw połączenie + zapytanie do DataAdapter
            da.SelectCommand = SelectCommand;
            // krócej jest użyć konstruktora
                //da.SelectCommand = new MySqlCommand("command text", conn);
            // jeśli chcemy aby tabela docelowa nazywała się inaczej niż źródłowa to 
            // przypisujemy mapping
                //da.TableMappings.Add("Table", "ComponentAndPart");
            // i ściągamy dane z bazy za pomocą metody Fill()
            da.Fill(data, "ComponentAndPart");
            
            // dodatkowe dane
            SelectCommand.CommandText = "SELECT * FROM ComponentDetails";
            //da.TableMappings.Add("Table", "stainedglassdesign");
            da.Fill(data, "ComponentDetails");

            // można zapamiętać zapytanie w ExtendedPropoerties
            data.Tables["ComponentDetails"].ExtendedProperties.Add("Select", "SELECT * FROM ComponentDetails");
            // i tak dalej

            string a = data.Tables["ComponentDetails"].ExtendedProperties["Select"].ToString();

            // operacje na wyświetlaniu danych DataView
            // Create default DataView settings.
                //DataViewManager viewManager = new DataViewManager(data);
                //viewManager.DataViewSettings["ComponentAndPart"].RowFilter = "ComponentName = 'a'";
                //data.DefaultViewManager.DataViewSettings["ComponentAndPart"].RowFilter = "ComponentName = 'a'";
            
            // wyświetlamy dane w kontrolce
                /*  
                    dataGridView1.DataSource = data;
                    dataGridView1.DataMember = "ComponentAndPart";

                    dataGridView2.DataSource = data;
                    dataGridView2.DataMember = "ComponentDetails";
                    */

            
            // Utworzymy powiązanie (relacje) master=>slave
            data.Relations.Add("ComponentInDetails",
                data.Tables["ComponentAndPart"].Columns["ComponentID"],
                data.Tables["ComponentDetails"].Columns["ComponentID"]);
            // Tabela master zawiera teraz dodatkowe zestaw danych z tabeli slave
            // nazwany jak relacja, zestaw danych w tabeli relacji jest definiowany przez
            // aktualnie wybrany w tabeli master klucz.
            // W identyczny sposób można zdefiniować kolejną podrzędną tabelę.

            // Dodamy combosy i zapytania concat
            SelectCommand.CommandText = "SELECT ComponentID, concat(ComponentName, '.', Attribute) as ComponentName FROM componentandpart";
            da.Fill(data, "ComboData");

            Column3.DataSource = data.Tables["ComboData"];
            Column3.DisplayMember = "ComponentName";
            Column3.ValueMember = "ComponentID";

            // wyświetlamy dane w kontrolce
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "ComponentAndPart";


            // Tutaj chcemy wyświetlać dane zdefiniowane poprzez relację
            dataGridView2.DataSource = data;
            dataGridView2.DataMember = "ComponentAndPart.ComponentInDetails";


            textBox1.Text = data.Tables[0].TableName.ToString();
            textBox2.Text = data.Tables[1].TableName.ToString();

            
        }

        private void UpdateDataBase(object sender, EventArgs e)
        {
            // żeby wysłać dane do bazy DataSet potrzebuje zdefiniowane komendy
            // Update, Delete, Insert
            // CommandBuilder.RefreshSchema czyści bieżące ustawienia

            CommandBuilder.RefreshSchema();
            da.SelectCommand.CommandText = "SELECT * FROM ComponentAndPart";
            // dopiero tutaj są generowane kwerendy zwrotne
            da.Update(data, "ComponentAndPart");

            CommandBuilder.RefreshSchema();
            da.SelectCommand.CommandText = "SELECT * FROM ComponentDetails";
            da.Update(data, "ComponentDetails");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
