using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DummyMVC.Data;

namespace DummyMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Offer { get; set; }
        public string Discount { get; set; }

        public string SaveProduct(ProductModel model)
        {
            string Message = "";
            mvcdemoEntities db = new mvcdemoEntities();
            var saveproduct = new tblProduct()
            {
                ProductName = model.ProductName,
                Offer = model.Offer,
                Discount = model.Discount,
            };
            db.tblProducts.Add(saveproduct);
            db.SaveChanges();
            Message = "Added Sucessfully";
            return Message;
        }


        public ProductModel DetailData(int Id)
        {
            string Message = "";
            ProductModel model = new ProductModel();
            mvcdemoEntities Db = new mvcdemoEntities();
            var editData = Db.tblProducts.Where(p => p.Id == Id).FirstOrDefault();
            if (editData != null)
            {

                model.Id = editData.Id;
                model.ProductName = editData.ProductName;
                model.Offer = editData.Offer;
                model.Discount = editData.Discount;
                
            }

            Message = "Record Edit  Successfully";
            return model;
        }


    }
}

   