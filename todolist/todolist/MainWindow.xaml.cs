using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace todolist
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生一個方塊
            TodoItem item = new TodoItem();

            // 放到TodoList
            TodoList.Children.Add(item);
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 產生一個儲存每個 list 文字的 list
            List<string> all = new List<string>();

            // 取得每一個 item 的文字，放到 list
            foreach (TodoItem item in TodoList.Children)
            {
                all.Add(item.GetTaskName());
            }

            // 寫入檔案
            System.IO.File.WriteAllLines(@"c:\tododata.txt", all);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
