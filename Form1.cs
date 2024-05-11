using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Reflection;
using Markdig;

using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rapad
{
    public partial class Form1 : Form
    {
        private Point mousePoint;
        bool isForemost = true;
        List<string> tmpHtmlFileList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.toolStrip1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseWheel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.TopMost = true;
            toolStripButtonChangeTopMost.BackColor = Color.FromArgb(179, 215, 243);
        }

        private void toolStrip1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (this.Opacity <= 1)
                {
                    this.Opacity += 0.05;
                }
            }
            else
            {
                if (this.Opacity >= 0.4)
                {
                    this.Opacity -= 0.05;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonChangeFont_Click(object sender, EventArgs e)
        {
            //FontDialogクラスのインスタンスを作成
            FontDialog fd = new FontDialog();

            //初期のフォントを設定
            fd.Font = textBox1.Font;
            //初期の色を設定
            fd.Color = textBox1.ForeColor;
            //ユーザーが選択できるポイントサイズの最大値を設定する
            fd.MaxSize = 100;
            fd.MinSize = 8;
            //存在しないフォントやスタイルをユーザーが選択すると
            //エラーメッセージを表示する
            fd.FontMustExist = true;
            //横書きフォントだけを表示する
            fd.AllowVerticalFonts = false;
            //色を選択できるようにする
            fd.ShowColor = true;
            //取り消し線、下線、テキストの色などのオプションを指定可能にする
            //デフォルトがTrueのため必要はない
            fd.ShowEffects = true;
            //固定ピッチフォント以外も表示する
            //デフォルトがFalseのため必要はない
            fd.FixedPitchOnly = false;
            //ベクタ フォントを選択できるようにする
            //デフォルトがTrueのため必要はない
            fd.AllowVectorFonts = true;

            //ダイアログを表示する
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                //TextBox1のフォントと色を変える
                textBox1.Font = fd.Font;
                textBox1.ForeColor = fd.Color;
            }
        }

        private void toolStripButtonChangeTopMost_Click(object sender, EventArgs e)
        {
            isForemost = !isForemost;
            this.TopMost = isForemost;
            if (isForemost)
            {
                toolStripButtonChangeTopMost.BackColor = Color.FromArgb(179, 215, 243);
            }
            else
            {
                toolStripButtonChangeTopMost.BackColor = default;
            }
        }

        private void toolStripButtonResetFont_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Consolas", 11);
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Middle) == MouseButtons.Middle)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Middle) == MouseButtons.Middle)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) return;

            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = myAssembly.Location;
            DateTime date = DateTime.Now;

            string fileName;
            string afterPath;

            // 先頭行が "# "始まりだった場合、markdownとして"{先頭行の文字列}.md"とする
            if (textBox1.Lines[0].ToString().StartsWith("# "))
            {
                string noSharpText = textBox1.Lines[0].ToString().Replace("# ", "");

                // ファイル名に使用できない文字を削除
                string unUsableChar = @"\\|\/|\:|\*|\?|""|<|>|\|";
                string result = Regex.Replace(noSharpText, unUsableChar, "_");

                fileName = result + ".md";
            }
            else
            {
                fileName = date.ToString("yyMMdd_hmmss") + ".txt";
            }

            afterPath = path.Replace("Rapad.exe", "history\\" + fileName);

            // ファイル作成部分
            FileInfo fileInfo = new FileInfo(afterPath);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }


            if (!fileInfo.Exists)
            {
                using (fileInfo.Create()) ;
            }

            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine(textBox1.Text);
            }


            // 一時htmlファイル削除
            foreach (string htmlTmpFilePath in tmpHtmlFileList)
            {
                File.Delete(htmlTmpFilePath);
            }
        }

        private void toolStripButtonOpenFolder_Click(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = myAssembly.Location;
            string afterPath = path.Replace("Rapad.exe", "history\\");
            System.Diagnostics.Process.Start("EXPLORER.EXE", afterPath);
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
        }

        private async void toolStripButtonMarkdown_Click(object sender, EventArgs e)
        {
            MarkdownPipeline markdownPipeline = new MarkdownPipelineBuilder().UsePipeTables().Build();

            string markdown;

            // markdownをhtmlに変換
            markdown = Markdown.ToHtml(textBox1.Text, markdownPipeline);

            // htmlを一時ファイルとして保存
            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = myAssembly.Location;
            string htmlTmpFilePath = path.Replace("Rapad.exe", "history\\" + (new Random().Next(0, 1000000)).ToString() + ".html");
            string css;
            FileInfo fileInfo = new FileInfo(htmlTmpFilePath);
            try
            {
                css = File.ReadAllText(path.Replace("Rapad.exe", "style.css"));
            }
            catch (Exception ex)
            {
                css = "";
            }
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine(markdown);
                sw.WriteLine("\r\n<style>\r\n" + css + "\r\n</style>");
            }

            // 先のファイルを規定のブラウザで開く
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = htmlTmpFilePath,
                UseShellExecute = true,
            };
            tmpHtmlFileList.Add(htmlTmpFilePath);
            Process.Start(pi);
        }
    }
}