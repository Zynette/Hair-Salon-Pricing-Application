/*
 * Name: Antonette Petallo
 * Student Number: 000900501
 * Date: November 2024
 * 
 * Purpose: By letting users choose a hairdresser and many services,
 *          this windows form application calculates the cost of hair salon services.
 *          It subsequently computes the overall cost and manages form reset functionality.
 * 
 * Statement of Authorship: I, Antonette Petallo, 000900501 certify that this material is my original work.
 *                          No other person's work has been used without due acknowledgement.
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

namespace Lab3B
{
    /// <summary>
    /// The main for for the hair salon pricing application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes the form and sets up everything to start.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Resets the form to its original state, clearing all selections and totals.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all controls so the user can start fresh.
            cmbHairdresser.SelectedIndex = 0;
            cmbHairdresser.Enabled = true;
            lstServices.ClearSelected();
            lstChargedItems.Items.Clear();
            lstPrices.Items.Clear();
            txtTotalPrice.Text = "$0.00"; //Reset the total price display.
            btnAddService.Enabled = false;
            btnCalculateTotal.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Adds the chosen hairdresser and services to the list of charged items
        /// and displays their corresponding prices.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddService_Click(object sender, EventArgs e)
        {
            // Disable Hairdresser ComboBox after first selection
            if (lstChargedItems.Items.Count == 0)
            {
                lstChargedItems.Items.Add(cmbHairdresser.SelectedItem.ToString());
                lstPrices.Items.Add(GetHairdresserPrice(cmbHairdresser.SelectedItem.ToString()));
                cmbHairdresser.Enabled = false;
            }

            // Add selected service(s)
            foreach (var service in lstServices.SelectedItems)
            {
                lstChargedItems.Items.Add(service.ToString());
                lstPrices.Items.Add(GetServicePrice(service.ToString()));
            }

            // Enable Calculate Button
            btnCalculateTotal.Enabled = true;
            lstServices.ClearSelected();
        }
        /// <summary>
        /// Returns the price for the selected hairdresser as a formatted string.
        /// </summary>
        /// <param name="hairdresser">The selected hairdresser's name.</param>
        /// <returns>The price in a string format.</returns>
        private string GetHairdresserPrice(string hairdresser)
        {
            //Return the correct price for each hairdresser.
            switch (hairdresser)
            {
                case "Jane Samley": return "$30.00";
                case "Pat Johnson": return "$45.00";
                case "Ron Chambers": return "$40.00";
                case "Sue Pallon": return "$50.00";
                case "Laura Renkins": return "$55.00";
                default: return "$0.00";
            }
        }
        /// <summary>
        /// Returns the price for the selected service as a formatted string.
        /// </summary>
        /// <param name="service">The name of the selected service.</param>
        /// <returns>The price in a string format.</returns>
        private string GetServicePrice(string service)
        {
            //Return the correct price for each service.
            switch (service)
            {
                case "Cut": return "$30.00";
                case "Wash, blow-dry, and style": return "$20.00";
                case "Colour": return "$40.00";
                case "Highlights": return "$50.00";
                case "Extension": return "$200.00";
                case "Up-do": return "$60.00";
                default: return "$0.00";
            }
        }
        /// <summary>
        /// Calculates the total cost from all selected services and displays it.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            //Go through each price in the list, strip the dollar sign, and add to the total.
            foreach (var price in lstPrices.Items)
            {
                total += Convert.ToDouble(price.ToString().Substring(1));
            }
            txtTotalPrice.Text = total.ToString("C");
        }
        /// <summary>
        /// Closes the application when the Exit button is clicked.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// When a hairdresser is chosen, this method enables the services ListBox so
        /// the user can select services to add.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void cmbHairdresser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If a hairdresser is selected, allow the user to pick services.
            if (cmbHairdresser.SelectedIndex != -1)
            {
                lstServices.Enabled = true;
            }
        }
        /// <summary>
        /// When the user selects one or more services, enable the Add Service button.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">The event arguments.</param>
        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the Add Service Button when there's at least one service selected.
            if (lstServices.SelectedIndex > 0)
            {
                btnAddService.Enabled = true;

            }
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
