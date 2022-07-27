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
        //Указываем путь к локальной базе
        string _sqlBasePath = @"A:\Projects\TestTask\TestTask\bin\Debug\data\data.db";
        //string _sqlBasePath = @"C:\Projects\TestTask-KB-AIS\TestTask\bin\Debug\data\data.db";


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
            ReaderControllerSQL sQLiteController = new ReaderControllerSQL(_sqlBasePath);
            sQLiteController.UpdateReaderImage("24", @"A:\Projects\TestTask\TestTask\bin\Debug\data\readers_img\reader_24.jpg");
        }

        [TestMethod]
        public void TestSlecerReadersLike()
        {
            //порядок
            ReaderControllerSQL sQLiteController = new ReaderControllerSQL(_sqlBasePath);
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
            ReaderControllerSQL sQLiteController = new ReaderControllerSQL(_sqlBasePath);
            sQLiteController.DeleteReader("32");
        }


        [TestMethod]
        public void TestUpdateReaderData()
        {
            //порядок
            ReaderControllerSQL sQLiteController = new ReaderControllerSQL(_sqlBasePath);
            sQLiteController.UpdateReaderData("36", "05.02.1988 0:00:00", "zxc");
        }

        [TestMethod]
        public void TestGetCategories()
        {
            //порядок
            CategoriesControllerSQL sQLiteController = new CategoriesControllerSQL(_sqlBasePath);
            List<Category> _categories = sQLiteController.GetCategories();
            foreach (var item in _categories)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n");
            //_categories = sQLiteController.GetCategories("с");
            //foreach (var item in _categories)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }


        [TestMethod]
        public void TestInsertCategory()
        {
            //порядок
            CategoriesControllerSQL sQLiteController = new CategoriesControllerSQL(_sqlBasePath);
            var _idInsertedCategory = sQLiteController.AddCategory("проверочная");
            
            Console.WriteLine("Идентификатор объекта: " + _idInsertedCategory.ToString());

        }


        [TestMethod]
        public void TestDeleteCategory()
        {
            //порядок
            CategoriesControllerSQL sQLiteController = new CategoriesControllerSQL(_sqlBasePath);
            sQLiteController.DeleteCategory("12");
        }



        [TestMethod]
        public void TestGetTagsOfBook()
        {
            //порядок
            BookCategAndTagController sQLiteController = new BookCategAndTagController(_sqlBasePath);
            List <TagToBookRef> _tagList = sQLiteController.GetTagsOfBook("1");
            foreach (TagToBookRef tag in _tagList)
            {
                Console.WriteLine(tag.TagName);
            }
        }


        [TestMethod]
        public void TestAddBook()
        {
            //порядок
            BookControllerSQL sQLiteController = new BookControllerSQL(_sqlBasePath);
            var IdAddedBook = sQLiteController.AddBook("zxc","1","1");

            Console.WriteLine(IdAddedBook.ToString());
        }

        [TestMethod]
        public void TestGetBook()
        {
            //порядок
            BookControllerSQL sQLiteController = new BookControllerSQL(_sqlBasePath);
            Book _book = sQLiteController.GetBook("5");

            Console.WriteLine(_book.Author);
        }
    }
}
