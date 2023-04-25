using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide_show
{
    public partial class Image_view : Form
    {
        public Image_view()
        {
            InitializeComponent();
        }
        List<Image> images = new List<Image>();
        FolderBrowserDialog dialog = new FolderBrowserDialog();
        Image illustration;
        OpenFileDialog open_dial = new OpenFileDialog();
        static Graphics graphic;
        static Rectangle rect = new Rectangle();
        PaintEventArgs args = new PaintEventArgs(graphic, rect);
        int seek = 0;//индекс коллекции изображений
        bool workload = false;
        void view_img(bool log_val)
        {
            if (images.Count > 0)
            {
                if (log_val) seek++;
                else seek--;
                if (seek < 0) seek++;
                if (seek == images.Count) seek--;
                pict_box.Image = images[seek];
                label.Text = $"{images[seek].ToString()}/{images.Count}";
            }
        }

        private void prev_file_Click(object sender, EventArgs e)
        {
            view_img(false);
            label.Text = $"{images[seek--].ToString()}/{images.Count}";
        }

        private void next_file_Click(object sender, EventArgs e)
        {
            view_img(true);
        }

        private void pict_box_Paint(object sender, PaintEventArgs e)
        {
            open_dial.Filter = "файлы изображений|*.bmp;*.png;*.jpg";
            if (open_dial.ShowDialog() != DialogResult.OK) return;
            try
            {
                illustration = Image.FromFile(open_dial.FileName);
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show("ошибка чтения картинки");
                return;
            }
            if (illustration == null) return;
            e.Graphics.DrawImage(illustration, 0, 0);
            images.Add(illustration);
        }

        private void departure_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
        }

        private void loading_Click(object sender, EventArgs e)
        {
            open_dial.Filter = "файлы изображений|*.bmp;*.png;*.jpg";
            if (open_dial.ShowDialog() != DialogResult.OK) return;
            try
            {
                illustration = Image.FromFile(open_dial.FileName);
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show("ошибка чтения картинки");
                return;
            }
            if (illustration == null) return;
            args.Graphics.DrawImage(illustration, 0, 0);
            images.Add(illustration);
        }
    }
}