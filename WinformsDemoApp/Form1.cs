using ToolScraper.Core;
using ToolScraper.Core.Products;
using ToolScraper.Core.Types;
using ToolScraper.Core.Scrapers;


namespace WinformsDemoApp;

public partial class Form1 : Form
{
    public Form1()
    {
        // Load the scraper into private property. 
        // This would be replaced with a DI container in a professional setting.
        // Misusing the http client. Should use factory. For demo purposes.
        var client = new HttpClient();
        var endmillScraper = new EndMillScraper(client);
        scraper = new EndMillScraper(client);

        InitializeComponent();
        pictureBoxKenLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.WaitOnLoad = true;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        pictureBox2.WaitOnLoad = true;
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        pictureBox3.WaitOnLoad = true;
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

    }

    private EndMillScraper scraper { get; }


    private void ValidateInputs()
    {
        if (string.IsNullOrEmpty(tbSearch.Text))
        {
            throw new ArgumentException("Invalid search value.");
        }
    }

    private void ClearForm()
    {
        lbError.Visible = false;
        lbError.Text = "";
        pictureBox1.Image = null;
        pictureBox2.Image = null;
        pictureBox3.Image = null;
        listData.Items.Clear();
        linkLabel1.Text = string.Empty;
    }

    private void DisplayError(string message)
    {
        lbError.Visible = true;
        lbError.Text = message;
    }



    private async void bSearch_Click(object sender, EventArgs e)
    {
        // Check textbox value
        ClearForm();
        ValidateInputs();
        var result = await scraper.ScrapeAsync(tbSearch.Text);

        if (!result.Success || result.Result is null)
            throw new InvalidOperationException
                ($"Scrape operation failed: {result.error}");

        var endmill = result.Result;

        // Set link
        linkLabel1.Text = endmill.Url?.AbsoluteUri ?? "";

        // Add endmill properties/values to listbox.
        var objectProperties = endmill.GetType().GetProperties();
        foreach (var property in objectProperties)
        {
            var name = property.Name;
            var value = property.GetValue(endmill);

            listData.Items.Add($"{name}:  {value}");
        }

        // Load images

        if (endmill.Media != null && endmill.Media.Length > 0)
        {
            var url1 = endmill.Media[0].AbsoluteUri;
            var url2 = endmill.Media[1].AbsoluteUri;
            var url3 = endmill.Media[2].AbsoluteUri;

            pictureBox1.Load(url1);
            pictureBox2.Load(url2);
            pictureBox3.Load(url3);
        }
    }


}

