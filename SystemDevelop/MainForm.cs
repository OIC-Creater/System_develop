﻿using System;
using System.Windows.Forms;
using SystemDevelop.DataModels;
using SystemDevelop.Model;
using SystemDevelop.Model.DB;

namespace SystemDevelop
{
    public partial class MainForm : Form
    {
        private bool logined = false;
        private Employee employee;

        public MainForm()
        {
            InitializeComponent();
            
            loginControl.loginButton.Click += LoginButtonClick;
            loginControl.idTextBox.KeyDown += OnEnter;
            loginControl.passTextBox.KeyDown += OnEnter;
            headerControl.logoutButton.Click += LogoutButtonClick;
            headerControl.closeButton.Click += CloseButton_Click1;
            salesMenuBar.reciveAddButton.Click += ReciveButtonClick;
            salesMenuBar.reciveAddButton.Click += ReciveButtonClick;
            salesMenuBar.reciveListButton.Click += ReciveDetail_Click;
            salesMenuBar.pigeonButton.Click += Pigeon_Click;
            warehouseMenuBar.reciveListButton.Click += ReciveListButtonClick;
            warehouseMenuBar.orderListButton.Click += OrderAnButtonClick;
            warehouseMenuBar.stockListButton.Click += StockButtonClick;
            mainOfficeManuBar.employeeListButton.Click += EmployeeList_Click;
            mainOfficeManuBar.businessOfficeListButton.Click += salesOfficeList_Click;
            mainOfficeManuBar.shopListButton.Click += ShopList_Click;
            mainOfficeManuBar.manufacturerListButton.Click += ManufacturerList_Click1;
            mainOfficeManuBar.productListButton.Click += ProductListButton_Click;
            newProduct.productButton.Click += SettingButton_Click;
            settingConfi.Yes.Click += Yes_Click;
            settingConfi.No.Click += No_Click;
            loginControl.closeButton.Click += CloseButton_Click;
            empList.empDetailButton.Click += EmpDetailButton_Click;
            empList.empListAddButton.Click += EmpListAddButton_Click;
            empDetails.empCancelButton.Click += EmpCancel_Click;
            manufactureList.manufDetailButton.Click += ManufDetailButton_Click;
            manufactureDetails.manufCancelButton.Click += ManufCancel_Click;
            shopList.shopDetailButton.Click += ShopDetailButton_Click;
            shopDetails.shopCancelButton.Click += ShopCancelButton_Click;
            salesOfficeList.salesOfficeDetailButton.Click += SalesOfficeDetailButton_Click;
            salesOfficeDetails.salesOfficeCancelButton.Click += SalesOfficeCancelButton_Click;
            productList.productDetailButton.Click += ProductDetailButton_Click;
            productDetails.productCancelButton.Click += ProductCancelButton_Click;
            reciveControl.reciveDetailButton.Click += ReciveDetailButton_Click;
            reciveListDetails.reciveCancelButton.Click += ReciveCancelButton_Click;
            pigeonList.pigeonDetailButton.Click += PigeonDetailButton_Click;
            pigeonDetails.pigeonCancelButton.Click += PigeonCancelButton_Click;
            orderControl.orderDetailsButton.Click += OrderDetailsButton_Click;
            orderDetail.orderCancelButton.Click += OrderCancelButton_Click;
            stockList.stockDetailButton.Click += StockDetailButton_Click;
            empAddControl.empAddButton.Click += EmpAddButton_Click;
        }

        private void EmpAddButton_Click(object sender, EventArgs e)
        {
            empAddControl.Visible = false;
            empList.Visible = true;
            headerLists.Visible = true;
        }

        private void EmpListAddButton_Click(object sender, EventArgs e)
        {
            empAddControl.Visible = true;
            empList.Visible = false;
            headerLists.Visible = false;
        }

        private void StockDetailButton_Click(object sender, EventArgs e)
        {
            stockDetail.Visible = true;
            headerLists.Visible = false;
            stockList.Visible = false;
            reciveControl.Visible = false;
            orderControl.Visible = false;
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            orderDetail.Visible = false;
            headerLists.Visible = false;
        }

        private void OrderDetailsButton_Click(object sender, EventArgs e)
        {
            orderDetail.Visible = true;
            orderControl.Visible = false;
            headerLists.Visible = false;
            reciveControl.Visible = false;
            stockList.Visible = false;

        }

        private void PigeonCancelButton_Click(object sender, EventArgs e)
        {
            pigeonDetails.Visible = false;
            headerLists.Visible = false;
        }

        private void PigeonDetailButton_Click(object sender, EventArgs e)
        {
            pigeonDetails.Visible = true;
            pigeonList.Visible = false;
            headerLists.Visible = false;
        }

        private void ReciveCancelButton_Click(object sender, EventArgs e)
        {
            reciveListDetails.Visible = false;
            headerLists.Visible = false;
        }

        private void ReciveDetailButton_Click(object sender, EventArgs e)
        {
            reciveListDetails.Visible = true;
            reciveControl.Visible = false;
            headerLists.Visible = false;
            
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            productDetails.Visible = false;
            headerLists.Visible = false;
        }

        private void ProductDetailButton_Click(object sender, EventArgs e)
        {
            productDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }
        private void SalesOfficeCancelButton_Click(object sender, EventArgs e)
        {
            salesOfficeDetails.Visible = false;
            headerLists.Visible = false;
        }

        private void SalesOfficeDetailButton_Click(object sender, EventArgs e)
        {
            salesOfficeDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ShopCancelButton_Click(object sender, EventArgs e)
        {
            shopDetails.Visible = false;
            headerLists.Visible = false;
        }

        private void ShopDetailButton_Click(object sender, EventArgs e)
        {
            shopDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ManufCancel_Click(object sender, EventArgs e)
        {
            manufactureDetails.Visible = false;
            manufactureList.Visible = true;
            headerLists.Visible = true;
        }

        private void ManufDetailButton_Click(object sender, EventArgs e)
        {
            manufactureDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void EmpCancel_Click(object sender, EventArgs e)
        {
            empDetails.Visible = false;
            empList.Visible = true;
            headerLists.Visible = true;
        }

        private void EmpDetailButton_Click(object sender, EventArgs e)
        {
            empDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            empDetails.SetDetail(empList.GetRowData());
        }

        private void CloseButton_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = true;
        }
        private void Yes_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            orderControl.Visible = false;
            newProduct.Visible = true;
        }
        
        private void SettingButton_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = true;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            shopDetails.Visible = false;
        }
        private void ProductListButton_Click(object sender, EventArgs e)
        {
            productList.Visible = true;
            headerLists.Visible = true;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productDetails.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void NewProduct_Click(object sender, EventArgs e)
        {
            headerLists.Visible =false;
            newProduct.Visible = true;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ManufacturerList_Click1(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            manufactureList.Visible = true;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void salesOfficeList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            salesOfficeList.Visible = true;
            empList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ShopList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            shopList.Visible = true;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ManufacturerList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            salesOfficeList.Visible = true;
            empList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            empList.Visible = true;
            salesOfficeList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }
        
        private void StockButtonClick(object sender, EventArgs e)
        {
            orderControl.Visible = false;
            headerLists.Visible = true;
            stockList.Visible = true;
            warehouseControl.Visible = false;
            pigeonList.Visible = false;
            reciveControl.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
        }
        private void ReciveListButtonClick(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            reciveControl.Visible = true;
            reciveAddControl.Visible = false;
            warehouseControl.Visible = false;
            orderControl.Visible = false;
            stockList.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
        }
        private void OrderAnButtonClick(object sender,EventArgs e)
        {
            reciveAddControl.Visible = false;
            headerLists.Visible = true;
            orderControl.Visible = true;
            stockList.Visible = false;
            reciveControl.Visible = false;
            warehouseControl.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
            stockDetail.Visible = false;
        }
        private void ReciveDetail_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            reciveControl.Visible = true;
            reciveAddControl.Visible = false;
            pigeonList.Visible = false;
            unDispatched.Visible = false;
            warehouseControl.Visible = false;
        }
        private void ReciveButtonClick(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            reciveAddControl.Visible = true;
            reciveControl.Visible = false;
            pigeonList.Visible = false;
            unDispatched.Visible = false;
            stockList.Visible = false;
            warehouseControl.Visible = false;
        }
        private void Pigeon_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            pigeonList.Visible = true;
            reciveAddControl.Visible = false;
            reciveControl.Visible = false;
            unDispatched.Visible = false;
        }
        private void UnDispatched_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            unDispatched.Visible = true;
            pigeonList.Visible = false;
            reciveAddControl.Visible = false;
            reciveControl.Visible = false;
        }
        private void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        

        private void LoginButtonClick(object sender, EventArgs e)
        {
            Login();
        }
        
        private void Login()
        {
            Login login = new Login();
            if (login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text, out employee))
            {
                headerControl.userLabel.Text += $" {employee.EmployeeName}";
                logined = true;
                headerControl.Visible = true;
                switch (employee.AffiliationId)
                {
                    case "A01":
                        salesMenuBar.Visible = true;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = false;
                        mainOfficeManuBar.Visible = false;
                        reciveControl.Visible = true;
                        headerLists.Visible = true;
                        DataSource.SetDataSource<OrderDetail>(reciveControl.reciveGridView, DatabaseInstance.OrderDetailTable); 
                        DataSource.SetDataSource<Pigeon>(pigeonList.pigeonGridView, DatabaseInstance.PigeonTable);
                        break;
                    case "A02":
                        salesMenuBar.Visible = false;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = true;
                        mainOfficeManuBar.Visible = false;
                        reciveControl.Visible = true;
                        headerLists.Visible = true;
                        break;
                    case "A03":
                        mainOfficeManuBar.Visible = true;
                        salesMenuBar.Visible = false;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = false;
                        reciveControl.Visible = false;
                        headerLists.Visible = true;
                        empList.Visible = true;
                        DataSource.SetDataSource<Employee>(empList.empGridView, DatabaseInstance.EmployeeTable);
                        DataSource.SetDataSource<Maker>(manufactureList.manufGridView, DatabaseInstance.MakerTable);
                        DataSource.SetDataSource<Shop>(shopList.shopGridView, DatabaseInstance.ShopTable);
                        DataSource.SetDataSource<SalesOffice>(salesOfficeList.salesOfficeGridView, DatabaseInstance.SalesOfficeTable);
                        break;
                }
            }
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            logined = false;

            Control[] all = Controller.GetAllControls(this);
            foreach (Control c in all)
            {
                foreach (Control con in c.Controls)
                {
                    if (con.GetType().ToString().Contains("TextBox") ||
                       con.GetType().ToString().Contains("ComboBox"))
                        con.Text = "";
                }
                c.Visible = false;
            }
            headerControl.userLabel.Text = "ログイン中：";
            loginControl.Visible = true;
        }

        private void mainOfficeManuBar_Load(object sender, EventArgs e)
        {

        }
    }
}
