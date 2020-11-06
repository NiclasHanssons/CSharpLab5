using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private HttpClient website = new HttpClient();
        List<string> listOfImg = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            try
            {
                Task<string> downloadHTML = website.GetStringAsync($"http://{textBoxURL.Text}");
                downloadHTML.Wait();

                string pattern = @"(?<=src="").*(?="" )";

                MatchCollection matchCollection = Regex.Matches(downloadHTML.Result, pattern, RegexOptions.IgnoreCase);

                listBoxDownloadedURL.Items.Clear();
                listOfImg.Clear();

                foreach (var url in matchCollection)
                {
                    if (url.ToString().Contains(".png") || url.ToString().Contains(".bmp") || url.ToString().Contains(".jpg") || url.ToString().Contains(".jpeg") || url.ToString().Contains(".gif"))
                    {
                        if (url.ToString().StartsWith("https://www.gp.se"))
                        {
                            listOfImg.Add(url.ToString());
                        }

                        if (!url.ToString().StartsWith("http"))
                        {
                            string newUrl = $"http://www.gp.se{url}";
                            listOfImg.Add(newUrl);
                        }
                    }
                }

                foreach (var item in listOfImg)
                {
                    listBoxDownloadedURL.Items.Add(item);
                }

                labelImgCounter.Text = $"Number of images: {listBoxDownloadedURL.Items.Count}";

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input, please write an url like gp.se", "Invalid input");
                textBoxURL.Clear();
            }

            if (listBoxDownloadedURL.Items.Count > 0)
            {
                buttonSaveFiles.Enabled = true;
            }
        }

        private async void buttonSaveFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<Task<byte[]>> downloadImg = new List<Task<byte[]>>();
                for (int i = 0; i < listBoxDownloadedURL.Items.Count; i++)
                {
                    downloadImg.Add(website.GetByteArrayAsync(listBoxDownloadedURL.Items[i].ToString()));
                }

                while (downloadImg.Count > 0)
                {
                    int progressbar = 0;

                    for (int i = 0; i < listBoxDownloadedURL.Items.Count; i++)
                    {
                        Task<byte[]> completedImg = await Task.WhenAny(downloadImg);

                        if (listOfImg[i].Contains(".png"))
                        {
                            FileStream fsPng = new FileStream($@"{dialog.SelectedPath}\img{i}.png", FileMode.Create);
                            await fsPng.WriteAsync(completedImg.Result, 0, completedImg.Result.Length);
                        }

                        if (listOfImg[i].Contains(".jpg"))
                        {
                            FileStream fsJpg = new FileStream($@"{dialog.SelectedPath}\img{i}.jpg", FileMode.Create);
                            await fsJpg.WriteAsync(completedImg.Result, 0, completedImg.Result.Length);
                        }

                        if (listOfImg[i].Contains(".gif"))
                        {
                            FileStream fsGif = new FileStream($@"{dialog.SelectedPath}\img{i}.gif", FileMode.Create);
                            await fsGif.WriteAsync(completedImg.Result, 0, completedImg.Result.Length);
                        }

                        if (listOfImg[i].Contains(".jpeg"))
                        {
                            FileStream fsJpeg = new FileStream($@"{dialog.SelectedPath}\img{i}.jpeg", FileMode.Create);
                            await fsJpeg.WriteAsync(completedImg.Result, 0, completedImg.Result.Length);
                        }

                        downloadImg.Remove(completedImg);
                        progressBarDownload.Maximum = listOfImg.Count;
                        progressbar++;
                        progressBarDownload.Value = progressbar;
                    }
                }

                MessageBox.Show($"Download complete, {listOfImg.Count} images has been saved.", "Download complete");
                progressBarDownload.Value = 0;
                textBoxURL.Clear();
                listBoxDownloadedURL.Items.Clear();
                buttonSaveFiles.Enabled = false;
                labelImgCounter.Text = $"Number of images: {listBoxDownloadedURL.Items.Count}";
            }
        }
    }
}
