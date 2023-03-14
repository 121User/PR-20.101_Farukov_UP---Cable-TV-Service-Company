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
using System.Windows.Shapes;

namespace PR_20._101_Farukov_UP___Cable_TV_Service_Company
{
    /// <summary>
    /// Логика взаимодействия для ServicePackage_AddOrEdit.xaml
    /// </summary>
    public partial class ServicePackage_AddOrEdit : Window
    {
        public ServicePackage_AddOrEdit()
        {
            InitializeComponent();

            tbl_ServicePackage.Text = "Добавление" + tbl_ServicePackage.Text;
            btn_AddOrEdit.Content = "Добавить";
            tbl_PackageNumgerInt.Text = Helper.GetSPackageLastID().ToString();
        }

        Model.ServicePackage oldPackage;

        public ServicePackage_AddOrEdit(Model.ServicePackage servicePackage)
        {
            InitializeComponent();

            oldPackage = servicePackage;

            tbl_ServicePackage.Text = "Изменение" + tbl_ServicePackage.Text;
            btn_AddOrEdit.Content = "Изменить";

            tbl_PackageNumgerInt.Text = servicePackage.SPackageID.ToString();
            tb_PackageTitle.Text = servicePackage.SPackageTitle;
            tb_PackageDescription.Text = servicePackage.SPackageDescription;
            tb_PackageCost.Text = servicePackage.SPackageCost.ToString();
            dp_PackageStartDate.SelectedDate = servicePackage.SPackageStartDate;
            dp_PackageEndDate.SelectedDate = servicePackage.SPackageEndDate;
        }

        private void Button_ClickAddOrEdit(object sender, RoutedEventArgs e)
        {
            Model.ServicePackage newPackage = new Model.ServicePackage();
            //Проверка заполнения полей
            if (tb_PackageTitle.Text != "" && tb_PackageDescription.Text != "" && tb_PackageCost.Text != "")
            {
                //Проверка корректности данных
                try
                {
                    newPackage.SPackageID = int.Parse(tbl_PackageNumgerInt.Text);
                    newPackage.SPackageTitle = tb_PackageTitle.Text;
                    newPackage.SPackageDescription = tb_PackageDescription.Text;
                    newPackage.SPackageCost = int.Parse(tb_PackageCost.Text);
                    newPackage.SPackageStartDate = (DateTime)dp_PackageStartDate.SelectedDate;
                    newPackage.SPackageEndDate = (DateTime)dp_PackageEndDate.SelectedDate;
                }
                catch
                {
                    MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введены не все данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (btn_AddOrEdit.Content.ToString() == "Добавить")
            {
                Helper.AddSPackage(newPackage);
                this.Close();
            }
            else
            {
                Helper.EditSPackage(oldPackage, newPackage);
                this.Close();
            }
        }

        private void Button_ClickCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
