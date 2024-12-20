using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Design_Patterns.Creational_Design_Pattern
{
    #region Product 
    //Product 
    public abstract class Document
    {
        public abstract void DocumentName();
    }

    // Concrete Product 
    public class TextDocuement : Document
    {
        public override void DocumentName()
        {
            Console.WriteLine("Text Document");
        }
    }

    // Concrete Product 
    public class PDFDocuement : Document
    {
        public override void DocumentName()
        {
            Console.WriteLine("PDF Document");
        }
    }

    #endregion

    #region Creator 

    //Creator
    public abstract class DocumentCreator
    {
        public abstract Document Document();
    }

    // Concrete Creator 
    public class TextDocuemntCreator : DocumentCreator
    {
        public override Document Document()
        {
            return new TextDocuement();
        }
    }

    // Concrete Creator 
    public class PDFDocuemntCreator : DocumentCreator
    {
        public override Document Document()
        {
            return new PDFDocuement();
        }
    }

    #endregion

    #region Client Class

    //Client class
    internal class FactoryMethod
    {
        public void MainMethod()
        {
            DocumentCreator textDocuementCreator = new TextDocuemntCreator();
            Document textDocument = textDocuementCreator.Document();

            DocumentCreator PDFDocuementCreator = new PDFDocuemntCreator();
            Document PDFDocument = PDFDocuementCreator.Document();
        }

    }

    #endregion
}
