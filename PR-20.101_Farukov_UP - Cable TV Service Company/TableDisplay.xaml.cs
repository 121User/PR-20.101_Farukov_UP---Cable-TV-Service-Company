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
    /// Логика взаимодействия для TableDisplay.xaml
    /// </summary>
    public partial class TableDisplay : Window
    {
        private Model.CompanyBaseEntities bd = Helper.getContex();

        DataGridTextColumn textColumn1 = new DataGridTextColumn();
        DataGridTextColumn textColumn2 = new DataGridTextColumn();
        DataGridTextColumn textColumn3 = new DataGridTextColumn();
        DataGridTextColumn textColumn4 = new DataGridTextColumn();
        DataGridTextColumn textColumn5 = new DataGridTextColumn();
        DataGridTextColumn textColumn6 = new DataGridTextColumn();
        DataGridTextColumn textColumn7 = new DataGridTextColumn();
        DataGridTextColumn textColumn8 = new DataGridTextColumn();
        DataGridTextColumn textColumn9 = new DataGridTextColumn();
        DataGridTextColumn textColumn10 = new DataGridTextColumn();

        private string tName;

        public TableDisplay(string tableName)
        {
            InitializeComponent();
            tName = tableName;

            switch (tableName)
            {
                case "Request":
                    tbl_TableName.Text = tbl_TableName.Text + "Заявки";

                    var request = bd.Request.ToList(); //обращаемся к таблице Request
                    dg_Table.ItemsSource = request; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер заявки";
                    this.textColumn1.Binding = new Binding("RequestID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Номер клиента";
                    this.textColumn2.Binding = new Binding("IDClient");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Дата подачи заявки";
                    this.textColumn3.Binding = new Binding("RequestDate");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Дата ответа на заявку";
                    this.textColumn4.Binding = new Binding("RequestApprovalDate");
                    dg_Table.Columns.Add(this.textColumn4);

                    this.textColumn5.Header = "Номер статуса заявки";
                    this.textColumn5.Binding = new Binding("IDRequestStatus");
                    dg_Table.Columns.Add(this.textColumn5);

                    break;

                case "RequestStatus":
                    tbl_TableName.Text = tbl_TableName.Text + "Статусы заявок";

                    var requestStatus = bd.RequestStatus.ToList(); //обращаемся к таблице RequestStatus
                    dg_Table.ItemsSource = requestStatus; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер статуса";
                    this.textColumn1.Binding = new Binding("RequestStatusID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Название статуса";
                    this.textColumn2.Binding = new Binding("RequestStatusName");
                    dg_Table.Columns.Add(this.textColumn2);

                    break;

                case "Client":
                    tbl_TableName.Text = tbl_TableName.Text + "Клиенты";

                    var client = bd.Client.ToList(); //обращаемся к таблице Client
                    dg_Table.ItemsSource = client; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "ID";
                    this.textColumn1.Binding = new Binding("ClientID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Фамилия";
                    this.textColumn2.Binding = new Binding("ClientLastName");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Имя";
                    this.textColumn3.Binding = new Binding("ClientFirstName");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Отчество";
                    this.textColumn4.Binding = new Binding("ClientPatronymic");
                    dg_Table.Columns.Add(this.textColumn4);

                    this.textColumn5.Header = "Телефон";
                    this.textColumn5.Binding = new Binding("ClientPhone");
                    dg_Table.Columns.Add(this.textColumn5);

                    this.textColumn6.Header = "Email";
                    this.textColumn6.Binding = new Binding("ClientEmail");
                    dg_Table.Columns.Add(this.textColumn6);

                    this.textColumn7.Header = "Пароль";
                    this.textColumn7.Binding = new Binding("ClientPassword");
                    dg_Table.Columns.Add(this.textColumn7);

                    this.textColumn8.Header = "Баланс";
                    this.textColumn8.Binding = new Binding("ClientBalance");
                    dg_Table.Columns.Add(this.textColumn8);

                    this.textColumn9.Header = "Дата рождения";
                    this.textColumn9.Binding = new Binding("ClientDateOfBirth");
                    dg_Table.Columns.Add(this.textColumn9);

                    this.textColumn10.Header = "Адрес";
                    this.textColumn10.Binding = new Binding("ClientAddress");
                    dg_Table.Columns.Add(this.textColumn10);

                    break;

                case "Repair":
                    tbl_TableName.Text = tbl_TableName.Text + "Ремонты";

                    var repair = bd.Repair.ToList(); //обращаемся к таблице Repair
                    dg_Table.ItemsSource = repair; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер заявки";
                    this.textColumn1.Binding = new Binding("RepairID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Номер клиента";
                    this.textColumn2.Binding = new Binding("IDClient");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Описание проблемы";
                    this.textColumn3.Binding = new Binding("RepairDescription");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Номер сотруднкиа (мастер)";
                    this.textColumn4.Binding = new Binding("IDStaff");
                    dg_Table.Columns.Add(this.textColumn4);

                    this.textColumn5.Header = "Стоимость заявки";
                    this.textColumn5.Binding = new Binding("RepairCost");
                    dg_Table.Columns.Add(this.textColumn5);

                    break;

                case "Staff":
                    tbl_TableName.Text = tbl_TableName.Text + "Персонал";

                    var staff = bd.Staff.ToList(); //обращаемся к таблице Staff
                    dg_Table.ItemsSource = staff; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "ID";
                    this.textColumn1.Binding = new Binding("StaffID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Фамилия";
                    this.textColumn2.Binding = new Binding("StaffLastName");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Имя";
                    this.textColumn3.Binding = new Binding("StaffFirstName");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Отчество";
                    this.textColumn4.Binding = new Binding("StaffPatronymic");
                    dg_Table.Columns.Add(this.textColumn4);

                    this.textColumn5.Header = "Телефон";
                    this.textColumn5.Binding = new Binding("StaffPhone");
                    dg_Table.Columns.Add(this.textColumn5);

                    this.textColumn6.Header = "Email";
                    this.textColumn6.Binding = new Binding("StaffEmail");
                    dg_Table.Columns.Add(this.textColumn6);

                    this.textColumn7.Header = "Пароль";
                    this.textColumn7.Binding = new Binding("StaffPassword");
                    dg_Table.Columns.Add(this.textColumn7);

                    this.textColumn8.Header = "Дата рождения";
                    this.textColumn8.Binding = new Binding("StaffDateOfBirth");
                    dg_Table.Columns.Add(this.textColumn8);

                    this.textColumn9.Header = "Номер роли";
                    this.textColumn9.Binding = new Binding("IDRole");
                    dg_Table.Columns.Add(this.textColumn9);

                    this.textColumn10.Header = "Опыт работы";
                    this.textColumn10.Binding = new Binding("StaffExperience");
                    dg_Table.Columns.Add(this.textColumn10);

                    break;

                case "Role":
                    tbl_TableName.Text = tbl_TableName.Text + "Роли персонала";

                    var role = bd.Role.ToList(); //обращаемся к таблице Role
                    dg_Table.ItemsSource = role; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер роли";
                    this.textColumn1.Binding = new Binding("RoleID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Название роли";
                    this.textColumn2.Binding = new Binding("RoleName");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Описание обязанностей";
                    this.textColumn3.Binding = new Binding("RoleDescription");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Заработная плата";
                    this.textColumn4.Binding = new Binding("RoleSalary");
                    dg_Table.Columns.Add(this.textColumn4);

                    break;

                case "Wish":
                    tbl_TableName.Text = tbl_TableName.Text + "Пожелания";

                    var wish = bd.Wish.ToList(); //обращаемся к таблице Wish
                    dg_Table.ItemsSource = wish; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер пожелания";
                    this.textColumn1.Binding = new Binding("WishID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Номер клиента";
                    this.textColumn2.Binding = new Binding("IDClient");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Описание пожелания";
                    this.textColumn3.Binding = new Binding("WishDescription");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Номер статуса пожелания";
                    this.textColumn4.Binding = new Binding("IDWishStatus");
                    dg_Table.Columns.Add(this.textColumn4);

                    break;

                case "WishStatus":
                    tbl_TableName.Text = tbl_TableName.Text + "Статусы пожеланий";

                    var wishStatus = bd.WishStatus.ToList(); //обращаемся к таблице WishStatus
                    dg_Table.ItemsSource = wishStatus; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер статуса";
                    this.textColumn1.Binding = new Binding("WishStatusID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Название статуса";
                    this.textColumn2.Binding = new Binding("WishStatusName");
                    dg_Table.Columns.Add(this.textColumn2);

                    break;

                case "ServicePackage":

                    btn_Add.IsEnabled = true;

                    tbl_TableName.Text = tbl_TableName.Text + "Пакеты услуг";

                    var servicePackage = bd.ServicePackage.ToList(); //обращаемся к таблице ServicePackage
                    dg_Table.ItemsSource = servicePackage; //передаем таблицу Request в DataGrid

                    //Создание столбцов таблицы dg_Table
                    this.textColumn1.Header = "Номер";
                    this.textColumn1.Binding = new Binding("SPackageID");
                    dg_Table.Columns.Add(this.textColumn1);

                    this.textColumn2.Header = "Название";
                    this.textColumn2.Binding = new Binding("SPackageTitle");
                    dg_Table.Columns.Add(this.textColumn2);

                    this.textColumn3.Header = "Описание";
                    this.textColumn3.Binding = new Binding("SPackageDescription");
                    dg_Table.Columns.Add(this.textColumn3);

                    this.textColumn4.Header = "Стоимость";
                    this.textColumn4.Binding = new Binding("SPackageCost");
                    dg_Table.Columns.Add(this.textColumn4);

                    this.textColumn5.Header = "Начало предоставления";
                    this.textColumn5.Binding = new Binding("SPackageStartDate");
                    dg_Table.Columns.Add(this.textColumn5);

                    this.textColumn6.Header = "Конец предоставления";
                    this.textColumn6.Binding = new Binding("SPackageEndDate");
                    dg_Table.Columns.Add(this.textColumn6);

                    break;
            }
        }

        //Разблокировка кнопок если выбран пакет услуг в таблице ServicePackage
        private void dg_Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (tName == "ServicePackage")
            {
                btn_Edit.IsEnabled = true;
                btn_Delete.IsEnabled = true;
            }
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            ServicePackage_AddOrEdit tableDisplay = new ServicePackage_AddOrEdit();
            tableDisplay.ShowDialog();

            //обновление таблицы
            var servicePackage = bd.ServicePackage.ToList(); //обращаемся к таблице ServicePackage
            dg_Table.ItemsSource = servicePackage; //передаем таблицу Request в DataGrid

        }

        private void Button_ClickEdit(object sender, RoutedEventArgs e)
        {
            ServicePackage_AddOrEdit tableDisplay = new ServicePackage_AddOrEdit(dg_Table.SelectedItem as Model.ServicePackage);
            tableDisplay.ShowDialog();

            //обновление таблицы
            var servicePackage = bd.ServicePackage.ToList(); //обращаемся к таблице ServicePackage
            dg_Table.ItemsSource = servicePackage; //передаем таблицу Request в DataGrid

            btn_Edit.IsEnabled = false;
            btn_Delete.IsEnabled = false;
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            Helper.DeleteSPackage(dg_Table.SelectedItem as Model.ServicePackage);

            //обновление таблицы
            var servicePackage = bd.ServicePackage.ToList(); //обращаемся к таблице ServicePackage
            dg_Table.ItemsSource = servicePackage; //передаем таблицу Request в DataGrid

            btn_Edit.IsEnabled = false;
            btn_Delete.IsEnabled = false;
        }
    }
}
