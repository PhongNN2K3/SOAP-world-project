using ServiceReference1;

namespace WorldSearchClient
{
    public partial class Form1 : Form
    {
        WebService1SoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
        }

        private async void buttonGetAllCountries_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            // Gọi phương thức bất đồng bộ từ dịch vụ SOAP
            var countriesResponse = await client.GetAllCountriesAsync();

            // Kiểm tra dữ liệu trả về
            if (countriesResponse.Body.GetAllCountriesResult != null)
            {
                foreach (var country in countriesResponse.Body.GetAllCountriesResult)
                {
                    listBoxResults.Items.Add(country);
                }
            }
        }

        private async void buttonGetCountryByCode_Click(object sender, EventArgs e)
        {
            string code = textBoxCountryCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Vui lòng nhập mã quốc gia.");
                return;
            }

            // Gọi phương thức SOAP bất đồng bộ và chờ kết quả
            var response = await client.GetCountryByCodeAsync(code);

            // Kiểm tra và hiển thị kết quả
            if (response.Body.GetCountryByCodeResult != null)
            {
                MessageBox.Show($"Tên quốc gia: {response.Body.GetCountryByCodeResult}");
            }
            else
            {
                MessageBox.Show("Không tìm thấy quốc gia.");
            }
        }

        private async void buttonGetCityByName_Click(object sender, EventArgs e)
        {
            string cityName = textBoxCityName.Text.Trim();
            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Vui lòng nhập tên thành phố.");
                return;
            }

            // Gọi phương thức SOAP bất đồng bộ và chờ kết quả
            var response = await client.GetCityByNameAsync(cityName);

            // Kiểm tra và hiển thị kết quả
            if (response.Body.GetCityByNameResult != null)
            {
                MessageBox.Show($"Tên thành phố: {response.Body.GetCityByNameResult}");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thành phố.");
            }
        }

        private async void buttonGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            string countryCode = textBoxCountryCode.Text.Trim();
            if (string.IsNullOrEmpty(countryCode))
            {
                MessageBox.Show("Vui lòng nhập mã quốc gia.");
                return;
            }

            listBoxResults.Items.Clear();

            // Gọi phương thức bất đồng bộ từ dịch vụ SOAP
            var citiesResponse = await client.GetCitiesByCountryAsync(countryCode);

            // Kiểm tra dữ liệu trả về
            if (citiesResponse.Body.GetCitiesByCountryResult != null)
            {
                foreach (var city in citiesResponse.Body.GetCitiesByCountryResult)
                {
                    listBoxResults.Items.Add(city);
                }
            }
        }
    }
}
