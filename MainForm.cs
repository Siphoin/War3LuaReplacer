using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace War3LuaReplacer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void replaceButton_Click(object sender, EventArgs e)
        {
            string w3xPath = textBoxW3X.Text;
            string luaPath = textBoxLua.Text;
            string tempDir = null;

            try
            {
                // Проверка существования файлов
                if (!File.Exists(w3xPath) || !File.Exists(luaPath))
                {
                    MessageBox.Show("Файлы не найдены!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание временной директории
                tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                Directory.CreateDirectory(tempDir);

                // Полные пути к файлам
                string mpqEditorPath = Path.Combine(Application.StartupPath, "MPQEditor.exe");
                string tempW3x = Path.Combine(tempDir, "temp.w3x");
                string tempLua = Path.Combine(tempDir, "war3map.lua");

                // Копирование исходного архива
                File.Copy(w3xPath, tempW3x);

                // Удаляем старый файл из архива
                ExecuteMpqEditor(mpqEditorPath, $"delete \"{tempW3x}\" war3map.lua");

                // Копируем новый Lua-файл во временную папку
                File.Copy(luaPath, tempLua);

                // Добавляем файл В КОРЕНЬ архива (третий аргумент - путь внутри архива)
                ExecuteMpqEditor(mpqEditorPath, $"add \"{tempW3x}\" \"{tempLua}\" war3map.lua");

                // Заменяем оригинальный файл
                File.Copy(tempW3x, w3xPath, true);

                MessageBox.Show("Файл успешно заменён!", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Удаление временной директории
                if (tempDir != null && Directory.Exists(tempDir))
                {
                    try
                    {
                        Directory.Delete(tempDir, true);
                    }
                    catch { /* Игнорируем ошибки удаления */ }
                }
            }
        }

        private void browseW3XButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Warcraft 3 Map Files (*.w3x, *.w3m)|*.w3x;*.w3m|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxW3X.Text = openFileDialog.FileName;
                }
            }
        }

        private void browseLuaButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Lua Files (*.lua)|*.lua";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxLua.Text = openFileDialog.FileName;
                }
            }
        }

        private void ExecuteMpqEditor(string editorPath, string arguments)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = editorPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string error = process.StandardError.ReadToEnd();
                throw new Exception($"MPQEditor error: {error}");
            }
        }
    }
}