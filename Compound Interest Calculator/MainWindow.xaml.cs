using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Compound_Interest_Calculator {
    public partial class MainWindow: Window {

        // Define the placeholder color here
        private SolidColorBrush placeholderColor = (SolidColorBrush)new BrushConverter().ConvertFrom("#3D6734");

        public MainWindow() {
            InitializeComponent();
        }

        private void RemovePlaceholder(object sender, RoutedEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.Text == GetPlaceholderText(textBox)) {
                textBox.Text = string.Empty;
            }
        }

        private void AddPlaceholder(object sender, RoutedEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrEmpty(textBox.Text)) {
                textBox.Text = GetPlaceholderText(textBox);
                textBox.Foreground = placeholderColor; // Set placeholder color
            }
        }

        private string GetPlaceholderText(TextBox textBox) {
            return textBox.Name switch {
                "InitialDeposit" => "Initial deposit",
                "MonthlyDeposit" => "Monthly deposit",
                "AnnualInterest" => "Annual interest",
                "YearsOfInvestment" => "Years of investment",
                _ => string.Empty,
            };
        }

        private void UpdateRichTextBox(RichTextBox richTextBox, string text) {
            if (richTextBox != null) {
                richTextBox.Document.Blocks.Clear(); // Clear previous content
                richTextBox.Document.Blocks.Add(new Paragraph(new Run(text))); // Add new text
            }
        }

        // Event handler for Calculate button click
        private void CalculateButton_Click(object sender, RoutedEventArgs e) {
            double totalDeposit = TotalDeposit();
            double totalInvestment = AccumulatedInvestment();
            Profit(totalInvestment, totalDeposit);
        }

        private double TotalDeposit() {
            double initialDeposit, monthlyDeposit, yearsOfInvestment;

            // Parse input fields, use 0 if parsing fails
            if (!double.TryParse(InitialDeposit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out initialDeposit)) initialDeposit = 0;
            if (!double.TryParse(MonthlyDeposit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out monthlyDeposit)) monthlyDeposit = 0;
            if (!double.TryParse(YearsOfInvestment.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out yearsOfInvestment)) yearsOfInvestment = 0;

            double totalDeposit = (monthlyDeposit * 12 * yearsOfInvestment) + initialDeposit - monthlyDeposit;

            // Update RichTextBox content
            UpdateRichTextBox(TotalDepositTextBlock, $"Total deposit: {totalDeposit:C}");
            return totalDeposit;
        }

        private double AccumulatedInvestment() {
            // Parse inputs
            if (!double.TryParse(InitialDeposit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double initialDeposit)) initialDeposit = 0;
            if (!double.TryParse(MonthlyDeposit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double monthlyDeposit)) monthlyDeposit = 0;
            if (!double.TryParse(YearsOfInvestment.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double yearsOfInvestment)) yearsOfInvestment = 0;
            if (!double.TryParse(AnnualInterest.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double annualInterest)) annualInterest = 0;

            double r = annualInterest / 100; // Convert interest rate to double
            double totalInvestment = initialDeposit;

            for (int year = 1; year <= yearsOfInvestment; year++) {
                totalInvestment += monthlyDeposit * 12;
                totalInvestment += totalInvestment * r;
            }

            // Update RichTextBox content
            UpdateRichTextBox(AccumulatedInvestmentTextBlock, $"Accumulated investment: {totalInvestment:C2}");
            return totalInvestment;
        }

        private void Profit(double totalInvestment, double totalDeposit) {
            double profit = totalInvestment - totalDeposit;

            // Update RichTextBox content
            UpdateRichTextBox(ProfitTextBlock, $"Profit: {profit:C}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e) {
            // Reset inputs
            ResetTextBox(InitialDeposit);
            ResetTextBox(MonthlyDeposit);
            ResetTextBox(AnnualInterest);
            ResetTextBox(YearsOfInvestment);

            // Reset outputs
            ResetRichTextBox(TotalDepositTextBlock, "Total deposit: 0.00");
            ResetRichTextBox(ProfitTextBlock, "Profit: 0.00");
            ResetRichTextBox(AccumulatedInvestmentTextBlock, "Accumulated investment: 0.00"); // Corrected order
        }

        private void ResetTextBox(TextBox textBox) {
            textBox.Text = string.Empty; // Clear the text first
            AddPlaceholder(textBox, null); // Manually call AddPlaceholder to set the placeholder text and color
        }

        private void ResetRichTextBox(RichTextBox richTextBox, string defaultText) {
            if (richTextBox != null) {
                richTextBox.Document.Blocks.Clear(); // Clear previous content
                richTextBox.Document.Blocks.Add(new Paragraph(new Run(defaultText))); // Add default text
            }
        }
    }
}