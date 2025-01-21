using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSchiefer_Lab_1_Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityPopulationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityPopulationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityPopulationDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityPopulationDBDataSet.CityPopulation' table. You can move, or remove it, as needed.
            this.cityPopulationTableAdapter.Fill(this.cityPopulationDBDataSet.CityPopulation);
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            if (numberOfCitiesRdBtn.Checked)
            {
                MessageBox.Show("There are " + this.cityPopulationTableAdapter.CountCities() +
                    " total cities in this data table.");
            }
            else if (totalPopulationRdBtn.Checked)
            {
                MessageBox.Show("The total population of all cities is " +
                    this.cityPopulationTableAdapter.TotalCityPopulation());
            }
            else if (averagePopulationRdBtn.Checked)
            {
                MessageBox.Show("The average population of all cities is " +
                    this.cityPopulationTableAdapter.AverageCityPopulation());
            }
            else if (maxPopulationRdBtn.Checked)
            {
                this.cityPopulationTableAdapter.MaxCityPopulationInformation
                    (this.cityPopulationDBDataSet.CityPopulation);
            }
            else if (minPopulationRdBtn.Checked)
            {
                this.cityPopulationTableAdapter.MinCityPopulationInformation
                    (this.cityPopulationDBDataSet.CityPopulation);
            }
            else
            {
                MessageBox.Show("Please select a stat to display.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (citySearchRdBtn.Checked)
            {
                this.cityPopulationTableAdapter.SearchCity
                    (this.cityPopulationDBDataSet.CityPopulation, searchTxtBx.Text);
            }
            else if (stateSearchRdBtn.Checked)
            {
                this.cityPopulationTableAdapter.SearchState
                    (this.cityPopulationDBDataSet.CityPopulation, searchTxtBx.Text);
            }
            else if (countrySearchRdBtn.Checked)
            {
                this.cityPopulationTableAdapter.SearchCountry
                    (this.cityPopulationDBDataSet.CityPopulation, searchTxtBx.Text);
            }
            else
            {
                MessageBox.Show("Please select a field to search.");
            }
        }


        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (ascendingSortRdBtn.Checked)
            {
                if (cityIDSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.Fill(this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (citySortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByCityAscending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (stateSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByStateAscending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (countrySortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByCountryAscending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (populationSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByPopulationAscending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else
                {
                    SortError();
                }
            }
            else if (descendingSortRdBtn.Checked)
            {
                if (cityIDSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByCityIDDescending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (citySortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByCityDescending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (stateSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByStateDescending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (countrySortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByCountryDescending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else if (populationSortRdBtn.Checked)
                {
                    this.cityPopulationTableAdapter.SortByPopulationDescending
                        (this.cityPopulationDBDataSet.CityPopulation);
                }
                else
                {
                    SortError();
                }
            }
            else
            {
                SortError();
            }
        }


        private void SortError()
        {
            MessageBox.Show("Please make sure to select both a field and an order to sort.");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.cityPopulationTableAdapter.Fill(this.cityPopulationDBDataSet.CityPopulation);
            cityIDSortRdBtn.Checked = false;
            citySortRdBtn.Checked = false;
            stateSortRdBtn.Checked = false;
            countrySortRdBtn.Checked = false;
            populationSortRdBtn.Checked = false;
            ascendingSortRdBtn.Checked = false;
            descendingSortRdBtn.Checked = false;
            citySearchRdBtn.Checked = false;
            stateSearchRdBtn.Checked = false;
            countrySearchRdBtn.Checked = false;
            searchTxtBx.Text = string.Empty;
            numberOfCitiesRdBtn.Checked = false;
            totalPopulationRdBtn.Checked = false;
            averagePopulationRdBtn.Checked = false;
            maxPopulationRdBtn.Checked = false;
            minPopulationRdBtn.Checked = false;
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using my City Population application." +
                "\n\ncreated by: CodeMonkeyDan");
            this.Close();
        }
    }
}
