using AverageExchangeRate.Data;
using AverageExchangeRate.RatesProviders.Interfaces;
using Serilog;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbArchiveDataMonth.DataSource = Enum.GetValues(typeof(Month));
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
