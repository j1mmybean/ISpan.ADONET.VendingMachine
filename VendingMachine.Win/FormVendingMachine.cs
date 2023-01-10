using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VendingMachine.Win.FormVendingMachine;

namespace VendingMachine.Win
{
	public partial class FormVendingMachine : Form
	{
		/// <summary>
		/// 商品為五十元之販賣機
		/// 投幣大於零元可退幣，大於五十元可出貨
		/// </summary>
		
		private static readonly int productPrice = 50;
		VendingMachine vendingMachine = new VendingMachine(productPrice);

		//初始狀態販賣機內為零元，不可退幣及出貨
		public FormVendingMachine()
		{
			InitializeComponent();

			buttonProductOut.Enabled = false;
			buttonCoinOut.Enabled = false;
			textBoxCoinInMachine.Text = $"已投入{vendingMachine.CoinInMachine}元";
		}

		//判斷可否退幣及出貨和顯示餘額
		void Display()
		{
			textBoxCoinInMachine.Text = $"已投入{vendingMachine.CoinInMachine}元";

			vendingMachine.IsEnough();
			//投幣大於零元可退幣
			buttonCoinOut.Enabled = vendingMachine.CoinOutIsAllow;

			//投幣大於五十元可出貨
			buttonProductOut.Enabled = vendingMachine.ProductOutIsAllow;
		}

		private void buttonCoinOut_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"退幣{vendingMachine.CoinInMachine}元");
			vendingMachine.CoinOut();//退幣,餘額歸零
			Display();
		}

		private void buttonProductOut_Click(object sender, EventArgs e)
		{
			vendingMachine.ProductOut();//出貨,餘額減去商品價格
			MessageBox.Show("出貨，獲得一商品");
			Display();
		}

		private void buttonPutCoinIn_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBoxPutCoinIn.Text, out int coins) && coins > 0)
				vendingMachine.PutCoinsIn(coins);//投幣,餘額加上投入金額

			else MessageBox.Show("請輸入正整數金額。");

			Display();
		}

		public class VendingMachine
		{
			private readonly int productPrice;

			private int _coinInMachine = 0;
			private bool _coinOutIsAllow = false;
			private bool _productOutIsAllow = false;

			public int CoinInMachine { get => _coinInMachine; set => _coinInMachine = value; }
			public bool CoinOutIsAllow { get => _coinOutIsAllow; set => _coinOutIsAllow = value; }
			public bool ProductOutIsAllow { get => _productOutIsAllow; set => _productOutIsAllow = value; }

			public VendingMachine(int productPrice)
			{
				this.productPrice = productPrice;
			}

			public void ProductOut()
			{
				CoinInMachine -= productPrice;//出貨,餘額減去商品價格
			}

			public void PutCoinsIn(int coins)
			{
				CoinInMachine += coins;//投幣,餘額加上投入金額
			}

			public void CoinOut()
			{
				CoinInMachine = 0;//退幣,餘額歸零
			}

			public void IsEnough()
			{
				//投幣大於零元可退幣
				CoinOutIsAllow = CoinInMachine > 0;

				//投幣大於五十元可出貨
				ProductOutIsAllow = CoinInMachine >= productPrice;
			}
		}

	}
}
