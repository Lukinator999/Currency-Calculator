using System;
using System.Data.SQLite;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
namespace currency_calculator
{
    public partial class Form1 : Form
    {
        private static readonly string[] items = ["US-Dollar (USD)", "VAE-Dirham (AED)", "Afghanischer Afghani (AFN)", "Albanischer Lek (ALL)", "Armenischer Dram (AMD)", "Niederländischer-Antillen-Gulden (ANG)", "Angolanischer Kwanza (AOA)", "Argentinischer Peso (ARS)", "Australischer Dollar (AUD)", "Arubanischer Florin (AWG)", "Aserbaidschan-Manat (AZN)", "Bosnisch-herzegowinische Konvertible Mark (BAM)", "Barbados-Dollar (BBD)", "Bangladesch-Taka (BDT)", "Bulgarischer Lew (BGN)", "Bahrain-Dinar (BHD)", "Burundi-Franc (BIF)", "Bermuda-Dollar (BMD)", "Brunei-Dollar (BND)", "Bolivianischer Boliviano (BOB)", "Brasilianischer Real (BRL)", "Bahama-Dollar (BSD)", "Bhutan-Ngultrum (BTN)", "Botswanischer Pula (BWP)", "Weißrussischer Rubel (BYN)", "Belize-Dollar (BZD)", "Kanadischer Dollar (CAD)", "Kongolesischer Franc (CDF)", "Schweizer Franken (CHF)", "Chilenischer Peso (CLP)", "Chinesischer Yuan (CNY)", "Kolumbianischer Peso (COP)", "Costa-Rica-Colón (CRC)", "Kubanischer Peso (CUP)", "Kap-Verde-Escudo (CVE)", "Tschechische Krone (CZK)", "Dschibuti-Franc (DJF)", "Dänische Krone (DKK)", "Dominikanischer Peso (DOP)", "Algerischer Dinar (DZD)", "Ägyptisches Pfund (EGP)", "Eritreischer Nakfa (ERN)", "Äthiopischer Birr (ETB)", "Euro (EUR)", "Fidschi-Dollar (FJD)", "Falkland-Pfund (FKP)", "Färöische Krone (FOK)", "Britisches Pfund (GBP)", "Georgischer Lari (GEL)", "Guernsey-Pfund (GGP)", "Ghanaischer Cedi (GHS)", "Gibraltar-Pfund (GIP)", "Gambischer Dalasi (GMD)", "Guinea-Franc (GNF)", "Guatemaltekischer Quetzal (GTQ)", "Guyana-Dollar (GYD)", "Hongkong-Dollar (HKD)", "Honduranische Lempira (HNL)", "Kroatische Kuna (HRK)", "Haitianische Gourde (HTG)", "Ungarischer Forint (HUF)", "Indonesische Rupiah (IDR)", "Israelischer Schekel (ILS)", "Isle-of-Man-Pfund (IMP)", "Indische Rupie (INR)", "Irakischer Dinar (IQD)", "Iranischer Rial (IRR)", "Isländische Krone (ISK)", "Jersey-Pfund (JEP)", "Jamaika-Dollar (JMD)", "Jordanischer Dinar (JOD)", "Japanischer Yen (JPY)", "Kenia-Schilling (KES)", "Kirgisischer Som (KGS)", "Kambodschanischer Riel (KHR)", "Kiribati-Dollar (KID)", "Komoren-Franc (KMF)", "Südkoreanischer Won (KRW)", "Kuwait-Dinar (KWD)", "Kaiman-Dollar (KYD)", "Kasachischer Tenge (KZT)", "Laotischer Kip (LAK)", "Libanesisches Pfund (LBP)", "Sri-Lanka-Rupie (LKR)", "Liberianischer Dollar (LRD)", "Lesothischer Loti (LSL)", "Libyscher Dinar (LYD)", "Marokkanischer Dirham (MAD)", "Moldawischer Leu (MDL)", "Madagassischer Ariary (MGA)", "Mazedonischer Denar (MKD)", "Myanma-Kyat (MMK)", "Mongolischer Tögrög (MNT)", "Macau-Pataca (MOP)", "Mauretanischer Ouguiya (MRU)", "Mauritius-Rupie (MUR)", "Maledivische Rufiyaa (MVR)", "Malawischer Kwacha (MWK)", "Mexikanischer Peso (MXN)", "Malaysischer Ringgit (MYR)", "Mosambikanischer Metical (MZN)", "Namibischer Dollar (NAD)", "Nigerianische Naira (NGN)", "Nicaraguanischer Cordoba (NIO)", "Norwegische Krone (NOK)", "Nepalesische Rupie (NPR)", "Neuseeland-Dollar (NZD)", "Omanischer Rial (OMR)", "Panama-Balboa (PAB)", "Peruanischer Sol (PEN)", "Papua-Neuguinea-Kina (PGK)", "Philippinischer Peso (PHP)", "Pakistanische Rupie (PKR)", "Polnischer Zloty (PLN)", "Paraguayischer Guarani (PYG)", "Katar-Riyal (QAR)", "Rumänischer Leu (RON)", "Serbischer Dinar (RSD)", "Russischer Rubel (RUB)", "Ruandischer Franc (RWF)", "Saudi-Riyal (SAR)", "Salomonen-Dollar (SBD)", "Seychellen-Rupie (SCR)", "Sudanesisches Pfund (SDG)", "Schwedische Krone (SEK)", "Singapur-Dollar (SGD)", "St.-Helena-Pfund (SHP)", "Sierraleonischer Leone (SLE)", "Somalischer Schilling (SOS)", "Surinam-Dollar (SRD)", "Süd-Sudan-Pfund (SSP)", "Sao-tomeischer Dobra (STN)", "Syrisches Pfund (SYP)", "Eswatinischer Lilangeni (SZL)", "Thailändischer Baht (THB)", "Tadschikischer Somoni (TJS)", "Turkmenistan-Manat (TMT)", "Tunesischer Dinar (TND)", "Tonganischer Paʻanga (TOP)", "Türkische Lira (TRY)", "Trinidad-und-Tobago-Dollar (TTD)", "Taiwan-Dollar (TWD)", "Ukrainische Hrywnja (UAH)", "Uganda-Schilling (UGX)", "Uruguayischer Peso (UYU)", "Usbekischer Soʻm (UZS)", "Venezolanischer Bolivar (VES)", "Vietnamesischer Dong (VND)", "Samoanischer Tala (WST)", "Südafrikanischer Rand (ZAR)"];
        private bool preventTextChange1 = false;
        private bool preventTextChange2 = false;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string url;
                try
                {
                    string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                    string filePath = Path.Combine(projectPath, "api.txt");
                    using (var fileStream = File.OpenRead(filePath))
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        url = streamReader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");
                    url = "";
                }
                if (url != null)
                {
                    var client = new HttpClient();
                    var uri = new Uri(url);
                    var result = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
                    // Parse JSON string
                    var jsonObject = JObject.Parse(result);
                    var conversionRates = jsonObject["conversion_rates"];

                    string jsonString = JsonConvert.SerializeObject(conversionRates);

                    var values = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(jsonString);
                    ExchangeRateStorage.UpdateRates(values);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Abrufen der Wechselkurse"+ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFromCurrency_TextChanged(object sender, EventArgs e)
        {
            string text = txtFromCurrency.Text;
            if (items.Contains(text))
            {
                string abbreviation = text.ToUpper().Substring(text.Length - 4, 3);
                lblFromCurrency.Text = abbreviation;
            }

        }
        private void txtToCurrency_TextChanged(object sender, EventArgs e)
        {

            string text = txtToCurrency.Text;
            if (items.Contains(text))
            {
                string abbreviation = text.ToUpper().Substring(text.Length - 4, 3);
                lblToCurrency.Text = abbreviation;
            }
        }
        private void bntCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string fromCurrency = lblFromCurrency.Text.ToUpper();
                string toCurrency = lblToCurrency.Text.ToUpper();
                decimal amount = decimal.Parse(txtAmount.Text);

                try
                {
                    decimal fromCurrencyExchangeRate = ExchangeRateStorage.GetRate(fromCurrency);
                    decimal toCurrencyExchangeRate = ExchangeRateStorage.GetRate(toCurrency);
                    decimal convertedAmount = amount / fromCurrencyExchangeRate * toCurrencyExchangeRate;
                    lblResult.Text = $"{convertedAmount:F4}";
                }
                catch (KeyNotFoundException ex)
                {
                    MessageBox.Show($"Wechselkurse konnten nicht gefunden werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string fromCurrency = txtFromCurrency.Text;
            string toCurrency = txtToCurrency.Text;
            txtFromCurrency.Text = toCurrency;
            txtToCurrency.Text = fromCurrency;
            txtAmount.Text = lblResult.Text;
            lblResult.Text = "";
            bntCalculate_Click(null, EventArgs.Empty);
        }
    }
}
