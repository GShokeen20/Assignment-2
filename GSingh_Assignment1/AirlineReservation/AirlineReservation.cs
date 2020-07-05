/*
 * File Name: AirlineReservation.cs
 * Assignment1 for PROG1815-20S-Sec2-Programming Concepts II
 * 
 * Revision History
 *      Garima Singh, 2020-06-14 : Created
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservation
{
    public partial class AirlineReservation : Form
    {
        
        RadioButton activeSeat = null;//

        // 2-D array for booking seats list
        string[,] data = new string[,] {
                                    {"1A",""}, {"1B",""}, {"1C",""}, {"1D",""},
                                    {"2A",""}, {"2B",""}, {"2C",""}, {"2D",""},
                                    {"3A",""}, {"3B",""}, {"3C",""}, {"3D",""},
                                    {"4A",""}, {"4B",""}, {"4C",""}, {"4D",""},
                                    {"5A",""}, {"5B",""}, {"5C",""}, {"5D",""}
                                       };
        
        // 1-D array for Waiting list (cannot be more than 10 passengers)
        string[] waitingList = new string[10] {
                                                    "","","","","","","","","",""
                                              };
        //Variable used for incrementing names in 1-D array
        int waitingListIncrement = 1;
        public AirlineReservation()
        {
            InitializeComponent();
        }

        private void rdb_Click(object sender, EventArgs e)
        {
            //sender parameter saved in a RadioButton class variable
            activeSeat = (RadioButton)sender;//
        }

        private void btn_BookClick(object sender, EventArgs e)
        {
            //If no seat is selected
            if (activeSeat == null)
            {
                lblSystemMessages.Text = "ERROR: Please select a seat";
            }

            //If no name is written in the "txtName" text box
            else if (txtName.Text == "")
            {
                lblSystemMessages.Text = "ERROR: Please enter a name for the selected seat";
            }

            //If no issue is found i.e. seat is also selected and "txtName" text box also has a name written inside it
            else if (activeSeat != null && txtName != null)
            {

                if (rdb00.Checked == true)
                {

                    if (rdb00.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "1A")
                                {
                                    j++;

                                    //data.SetValue(txtName.Text, 0, 0);
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        //data[0, 0] = txtName.Text;
                        rdb00.BackColor = Color.Red;
                        rdb00.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                else if (rdb01.Checked == true)
                {

                    if (rdb01.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "1B")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb01.BackColor = Color.Red;
                        rdb01.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                else if (rdb02.Checked == true)
                {

                    if (rdb02.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "1C")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb02.BackColor = Color.Red;
                        rdb02.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                else if (rdb03.Checked == true)
                {

                    if (rdb03.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "1D")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb03.BackColor = Color.Red;
                        rdb03.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb10.Checked == true)
                {

                    if (rdb10.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "2A")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb10.BackColor = Color.Red;
                        rdb10.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb11.Checked == true)
                {

                    if (rdb11.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "2B")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb11.BackColor = Color.Red;
                        rdb11.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb12.Checked == true)
                {

                    if (rdb12.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "2C")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb12.BackColor = Color.Red;
                        rdb12.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb13.Checked == true)
                {

                    if (rdb13.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "2D")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb13.BackColor = Color.Red;
                        rdb13.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb20.Checked == true)
                {

                    if (rdb20.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "3A")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb20.BackColor = Color.Red;
                        rdb20.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb21.Checked == true)
                {

                    if (rdb21.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "3B")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb21.BackColor = Color.Red;
                        rdb21.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb22.Checked == true)
                {

                    if (rdb22.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "3C")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb22.BackColor = Color.Red;
                        rdb22.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
                if (rdb23.Checked == true)
                {

                    if (rdb23.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "3D")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb23.BackColor = Color.Red;
                        rdb23.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb30.Checked == true)
                {

                    if (rdb30.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "4A")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb30.BackColor = Color.Red;
                        rdb30.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb31.Checked == true)
                {

                    if (rdb31.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "4B")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb31.BackColor = Color.Red;
                        rdb31.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb32.Checked == true)
                {

                    if (rdb32.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "4C")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb32.BackColor = Color.Red;
                        rdb32.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb33.Checked == true)
                {

                    if (rdb33.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "4D")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb33.BackColor = Color.Red;
                        rdb33.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb40.Checked == true)
                {

                    if (rdb40.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "5A")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb40.BackColor = Color.Red;
                        rdb40.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb41.Checked == true)
                {

                    if (rdb41.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "5B")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb41.BackColor = Color.Red;
                        rdb41.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb42.Checked == true)
                {

                    if (rdb42.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "5C")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb42.BackColor = Color.Red;
                        rdb42.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }

                if (rdb43.Checked == true)
                {

                    if (rdb43.BackColor == Color.Red)
                    {
                        lblSystemMessages.Text = "ERROR: This seat is already booked";
                    }

                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (data[i, j] == "5D")
                                {
                                    j++;
                                    data[i, j] = txtName.Text;
                                }
                            }
                        }
                        lblSystemMessages.Text = "SUCCESS: Seat Booked!";
                        rdb43.BackColor = Color.Red;
                        rdb43.Checked = false;
                        txtName.Clear();
                        activeSeat = null;
                    }

                }
            }
        }

        //To cancel the filled seats and change seat color back to "SystemColors.Controls" i.e. gray
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (activeSeat != null)
            {

                if (rdb00.BackColor == Color.Red && rdb00.Checked == true)
                {
                    rdb00.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "1A")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb00.Checked = false;
                }

                else if (rdb01.BackColor == Color.Red && rdb01.Checked == true)
                {
                    rdb01.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "1B")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb01.Checked = false;
                }

                else if (rdb02.BackColor == Color.Red && rdb02.Checked == true)
                {
                    rdb02.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "1C")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb02.Checked = false;
                }

                else if (rdb03.BackColor == Color.Red && rdb03.Checked == true)
                {
                    rdb03.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "1D")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb03.Checked = false;
                }

                else if (rdb10.BackColor == Color.Red && rdb10.Checked == true)
                {
                    rdb10.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "2A")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb10.Checked = false;
                }

                else if (rdb11.BackColor == Color.Red && rdb11.Checked == true)
                {
                    rdb11.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "2B")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb11.Checked = false;
                }

                else if (rdb12.BackColor == Color.Red && rdb12.Checked == true)
                {
                    rdb12.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "2C")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb12.Checked = false;
                }

                else if (rdb13.BackColor == Color.Red && rdb13.Checked == true)
                {
                    rdb13.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "2D")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb13.Checked = false;
                }

                else if (rdb20.BackColor == Color.Red && rdb20.Checked == true)
                {
                    rdb20.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "3A")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb20.Checked = false;
                }

                else if (rdb21.BackColor == Color.Red && rdb21.Checked == true)
                {
                    rdb21.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "3B")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb21.Checked = false;
                }

                else if (rdb22.BackColor == Color.Red && rdb22.Checked == true)
                {
                    rdb22.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "3C")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb22.Checked = false;
                }

                else if (rdb23.BackColor == Color.Red && rdb23.Checked == true)
                {
                    rdb23.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "3D")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb23.Checked = false;
                }

                else if (rdb30.BackColor == Color.Red && rdb30.Checked == true)
                {
                    rdb30.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "4A")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb30.Checked = false;
                }

                else if (rdb31.BackColor == Color.Red && rdb31.Checked == true)
                {
                    rdb31.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "4B")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb31.Checked = false;
                }

                else if (rdb32.BackColor == Color.Red && rdb32.Checked == true)
                {
                    rdb32.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "4C")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb32.Checked = false;
                }

                else if (rdb33.BackColor == Color.Red && rdb33.Checked == true)
                {
                    rdb33.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "4D")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb33.Checked = false;
                }

                else if (rdb40.BackColor == Color.Red && rdb40.Checked == true)
                {
                    rdb40.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "5A")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb40.Checked = false;
                }

                else if (rdb41.BackColor == Color.Red && rdb41.Checked == true)
                {
                    rdb41.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "5B")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb41.Checked = false;
                }

                else if (rdb42.BackColor == Color.Red && rdb42.Checked == true)
                {
                    rdb42.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "5C")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb42.Checked = false;
                }
                else if (rdb43.BackColor == Color.Red && rdb43.Checked == true)
                {
                    rdb43.BackColor = SystemColors.Control;
                    lblSystemMessages.Text = "SUCCESS: Reservation Cancelled";
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (data[i, j] == "5D")
                            {
                                j++;
                                data[i, j] = "";
                            }
                        }
                    }
                    rdb43.Checked = false;
                }
                else
                {
                    lblSystemMessages.Text = "ERROR: Seat's already empty";
                }
            }
        }

        //To show all seats whether full or empty
        private void btn_ShowAllSeatsClick(object sender, EventArgs e)
        {
            //To clear all the previous data
            txtShowAllSeats.Text = "";

            //To print new data
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        txtShowAllSeats.Text += data[i, j] + " - ";
                    }
                    else if (j == 1)
                    {
                        txtShowAllSeats.Text += data[i, j] + Environment.NewLine;
                    }
                }
            }
        }

        //To fill all seats (Debug button)
        private void btnFillAllSeats_Click(object sender, EventArgs e)
        {
            rdb00.BackColor = Color.Red;
            rdb01.BackColor = Color.Red;
            rdb02.BackColor = Color.Red;
            rdb03.BackColor = Color.Red;
            rdb10.BackColor = Color.Red;
            rdb11.BackColor = Color.Red;
            rdb12.BackColor = Color.Red;
            rdb13.BackColor = Color.Red;
            rdb20.BackColor = Color.Red;
            rdb21.BackColor = Color.Red;
            rdb22.BackColor = Color.Red;
            rdb23.BackColor = Color.Red;
            rdb30.BackColor = Color.Red;
            rdb31.BackColor = Color.Red;
            rdb32.BackColor = Color.Red;
            rdb33.BackColor = Color.Red;
            rdb40.BackColor = Color.Red;
            rdb41.BackColor = Color.Red;
            rdb42.BackColor = Color.Red;
            rdb43.BackColor = Color.Red;

            // 2-D array for filling all seats
            data = new string[,] {
                                    {"1A","Abraham"}, {"1B","Gandhi"}, {"1C","Nehru"}, {"1D","Jinnah"},
                                    {"2A","John"}, {"2B","Roosevelt"}, {"2C","Bush"}, {"2D","Clinton"},
                                    {"3A","Subhash"}, {"3B","Ford"}, {"3C","Harding"}, {"3D","DeWolfe"},
                                    {"4A","Kasturba"}, {"4B","Mountbatten"}, {"4C","Mountbatten"}, {"4D","Tagore"},
                                    {"5A","Leo Tolstoy"}, {"5B","Abul Kalam Azad"}, {"5C","Ghaffar Khan"}, {"5D","Akbar"}
                                 };
        }

        //To add people to waiting list
        private void btn_AddToWaitingListClick(object sender, EventArgs e)
        {

            //If all seats are already red, then only passengers will be added to waiting list
            if (rdb00.BackColor == Color.Red &&
                rdb01.BackColor == Color.Red &&
                rdb02.BackColor == Color.Red &&
                rdb03.BackColor == Color.Red &&
                rdb10.BackColor == Color.Red &&
                rdb11.BackColor == Color.Red &&
                rdb12.BackColor == Color.Red &&
                rdb13.BackColor == Color.Red &&
                rdb20.BackColor == Color.Red &&
                rdb21.BackColor == Color.Red &&
                rdb22.BackColor == Color.Red &&
                rdb23.BackColor == Color.Red &&
                rdb30.BackColor == Color.Red &&
                rdb31.BackColor == Color.Red &&
                rdb32.BackColor == Color.Red &&
                rdb33.BackColor == Color.Red &&
                rdb40.BackColor == Color.Red &&
                rdb41.BackColor == Color.Red &&
                rdb42.BackColor == Color.Red &&
                rdb43.BackColor == Color.Red)
            {
                if (txtName.Text == "")
                {
                    lblSystemMessages.Text = "ERROR: Please enter a name to add to waiting list";
                }

                else
                {

                    for (int i = waitingListIncrement - 1; i < waitingListIncrement; i++)
                    {
                        
                        if (waitingListIncrement >= 11)
                        {
                            lblSystemMessages.Text = "ERROR: More passengers cannot be added to waiting list";
                            break;
                        }

                        if (txtName.Text != "")
                        {
                            waitingList[i] = txtName.Text;
                        }

                        lblSystemMessages.Text = "SUCCESS: Passenger added to waiting list";
                    }                    
                    txtName.Clear();

                }
                waitingListIncrement++;

            }

            //Even if a single seat is empty
            else
            {
                lblSystemMessages.Text = "ERROR: There are seats still available";
            }
        }

        //To show all people in the waiting list
        private void btnShowWaitingList_Click(object sender, EventArgs e)
        {
            //To clear all the previous data
            txtShowWaitingList.Text = "";

            //To print new data
            for (int i = 0; i < waitingList.Length; i++)
            {
                txtShowWaitingList.Text += waitingList[i] + Environment.NewLine;
            }
        }

    }
}