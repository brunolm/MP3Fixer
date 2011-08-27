using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MP3Fixer.Properties;

namespace MP3Fixer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs ev)
        {
            Location = Settings.Default.StartLocation;

            DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    var dir = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];

                    if (Directory.Exists(dir))
                        e.Effect = DragDropEffects.Move;
                }
            };

            DragDrop += (s, e) =>
            {
                var dir = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
                folder.Text = dir;
                ListFiles(dir);
            };

            FormClosing += (s, e) =>
            {
                Settings.Default.StartLocation = Location;
                Settings.Default.Save();
            };
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folder.Text))
            {
                FixFiles(folder.Text);
            }
        }

        private void ListFiles(string dir)
        {
            files.Clear();
            Directory.GetFiles(dir, "*.mp3", SearchOption.AllDirectories)
                .ToList().ForEach(f => files.AppendText(String.Format("{0}{1}", f, Environment.NewLine)));
        }

        private void FixFiles(string dir)
        {
            files.Clear();
            Directory.GetFiles(dir, "*.mp3", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f =>
                {
                    var fileNameWithoutAlbumFragment = Path.GetFileNameWithoutExtension(f).Split(new string[] { "- " }, 2, StringSplitOptions.RemoveEmptyEntries);
                    var fileNameWithoutAlbum = fileNameWithoutAlbumFragment[fileNameWithoutAlbumFragment.Length - 1];

                    TagLib.File tagFile = TagLib.File.Create(f);
                    tagFile.Tag.Title = fileNameWithoutAlbum;
                    tagFile.Tag.Album = dir.Substring(dir.LastIndexOf('\\') + 1);
                    tagFile.Save();

                    files.AppendText(String.Format("{0} OK{1}", f, Environment.NewLine));
                });
        }

        private void pin_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;

            if (TopMost)
            {
                pin.BackColor = Color.Gray;
            }
            else
            {
                pin.BackColor = Color.LightSlateGray;
            }
        }
    }
}
