using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Notepad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.TextChanged += TextBox_TextChanged;
            // New File
            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, MenuItem_Click));
            // Open File
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, MenuItem_Click_1));
            // Save File
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, MenuItem_Click_2));
        }

        // New File
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text.Length == 0)
            {
                textBox.Text = "";
                MessageBox.Show("Success", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You want to save this file", "Inforamtion", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Save txt file";
                    saveFileDialog.Filter = "Text File(*txt)|*txt";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        var filePath = saveFileDialog.FileName;
                        File.WriteAllText(filePath, textBox.Text);
                    }
                    textBox.Text = "";
                }
                else
                {
                    // Nothing Happens
                }
            }
        }

        // Open File
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Txt File Open";
                openFileDialog.Filter = "Txt File(*txt)|*txt";
                if (openFileDialog.ShowDialog() == true)
                {
                    var filePath = openFileDialog.FileName;
                    var content = File.ReadAllText(filePath);
                    textBox.Text = "";
                    textBox.Text = content;
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You want to save this file", "Inforamtion", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Save txt file";
                    saveFileDialog.Filter = "Text File(*txt)|*txt";
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        var filePath = saveFileDialog.FileName;
                        File.WriteAllText(filePath, textBox.Text);
                    }
                    textBox.Text = "";
                }
                else
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Title = "Txt File Open";
                    openFileDialog.Filter = "Txt File(*txt)|*txt";
                    if (openFileDialog.ShowDialog() == true)
                    {
                        var filePath = openFileDialog.FileName;
                        var content = File.ReadAllText(filePath);
                        textBox.Text = "";
                        textBox.Text = content;
                    }
                }
            }
            
        }

        // Save
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Txt File";
            saveFileDialog.Filter = "Txt File(*txt)|*txt";
            if (textBox.Text.Length <= 0)
            {
                MessageBox.Show("Empty File Not Save", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (saveFileDialog.ShowDialog() == true)
                {
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, textBox.Text);
                    MessageBox.Show("File Saved Successfully", "Inforamtion", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        // Exit
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                // Save the text File
                MessageBoxResult result = MessageBox.Show("Please save the file and then Exit", "Information", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save text file (*txt)";
                saveFileDialog.Filter = ("txt file (*txt)|*txt");
                if (result== MessageBoxResult.OK)
                {
                    if (saveFileDialog.ShowDialog() == true)
                    {
                        var filePath = saveFileDialog.FileName;
                        File.WriteAllText(filePath, textBox.Text);
                        MessageBox.Show("File Saved Successfully", "Inforamtion", MessageBoxButton.OK, MessageBoxImage.Information);
                        Close();
                    }
                }
                else
                {
                    // Nothing happens
                }
            }
            else
            {
                MessageBox.Show("Thanks to use","Information",MessageBoxButton.OK,MessageBoxImage.Information);
                Close();
            }
            
        }

        // Cut
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                Clipboard.SetText(textBox.SelectedText);
                textBox.SelectedText = "";
            }
        }

        // copy
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        // paste
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            textBox.Text+= Clipboard.GetText();
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.TextWrapping = TextWrapping.NoWrap;
        }
        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextWrapping = TextWrapping.Wrap;
        }

        private void lineTextBlock_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            string[] lines = textBox.Text.Split('\n');
            int lineCount = lines.Length;

            lineTextBlock.Text = lineCount.ToString();
        }

        // Line And Column count
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            int lineCount = textBox.LineCount;
            int caretIndex = textBox.CaretIndex;
            int lineIndex = textBox.GetLineIndexFromCharacterIndex(caretIndex);
            int columnIndex = caretIndex - textBox.GetCharacterIndexFromLineIndex(lineIndex);

            lineTextBlock.Text = lineCount.ToString();
            columnTextBlock.Text = (columnIndex + 1).ToString();
        }
    }
}
