using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;

namespace DocWord
{

    class DocWord
    {
        WordprocessingDocument document;
        public static DocWord CreateEx(string pathTemplate, bool isEditable = false)
        {
            if (isEditable)
            {
                return new DocWord() { document = WordprocessingDocument.Open(pathTemplate, isEditable) };
            }
            else
            {
                return new DocWord() { document = WordprocessingDocument.CreateFromTemplate(pathTemplate) };
            };
        }
        public void AddPicture(string variableName, string pathPicture, string name = "Picture 1")
        {
            SetDocVariableRun(variableName, CreateRunImage(pathPicture, name));
        }
        Run CreateRunImage(string pathPicture, string name = "Picture 1")
        {
            MainDocumentPart mainPart = document.MainDocumentPart;
            ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);
            using (FileStream stream = new FileStream(pathPicture, FileMode.Open))
            {
                imagePart.FeedData(stream);
            }
            return new Run(GetElementImage(mainPart.GetIdOfPart(imagePart), name));
        }

        Drawing GetElementImage(string relationshipId, string name)
        {
            // Define the reference of the image.
            var element =
                 new Drawing(
                     new DW.Inline(
                         new DW.Extent() { Cx = 990000L, Cy = 792000L },
                         new DW.EffectExtent()
                         {
                             LeftEdge = 0L,
                             TopEdge = 0L,
                             RightEdge = 0L,
                             BottomEdge = 0L
                         },
                         new DW.DocProperties()
                         {
                             Id = (UInt32Value)1U,
                             Name = name
                         },
                         new DW.NonVisualGraphicFrameDrawingProperties(
                             new A.GraphicFrameLocks() { NoChangeAspect = true }),
                         new A.Graphic(
                             new A.GraphicData(
                                 new PIC.Picture(
                                     new PIC.NonVisualPictureProperties(
                                         new PIC.NonVisualDrawingProperties()
                                         {
                                             Id = (UInt32Value)0U,
                                             Name = "Bitmap Image.jpg"
                                         },
                                         new PIC.NonVisualPictureDrawingProperties()),
                                     new PIC.BlipFill(
                                         new A.Blip(
                                             new A.BlipExtensionList(
                                                 new A.BlipExtension()
                                                 {
                                                     Uri =
                                                        "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                 })
                                         )
                                         {
                                             Embed = relationshipId,
                                             CompressionState =
                                             A.BlipCompressionValues.Print
                                         },
                                         new A.Stretch(
                                             new A.FillRectangle())),
                                     new PIC.ShapeProperties(
                                         new A.Transform2D(
                                             new A.Offset() { X = 0L, Y = 0L },
                                             new A.Extents() { Cx = 990000L, Cy = 792000L }),
                                         new A.PresetGeometry(
                                             new A.AdjustValueList()
                                         )
                                         { Preset = A.ShapeTypeValues.Rectangle }))
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                     )
                     {
                         DistanceFromTop = (UInt32Value)0U,
                         DistanceFromBottom = (UInt32Value)0U,
                         DistanceFromLeft = (UInt32Value)0U,
                         DistanceFromRight = (UInt32Value)0U,
                         EditId = "50D07946"
                     });
            return element;
        }

        void SetDocVariableRun(string variableName, Run run)
        {
            foreach (var field in document.MainDocumentPart.RootElement.Descendants<FieldCode>())
            {
                if (field.Text.Contains(variableName))
                {
                    field.Parent.NextSibling().InsertAfterSelf<Run>(run);
                    field.Parent.NextSibling().Remove();
                    field.Parent.PreviousSibling().Remove();
                    field.Parent.Remove();
                    break;
                }
            }
        }

        Run CreateRunText(string variableValue, string aFont = "Arial", float aFontSize = 14,
                                     bool isBold = false, bool isItalic = false, bool isUnderline = false)
        {
            RunProperties runProperties = new RunProperties();
            if (isBold) runProperties.Append(new Bold());
            if (isItalic) runProperties.Append(new Italic());
            if (isUnderline) runProperties.Append(new Underline() { Val = new EnumValue<UnderlineValues>(UnderlineValues.Single) });
            runProperties.Append(new RunFonts() { Ascii = aFont, HighAnsi = aFont });
            runProperties.Append(new FontSize() { Val = new StringValue((aFontSize * 2).ToString()) });
            Run result = new Run(new Text(variableValue));
            result.PrependChild(runProperties);
            return result;
        }

        public void SetDocVariableValue(string variableName, string variableValue,
                                        string aFont = "Arial", float aFontSize = 14,
                                        bool isBold = false, bool isItalic = false, bool isUnderline = false)
        {
            SetDocVariableRun(variableName, CreateRunText(variableValue, aFont, aFontSize, isBold, isItalic, isUnderline));
        }
        public void AddRowTable(int idx, int aCount, int idxLastRow = -1)
        {
            IEnumerable<Table> tables = document.MainDocumentPart.Document.Body.Elements<Table>();
            int i = 0;
            foreach (Table table in tables)
            {
                if (i == idx)
                {
                    TableRow row;
                    row = (idxLastRow == -1 ) ? table.Elements<TableRow>().Last() : table.Elements<TableRow>().ElementAt(idxLastRow);

                    while (aCount > 0)
                    {
                        TableRow newRow = (TableRow)row.Clone();
                        table.InsertAfter<TableRow>(newRow, row);
                        --aCount;
                    }
                    break;
                }
                else
                {
                    ++i;
                }
            }
        }

        public void Save(string path = null)
        {
            if (path == null)
            {
                document.Save();
            }
            else
            {
                document.SaveAs(path).Dispose();
            }
            document.Dispose();
        }
    }
}
