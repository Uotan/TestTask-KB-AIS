using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestTask.Controls;
using System.Drawing;
using System.Collections.Generic;
using TestTask.Models;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        string _sqlBasePath = @"A:\Projects\TestTask\TestTask\bin\Debug\data\data.db";


        [TestMethod]
        public void TestMethod1()
        {
            //юнит тест для проверки уменьшения разрешения изображения
            //тест проходит картинка уменьшается
            Image imageFile = Image.FromFile(@"A:\MyWorks\PICTURES\bodyofhate_resized.jpg");
            Bitmap bitmap = ImageResizer.ResizeImage(imageFile,512,512);
            bitmap.Save(@"resized.jpg");
        }

        [TestMethod]
        public void TestUpdateImage()
        {
            //тест проходит
            SQLiteController sQLiteController = new SQLiteController(_sqlBasePath);
            sQLiteController.UpdateReaderImage("24", @"A:\Projects\TestTask\TestTask\bin\Debug\data\readers_img\reader_24.jpg");
        }

        [TestMethod]
        public void TestSlecerReadersLike()
        {
            //порядок
            SQLiteController sQLiteController = new SQLiteController(_sqlBasePath);
            List<Reader> _listReaders = sQLiteController.GetReaders("у");
            foreach (var item in _listReaders)
            {
                Console.WriteLine(item.FullName);
            }
        }


        [TestMethod]
        public void TestDeleteReader()
        {
            //порядок
            SQLiteController sQLiteController = new SQLiteController(_sqlBasePath);
            sQLiteController.DeleteReader("32");
        }


        [TestMethod]
        public void TestUpdateReaderData()
        {
            //порядок
            SQLiteController sQLiteController = new SQLiteController(_sqlBasePath);
            sQLiteController.UpdateReaderData("36","zxc","zxc","zxc");
        }
    }
}
