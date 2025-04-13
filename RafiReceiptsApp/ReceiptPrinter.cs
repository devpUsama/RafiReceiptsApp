using System;
using System.Drawing;
using System.Drawing.Printing;
using RafiReceiptsApp.Models; // for Receipt

public class ReceiptPrinter
{
    private Receipt _receipt;
    private Font _printFont = new Font("Arial", 10);

    public ReceiptPrinter(Receipt receipt)
    {
        _receipt = receipt;
    }

    public void Print()
    {
        PrintDocument printDoc = new PrintDocument();
        // Optionally, set printer settings here if needed.
        printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

        // This will show the printer dialog if you wish to select printer manually.
        // PrintDialog pd = new PrintDialog();
        // pd.Document = printDoc;
        // if (pd.ShowDialog() == DialogResult.OK)
        // {
        //     printDoc.Print();
        // }

        // For simplicity, printing directly:
        printDoc.Print();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        float yPos = 10; // starting vertical position
        float pageWidth = e.PageBounds.Width;

        // Define fonts for different parts:
        Font headerFont = new Font("Arial", 20, FontStyle.Bold);             // For "RMC"
        Font labelFont = new Font("Arial", 10, FontStyle.Regular);            // For labels on left
        Font receiptTypeFont = new Font("Arial", 14, FontStyle.Bold);         // For Receipt Type and Queue Number
        Font contentBoldFont = new Font("Arial", 10, FontStyle.Bold);           // For patient name, temperature, BP, fee values

        // 1. Print the header "RMC" in bold and large font, centered.
        string headerText = "RMC";
        SizeF headerSize = g.MeasureString(headerText, headerFont);
        float xHeader = (pageWidth - headerSize.Width) / 2;
        g.DrawString(headerText, headerFont, Brushes.Black, xHeader, yPos);
        yPos += headerSize.Height + 5;

        // 2. Print Receipt ID (if available) under the header.
        // Assume _receipt.Id has the ID value.
        if (_receipt.Id != 0)
        {
            string idText = $"ID: {_receipt.Id}";
            SizeF idSize = g.MeasureString(idText, labelFont);
            float xID = (pageWidth - idSize.Width) / 2;
            g.DrawString(idText, labelFont, Brushes.Black, xID, yPos);
            yPos += idSize.Height + 10;
        }

        // 2. Draw a horizontal line.
        g.DrawLine(Pens.Black, 10, yPos, pageWidth - 10, yPos);
        yPos += 5;

        // 3. Print "Receipt Type:" on left and the value (e.g., OPD) centered.
        string labelReceiptType = "Receipt Type:";
        g.DrawString(labelReceiptType, labelFont, Brushes.Black, 10, yPos);
        string receiptTypeValue = _receipt.TokenType; // e.g., "OPD"
        SizeF receiptTypeSize = g.MeasureString(receiptTypeValue, receiptTypeFont);
        float xReceiptType = (pageWidth - receiptTypeSize.Width) / 2;
        g.DrawString(receiptTypeValue, receiptTypeFont, Brushes.Black, xReceiptType, yPos);
        yPos += Math.Max(g.MeasureString(labelReceiptType, labelFont).Height, receiptTypeSize.Height) + 5;

        // For USG receipts, print the USG type as an extra line (if available)
        if (_receipt.TokenType == "USG" && !string.IsNullOrWhiteSpace(_receipt.USGType))
        {
            string labelUsgType = "USG Type:";
            g.DrawString(labelUsgType, labelFont, Brushes.Black, 10, yPos);
            SizeF usgTypeSize = g.MeasureString(_receipt.USGType, contentBoldFont);
            float xUsgType = (pageWidth - usgTypeSize.Width) / 2;
            g.DrawString(_receipt.USGType, contentBoldFont, Brushes.Black, xUsgType, yPos);
            yPos += Math.Max(g.MeasureString(labelUsgType, labelFont).Height, usgTypeSize.Height) + 5;

        }
            // 4. Print "patient name:" on left and the patient name (in bold) centered.
            string labelPatientName = "patient name:";
            g.DrawString(labelPatientName, labelFont, Brushes.Black, 10, yPos);
            string patientNameValue = _receipt.PatientName;
            SizeF patientNameSize = g.MeasureString(patientNameValue, contentBoldFont);
            float xPatientName = (pageWidth - patientNameSize.Width) / 2;
            g.DrawString(patientNameValue, contentBoldFont, Brushes.Black, xPatientName, yPos);
            yPos += Math.Max(g.MeasureString(labelPatientName, labelFont).Height, patientNameSize.Height) + 5;

            // ----- Print Address -----
            string labelAddress = "Address:";
            g.DrawString(labelAddress, labelFont, Brushes.Black, 10, yPos);
            string addressValue = _receipt.Address; // Use the address value from your receipt object
            SizeF addressSize = g.MeasureString(addressValue, contentBoldFont);
            float xAddress = (pageWidth - addressSize.Width) / 2;
            g.DrawString(addressValue, contentBoldFont, Brushes.Black, xAddress, yPos);
            yPos += Math.Max(g.MeasureString(labelAddress, labelFont).Height, addressSize.Height) + 5;

            // 6. Print Temperature if not empty
            if (!string.IsNullOrWhiteSpace(_receipt.Temperature))
            {
                string labelTemp = "Temperature:";
                g.DrawString(labelTemp, labelFont, Brushes.Black, 10, yPos);
                SizeF tempSize = g.MeasureString(_receipt.Temperature, contentBoldFont);
                float xTemp = (pageWidth - tempSize.Width) / 2;
                g.DrawString(_receipt.Temperature, contentBoldFont, Brushes.Black, xTemp, yPos);
                yPos += Math.Max(g.MeasureString(labelTemp, labelFont).Height, tempSize.Height) + 5;
            }

            // 7. Print Blood Pressure if not empty
            if (!string.IsNullOrWhiteSpace(_receipt.BloodPressure))
            {
                string labelBP = "BP:";
                g.DrawString(labelBP, labelFont, Brushes.Black, 10, yPos);
                SizeF bpSize = g.MeasureString(_receipt.BloodPressure, contentBoldFont);
                float xBP = (pageWidth - bpSize.Width) / 2;
                g.DrawString(_receipt.BloodPressure, contentBoldFont, Brushes.Black, xBP, yPos);
                yPos += Math.Max(g.MeasureString(labelBP, labelFont).Height, bpSize.Height) + 5;
            }

        //// 7. Print the Queue Number centered in bold with the same font size as the receipt type.
        //string labelQueue = "Token No:";
        //g.DrawString(labelQueue, labelFont, Brushes.Black, 10, yPos);
        //string queueValue = _receipt.QueueNumber.ToString();
        //SizeF queueSize = g.MeasureString(queueValue, receiptTypeFont);
        //float xQueue = (pageWidth - queueSize.Width) / 2;
        //g.DrawString(queueValue, receiptTypeFont, Brushes.Black, xQueue, yPos);
        //yPos += queueSize.Height + 5;

        // Assume _receipt.TokenNumber is an integer.
        string tokenText = _receipt.TokenNumber.ToString();
        Font tokenFont = new Font("Arial", 14, FontStyle.Bold);

        // Measure the size of the token text.
        SizeF tokenSize = g.MeasureString(tokenText, tokenFont);

        // Define some padding for the box.
        float padding = 10;
        float boxWidth = tokenSize.Width + 2 * padding;
        float boxHeight = tokenSize.Height + 2 * padding;

        // Calculate x coordinate so that the box is centered.
        float xBox = (pageWidth - boxWidth) / 2;

        // Draw a dotted-line rectangle.
        using (Pen dottedPen = new Pen(Brushes.Black, 1))
        {
            dottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;  // You can also use DashDot, etc.
            g.DrawRectangle(dottedPen, xBox, yPos, boxWidth, boxHeight);
        }

        // Draw the token number inside the box, centered both horizontally and vertically.
        RectangleF tokenRect = new RectangleF(xBox, yPos, boxWidth, boxHeight);
        StringFormat centerFormat = new StringFormat();
        centerFormat.Alignment = StringAlignment.Center;
        centerFormat.LineAlignment = StringAlignment.Center;
        g.DrawString(tokenText, tokenFont, Brushes.Black, tokenRect, centerFormat);

        // Advance yPos after printing the token box.
        yPos += boxHeight + 5;


        // 8. Print "Fee:" on left and the fee value (formatted as currency, in bold) centered.
        string labelFee = "Fee:";
            g.DrawString(labelFee, labelFont, Brushes.Black, 10, yPos);
            string feeValue = _receipt.Fee.ToString("C"); // C formats as currency.
            SizeF feeSize = g.MeasureString(feeValue, contentBoldFont);
            float xFee = (pageWidth - feeSize.Width) / 2;
            g.DrawString(feeValue, contentBoldFont, Brushes.Black, xFee, yPos);
            yPos += Math.Max(g.MeasureString(labelFee, labelFont).Height, feeSize.Height) + 5;

            // ----- Print Date and Time -----
            string labelDateTime = "Date:";
            g.DrawString(labelDateTime, labelFont, Brushes.Black, 10, yPos);
            string dateTimeValue = _receipt.CreatedAt.ToString("g"); // "g" gives general date/time (short date + short time)
            SizeF dateTimeSize = g.MeasureString(dateTimeValue, contentBoldFont);
            float xDateTime = (pageWidth - dateTimeSize.Width) / 2;
            g.DrawString(dateTimeValue, contentBoldFont, Brushes.Black, xDateTime, yPos);
            yPos += Math.Max(g.MeasureString(labelDateTime, labelFont).Height, dateTimeSize.Height) + 5; // extra space at the bottom

            //Draw a horizontal line.
            g.DrawLine(Pens.Black, 10, yPos, pageWidth - 10, yPos);
            yPos += 5;

            // Indicate that this is the only page to print.
            e.HasMorePages = false;
        

    }
}
