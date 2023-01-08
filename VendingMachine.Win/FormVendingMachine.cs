using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.Win
{
	public partial class FormVendingMachine : Form
	{
		/// <summary>
		/// 商品為五十元之販賣機
		/// 投幣大於零元可退幣，大於五十元可出貨
		/// </summary>
		private readonly int productPrice = 50;
		private int coinInMachine = 0;

		//初始狀態販賣機內為零元，不可退幣及出貨
		public FormVendingMachine()
		{
			InitializeComponent();
			buttonProductOut.Enabled = false;
			buttonCoinOut.Enabled = false;
			textBoxCoinInMachine.Text = $"已投入{coinInMachine}元";
		}

		//判斷可否退幣及出貨和顯示餘額
		void Display()
		{
			textBoxCoinInMachine.Text = $"已投入{coinInMachine}元";

			//投幣大於零元可退幣
			buttonCoinOut.Enabled = coinInMachine > 0 ? true : false;

			//投幣大於五十元可出貨
			buttonProductOut.Enabled = coinInMachine >= productPrice ? true : false;
		}

		private void buttonCoinOut_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"退幣{coinInMachine}元");
			coinInMachine = 0;//退幣,餘額歸零
			Display();
		}

		private void buttonProductOut_Click(object sender, EventArgs e)
		{
			coinInMachine -= productPrice;//出貨,餘額減去商品價格
			MessageBox.Show("出貨，獲得一商品");
			Display();
		}

		private void buttonPutCoinIn_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBoxPutCoinIn.Text, out int coin) && coin > 0)
				coinInMachine += coin;//投幣,餘額加上投入金額

			else MessageBox.Show("請輸入正整數金額。");

			Display();
		}

		public class VendingMachine
		{

		}

	}
}
