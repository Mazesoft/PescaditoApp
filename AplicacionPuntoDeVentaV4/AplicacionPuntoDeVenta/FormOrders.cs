using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPuntoDeVenta
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        static int ActualIdOrder;
        static int OrderNum;
        static FormOrders FormOrder;
        static bool AuxPay;
        static List<OrderDetail> AuxPartial = new List<OrderDetail>();

        public static bool pay
        {
            get { return AuxPay; }
            set { AuxPay = value; }
        }

        public static List<OrderDetail> partial
        {
            get { return AuxPartial; }
            set { AuxPartial = value; }
        }

        public static int ordernum
        {
            get { return ActualIdOrder; }
            set { ActualIdOrder = value; }
        }

        public static FormOrders formorder
        {
            get { return FormOrder; }
            set { FormOrder = value; }
        }
        

        LINQ objLINQ = new LINQ();
        List<Menu> listComidas = new List<Menu>();
        List<Menu> listBebidas = new List<Menu>();

        Order NewOrder;
        List<OrderDetail> listOrderDetails = new List<OrderDetail>();
        List<Control> ctrls;

        public void Form1_Load(object sender, EventArgs e)
        {
            //AuxPay = true;

            if (ctrls != null)
            {
                panelOrder.Controls.Clear();

                for (int j = 0; j < ctrls.Count; j++)
                {
                    panelOrder.Controls.Add(ctrls[j]);
                }
            }
            FormOrder = this;

            if (ActualIdOrder != 0)
            {
                //MessageBox.Show(OrderNum.ToString());

                //OrderNum = objLINQ.GetNextOrderNum();

                NewOrder = objLINQ.SelectOrder(ActualIdOrder);
            }
            else
            {
                NewOrder = objLINQ.SelectUnsaved();

                if (NewOrder == null)
                {
                    NewOrder = objLINQ.SelectOrder(objLINQ.CreateOrder());
                }
            }
            OrderNum = (int)NewOrder.OrderNum;
            ActualIdOrder = NewOrder.IdOrder;

            //lblOrderNum.Text = "Orden: " + objLINQ.GetOrderNum(OrderNum).ToString("0000");
            lblOrderNum.Text = "Orden: " + (OrderNum).ToString("0000");

            ctrls = new List<Control>();
            foreach (Control c in panelOrder.Controls)
            {
                ctrls.Add(c);
            }

            //NewOrder = objLINQ.SelectOrder(OrderNum);
            listOrderDetails = objLINQ.SelectOrderDetails(NewOrder.IdOrder);
            //objLINQ.CreateOrder();

            double amount = 0;
            int zeros = 0;
            for (int i = 0; i < listOrderDetails.Count; i++)
            {
                int contParcial = 0;
                for (int j = 0; j < AuxPartial.Count; j++)
                {
                    if (AuxPartial[j].IdOrderDetail == listOrderDetails[i].IdOrderDetail)
                        contParcial = AuxPartial[j].Qty;
                }

                if (listOrderDetails[i].Qty - contParcial > 0)
                {
                    Button button2 = new Button();
                    button2.Name = listOrderDetails[i].IdOrderDetail.ToString();
                    //button2.Text = "1x  |  Tacotote";
                    button2.Text = (listOrderDetails[i].Qty - contParcial) + "x  |  " + objLINQ.GetMenuName(listOrderDetails[i].IdMenu);
                    button2.Left = 20;
                    button2.Top = 50 + ((i - zeros) * 35);
                    button2.Width = 240;
                    button2.Height = 30;
                    button2.Font = new Font("Arial", 12, FontStyle.Regular);
                    button2.TextAlign = ContentAlignment.MiddleLeft;
                    button2.Click += new EventHandler(button_Click);
                    panelOrder.Controls.Add(button2);

                    Button button3 = new Button();
                    button3.Name = listOrderDetails[i].IdOrderDetail.ToString();
                    button3.Text = "X";
                    button3.Left = 260;
                    button3.Top = 50 + ((i - zeros) * 35);
                    button3.Width = 35;
                    button3.Height = 30;
                    button3.Font = new Font("Arial", 12, FontStyle.Bold);
                    button3.ForeColor = Color.White;
                    button3.BackColor = Color.FromArgb(217, 83, 79);
                    button3.Click += new EventHandler(button_Click);
                    panelOrder.Controls.Add(button3);

                    amount += Convert.ToDouble(listOrderDetails[i].Amount);
                }
                else
                {
                    zeros++;
                }
            }

            int ordersHeight = 35 * (listOrderDetails.Count - zeros);

            if (AuxPay != true)
            {

                lblDivision.Location = new Point(-3, 60 + ordersHeight);

                Label label = new Label();
                label.Text = "Total";
                label.Left = 20;
                label.Top = 90 + ordersHeight;
                label.Width = 50;
                label.Font = new Font("Arial", 12, FontStyle.Regular);
                panelOrder.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = "$ " + amount.ToString("N");
                label2.Left = 70;
                label2.Top = 85 + ordersHeight;
                label2.Font = new Font("Arial", 16, FontStyle.Regular);
                panelOrder.Controls.Add(label2);


                Button btnFinish = new Button();
                btnFinish.Name = "Save";
                btnFinish.Text = "Guardar Orden";
                btnFinish.Left = 20;
                btnFinish.Top = 125 + ordersHeight;
                btnFinish.Width = 275;
                btnFinish.Height = 30;
                btnFinish.Font = new Font("Arial", 12, FontStyle.Regular);
                btnFinish.BackColor = Color.FromArgb(255, 255, 66);
                btnFinish.Click += new EventHandler(button_Click);
                panelOrder.Controls.Add(btnFinish);

                panelOrder.Height = 1 * 45 + 125 + ordersHeight;

                lblParcial.Visible = false;
                lblDivision2.Visible = false;
                lblDivision.Height = 10;
            }
            else
            {
                lblDivision.Location = new Point(-3, 60 + ordersHeight);
                lblDivision.Height = 25;

                lblParcial.Location = new Point(3, 62 + ordersHeight);
                lblParcial.Visible = true;

                amount = 0;
                for (int i = 0; i < AuxPartial.Count; i++)
                {
                    Button button2 = new Button();
                    button2.Name = AuxPartial[i].IdOrderDetail.ToString();
                    //button2.Text = "1x  |  Tacotote";
                    button2.Text = AuxPartial[i].Qty + "x  |  " + objLINQ.GetMenuName(AuxPartial[i].IdMenu);
                    button2.Left = 20;
                    button2.Top = 50 + (i * 35) + ordersHeight + 50;
                    button2.Width = 240;
                    button2.Height = 30;
                    button2.Font = new Font("Arial", 12, FontStyle.Regular);
                    button2.TextAlign = ContentAlignment.MiddleLeft;
                    button2.Click += new EventHandler(button_Click);
                    panelOrder.Controls.Add(button2);

                    Button button3 = new Button();
                    button3.Name = AuxPartial[i].IdOrderDetail.ToString();
                    button3.Text = "X";
                    button3.Left = 260;
                    button3.Top = 50 + (i * 35) + ordersHeight + 50;
                    button3.Width = 35;
                    button3.Height = 30;
                    button3.Font = new Font("Arial", 12, FontStyle.Bold);
                    button3.ForeColor = Color.White;
                    button3.BackColor = Color.FromArgb(217, 83, 79);
                    button3.Click += new EventHandler(button_Click);
                    panelOrder.Controls.Add(button3);

                    amount += Convert.ToDouble(AuxPartial[i].Amount);
                }

                lblDivision2.Location = new Point(-3, 109 + ordersHeight + (35 * AuxPartial.Count));
                lblDivision2.Visible = true;

                Label label = new Label();
                label.Text = "Pago Parcial";
                label.Left = 20;
                label.Top = 90 + ordersHeight + 49 + (35 * AuxPartial.Count);
                label.Width = 100;
                label.Font = new Font("Arial", 12, FontStyle.Regular);
                panelOrder.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = "$ " + amount.ToString("N");
                label2.Left = 125;
                label2.Top = 85 + ordersHeight + 49 + (35 * AuxPartial.Count);
                label2.Font = new Font("Arial", 16, FontStyle.Regular);
                panelOrder.Controls.Add(label2);


                Button btnFinish = new Button();
                btnFinish.Name = "Print";
                btnFinish.Text = "Imprimir Recibo";
                btnFinish.Left = 20;
                btnFinish.Top = 125 + ordersHeight + 49 + (35 * AuxPartial.Count);
                btnFinish.Width = 275;
                btnFinish.Height = 30;
                btnFinish.Font = new Font("Arial", 12, FontStyle.Regular);
                btnFinish.BackColor = Color.FromArgb(255, 255, 66);
                btnFinish.Click += new EventHandler(button_Click);
                panelOrder.Controls.Add(btnFinish);

                panelOrder.Height = 1 * 45 + 125 + ordersHeight + 49 + (35 * AuxPartial.Count);

            }


            ///////////////////////////////////////////////////////
            listComidas = objLINQ.SelectMenu(1);
            listBebidas = objLINQ.SelectMenu(2);
            int cont = 0;

            int RowsMeals = 0;
            int ColsMeals = 0;

            RowsMeals = (int)Math.Round((decimal)listComidas.Count / 2, 0, MidpointRounding.AwayFromZero);
            ColsMeals = 2;

            menuStrip1.ForeColor = Color.White;

            int RowsDrinks = (int)Math.Round((decimal)listBebidas.Count / 2, 0, MidpointRounding.AwayFromZero);
            int ColsDrinks = 2;

            for (int row = 0; row < RowsMeals; row++)
            {
                for (int column = 0; column < ColsMeals; column++)
                {
                    Button button = new Button();
                    button.Name = listComidas[cont].IdMenu.ToString();
                    button.Text = listComidas[cont].Description.ToString();
                    button.Left = 20 + column * 145;
                    button.Top = 50 + row * 45;
                    button.Width = 130;
                    button.Height = 30;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += new EventHandler(button_Click);
                    panelMeals.Controls.Add(button);

                    cont++;
                    if (cont == listComidas.Count) break;
                }
                if (cont == listComidas.Count) break;
            }

            panelMeals.Height = RowsMeals * 45 + 50;
            panelDrinks.Top = RowsMeals * 45 + 50 + 50;

            cont = 0;

            for (int row = 0; row < RowsDrinks; row++)
            {
                for (int column = 0; column < ColsDrinks; column++)
                {
                    Button button = new Button();
                    button.Name = listBebidas[cont].IdMenu.ToString();
                    button.Text = listBebidas[cont].Description.ToString();
                    button.Left = 20 + column * 145;
                    button.Top = 50 + row * 45;
                    button.Width = 130;
                    button.Height = 30;
                    button.Font = new Font("Arial", 12, FontStyle.Regular);
                    button.Click += new EventHandler(button_Click);
                    panelDrinks.Controls.Add(button);

                    cont++;
                    if (cont == listBebidas.Count) break;
                }
                if (cont == listBebidas.Count) break;
            }

            panelDrinks.Height = RowsDrinks * 45 + 50;
        }

        private void button_Click(object sender, EventArgs e)
        {
            //
            Button button = sender as Button;

            if (button.Text == "Guardar Orden")
            {
                objLINQ.UpdateOrderStatus(ActualIdOrder, true);
                objLINQ.CreateOrder();
                ActualIdOrder = 0;
                FormOrders.formorder.Form1_Load(null, null);
            }

            if (button.Text.Contains("|"))
            {
                if (AuxPay == true)
                {
                    bool found = false;
                    for (int i = 0; i < FormOrders.partial.Count; i++)
                    {
                        OrderDetail ord = objLINQ.SelectMenuOrderDetailbyId(Convert.ToInt32(button.Name));

                        if (FormOrders.partial[i].IdMenu == ord.IdMenu)
                        {
                            FormOrders.partial[i].Amount = (FormOrders.partial[i].Amount / FormOrders.partial[i].Qty) * (FormOrders.partial[i].Qty + 1);
                            FormOrders.partial[i].Qty++;
                            found = true;
                        }
                    }

                    if (found == false)
                    {
                        OrderDetail neworder = objLINQ.SelectMenuOrderDetailbyId(Convert.ToInt32(button.Name));
                        FormOrders.partial.Add(new OrderDetail
                        {
                            IdOrderDetail = neworder.IdOrderDetail,
                            IdMenu = neworder.IdMenu,
                            Qty = 1,
                            Amount = neworder.Amount / neworder.Qty
                        });
                    }
                    Form1_Load(null, null);
                }
            }
            else
            {
                if (button.Text == "X")
                {
                    OrderDetail orderdet = objLINQ.SelectMenuOrderDetailbyId(Convert.ToInt32(button.Name));

                    objLINQ.UpdateOrderDetail(
                                    new OrderDetail
                                    {
                                        IdOrderDetail = orderdet.IdOrderDetail,
                                        IdOrder = NewOrder.IdOrder,
                                        IdMenu = orderdet.IdMenu,
                                        Qty = orderdet.Qty,
                                        Amount = orderdet.Amount
                                    }, false);



                    Form1_Load(null, null);
                }
                else
                {
                    for (int i = 0; i < listComidas.Count; i++)
                    {
                        if (listComidas[i].IdMenu.ToString() == button.Name)
                        {
                            OrderDetail orderdet = objLINQ.SelectMenuOrderDetails(NewOrder.IdOrder, listComidas[i].IdMenu);

                            if (orderdet == null)
                            {
                                objLINQ.InsertOrderDetail(
                                    new OrderDetail
                                    {
                                        IdOrder = NewOrder.IdOrder,
                                        IdMenu = listComidas[i].IdMenu,
                                        Qty = 1,
                                        Amount = listComidas[i].UnitPrice
                                    });
                            }
                            else
                            {
                                objLINQ.UpdateOrderDetail(
                                    new OrderDetail
                                    {
                                        IdOrderDetail = orderdet.IdOrderDetail,
                                        IdOrder = NewOrder.IdOrder,
                                        IdMenu = orderdet.IdMenu,
                                        Qty = orderdet.Qty,
                                        Amount = orderdet.Amount
                                    }, true);
                            }



                            Form1_Load(null, null);
                        }
                    }
                }
            }
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormActiveOrders frm = new FormActiveOrders();
            frm.ShowDialog();
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInventory frm = new FormInventory();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUsers frm = new FormUsers();
            frm.Show();
        }
    }
}
