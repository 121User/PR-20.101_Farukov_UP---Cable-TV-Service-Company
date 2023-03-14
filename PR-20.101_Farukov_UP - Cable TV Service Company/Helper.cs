using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_20._101_Farukov_UP___Cable_TV_Service_Company
{
	public class Helper
	{
		private static Model.CompanyBaseEntities DBEntities;
		public static Model.CompanyBaseEntities getContex()
		{
			if (DBEntities == null)
			{
				DBEntities = new Model.CompanyBaseEntities();
			}
			return DBEntities;
		}

		//Получение следующего индекса в таблице ServicePackage
		public static int GetSPackageLastID()
		{
			int id = 0;

			try
			{
				id = DBEntities.ServicePackage.OrderByDescending(sPackage => sPackage.SPackageID).First().SPackageID;
				return id + 1;
			}
			catch (InvalidOperationException)
			{
				id = 0;
				return id + 1;
			}
		}

		//Добавление пакета услуг
		public static void AddSPackage(Model.ServicePackage servicePackage)
		{
			DBEntities.ServicePackage.Add(servicePackage);
			DBEntities.SaveChanges();
			MessageBox.Show("Пакет услуг сохранен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		//Изменение пакета услуг
		public static void EditSPackage(Model.ServicePackage oldPackage, Model.ServicePackage newPackage)
		{
			DBEntities.ServicePackage.Remove(oldPackage);
			DBEntities.SaveChanges();

			DBEntities.ServicePackage.Add(newPackage);
			DBEntities.SaveChanges();
			MessageBox.Show("Пакет услуг изменен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Удаление пакета услуг
		public static void DeleteSPackage(Model.ServicePackage servicePackage)
		{
			DialogResult result = MessageBox.Show("Вы действительно хотите удалить пакет услуг?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
            {
				DBEntities.ServicePackage.Remove(servicePackage);
				DBEntities.SaveChanges();
			}
		}
	}
}