using AverageExchangeRate.Data;
using AverageExchangeRate.RatesProviders.Interfaces;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileProcessing.Extensions;

namespace AverageExchangeRate
{
	public partial class MainWindow : Form
    {
        private readonly IRatesProviderFactory ratesProviderFactory;

        public Rates Rates { get; private set; }

        public MainWindow(IRatesProviderFactory ratesProviderFactory)
        {
            this.ratesProviderFactory = ratesProviderFactory;

            InitializeComponent();
            InitializeDataGridView();

            AddMonthsToComboBox();
        }

        private async void btnLoadCurrentRates_Click(object sender, EventArgs e)
        {
			Log.Information("Loading current rates");
			var currentRatesProvider = this.ratesProviderFactory.CreateCurrentRatesProvider();

            await RetrieveAndDisplayRatesAsync(currentRatesProvider);
        }

        private async void btnLoadArchiveData_Click(object sender, EventArgs e)
        {
			var ratesMonth = (Month)this.cbArchiveDataMonth.SelectedValue;
            var ratesYear = this.txtArchiveDataYear.Text;
			
            Log.Information($"Loading archive rates for month: '{ratesMonth}' and year '{ratesYear}'");

			var archivalRatesProvider = this.ratesProviderFactory.CreateArchivalRatesProvider(ratesMonth, ratesYear);

            await RetrieveAndDisplayRatesAsync(archivalRatesProvider);
        }

		private void AddMonthsToComboBox()
		{
			var months = Enum.GetValues(typeof(Month)).Cast<Month>().Select(month => new
			{
				Value = month,
				DisplayName = month.GetName()
			}).ToList();

			cbArchiveDataMonth.DataSource = months;
			cbArchiveDataMonth.DisplayMember = "DisplayName";
			cbArchiveDataMonth.ValueMember = "Value";
		}

		private async Task RetrieveAndDisplayRatesAsync(IRatesProvider provider)
        {
			this.Rates = await provider.GetRatesAsync();

            this.dgRates.DataSource = new BindingSource { DataSource = this.Rates.RateList };
        }

        private void InitializeDataGridView()
        {
            this.dgRates.AutoGenerateColumns = true;
            this.dgRates.AllowUserToAddRows = false;
            this.dgRates.AllowUserToDeleteRows = false;
            this.dgRates.ReadOnly = true;
            this.dgRates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgRates.MultiSelect = false;
        }
    }
}
