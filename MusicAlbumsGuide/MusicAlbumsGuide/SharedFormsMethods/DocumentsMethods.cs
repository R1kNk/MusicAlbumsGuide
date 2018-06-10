using iTextSharp.text;
using iTextSharp.text.pdf;
using MusicAlbumsGuide.Database.Models;
using MusicAlbumsGuide.Database.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.SharedFormsMethods
{
    class DocumentsMethods
    {
        static public void NewDocument(Album currentAlbum, string path)
        {
            Document pdf = new Document(PageSize.A4, 0, 0, 0, 0);
            Document document = new Document();
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(path+"\\"+currentAlbum.Name+".pdf", FileMode.Create));
            iTextSharp.text.Rectangle one = new iTextSharp.text.Rectangle(0, 0, NumberMethods.PixelsToPdfCoords(1084), NumberMethods.PixelsToPdfCoords(600));
            one.BackgroundColor = new BaseColor(Color.FromArgb(36, 39, 47));
            document.SetPageSize(one);
            document.Open();
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ImageMethods.ConvertByteArrayToImage(currentAlbum.CoverPhoto), ImageMethods.ConvertByteArrayToImage(currentAlbum.CoverPhoto).RawFormat);
            img.ScaleAbsolute((int)NumberMethods.PixelsToPdfCoords(450), (int)NumberMethods.PixelsToPdfCoords(450));
            img.SetAbsolutePosition(0, NumberMethods.PixelsToPdfCoords(75));
            document.Add(img);
            //img added and background setted
            PdfContentByte FirstDivider = pdfWriter.DirectContent;

            FirstDivider.SetLineWidth(2.0f);  // Make a bit thicker than 1.0 default 
            FirstDivider.SetGrayStroke(1); // 1 = black, 0 = white 

            FirstDivider.MoveTo(0, (int)NumberMethods.PixelsToPdfCoords(60));
            FirstDivider.LineTo(document.PageSize.Width, (int)NumberMethods.PixelsToPdfCoords(60));
            FirstDivider.Stroke();
            //setted first divider
            PdfContentByte SecondDivider = pdfWriter.DirectContent;

            SecondDivider.SetLineWidth(2.0f);  // Make a bit thicker than 1.0 default 
            SecondDivider.SetGrayStroke(1); // 1 = black, 0 = white 
            SecondDivider.MoveTo(0, (int)NumberMethods.PixelsToPdfCoords(540));
            SecondDivider.LineTo(document.PageSize.Width, (int)NumberMethods.PixelsToPdfCoords(540));
            SecondDivider.Stroke();
            //setted second divider
            float XMultiplier = 11.17647058823529F;

            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "CENTURY.TTF");
            BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfContentByte cb = pdfWriter.DirectContent;
            cb.SetColorFill(BaseColor.WHITE);
            cb.SetFontAndSize(baseFont, 24);

            cb.BeginText();
            string text = "Информация о альбоме";
            // put the alignment and coordinates here
            cb.ShowTextAligned(0, text, (int)NumberMethods.PixelsToPdfCoords(17), (int)NumberMethods.PixelsToPdfCoords(600 - 50), 0);
            cb.EndText();
            //
            int CurrentHeight = 500;
            int CurrentWidth = 480;
            int SpaceBetween = 10;
            int SpaceHeight = 60;
            // Name
            string name = currentAlbum.Name;
            cb.SetFontAndSize(baseFont, 24);
            cb.ShowTextAligned(0, name, (int)NumberMethods.PixelsToPdfCoords(480), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.BeginText();
            cb.EndText();
            // Author
            cb.SetFontAndSize(baseFont, 18);
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            string SubName = "Автор:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            string Name = currentAlbum.Author.Name;
            float widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //Year
            cb.SetFontAndSize(baseFont, 16);
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Год выпуска:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.ReleaseYear.ToString();
            widthString = baseFont.GetWidthPoint(SubName, 16);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //Genre
            cb.SetFontAndSize(baseFont, 18);
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Жанр:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.Genre.Name;
            widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //Carrier
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Тип носителя:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.Carrier.Name;
            widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //Type
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Тип альбома:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.Type.Name;
            widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //TackCount
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Количество дорожек:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.TrackCount.ToString();
            widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            //Releasing label
            cb.SetColorFill(BaseColor.LIGHT_GRAY);
            CurrentHeight -= SpaceHeight;
            SubName = "Выпускающий лэйбл:";
            cb.ShowTextAligned(0, SubName, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth), (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            cb.SetColorFill(BaseColor.WHITE);
            Name = currentAlbum.ReleasingLabel.Name;
            widthString = baseFont.GetWidthPoint(SubName, 18);
            cb.ShowTextAligned(0, Name, (int)NumberMethods.PixelsToPdfCoords(CurrentWidth + SpaceBetween) + widthString, (int)NumberMethods.PixelsToPdfCoords(CurrentHeight), 0);
            document.Close();
        } 
    }
}
