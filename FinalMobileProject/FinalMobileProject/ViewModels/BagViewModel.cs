using FinalMobileProject.Models;
using FinalMobileProject.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinalMobileProject.ViewModels
{
   
    class BagViewModel
    {
        public ObservableCollection<Bags> BagList { get; set; }

        public BagViewModel()
        {
            BagList = new ObservableCollection<Bags>();
            BagList.Add(new Bags { Image = "https://www.ecobin.com.au/wp-content/uploads/2016/10/RPET-Yellow-Recycling_both2.png", Title = "Yellow Bag", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BagList.Add(new Bags { Image = "https://assets.madeinoregon.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/1/5/15584-2013.jpg", Title = "Recycle Green Bag", Price = "15", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BagList.Add(new Bags { Image = "https://i.etsystatic.com/12197109/r/il/91a97b/1234545957/il_fullxfull.1234545957_p053.jpg", Title = "Eco-Friendly Bag - White", Price = "10", Description = "Our new Ecopack Compostable Retail Bags are plastic free and certified compostable. They meet the new government legislation as they are over 70 micron in thickness. Available in small, medium and large. Size : 40cm(w) X 49cm(h)" });
            BagList.Add(new Bags { Image = "https://images-na.ssl-images-amazon.com/images/I/51cEkvlnVzL._SX425_.jpg", Title = "Compostable Punched Handle Bags", Price = "20", Description = "Take your branding to a new level with customised non-woven totes. These totes our most economical bag option for fundraising, promotional giveaways and special events. Size : 350mm(w) + 90mm(g) x 400mm(h), Minimum order quantity for custom branding is 200 pieces, No minimum order for unbranded bags, Click on request a quote for custom branding or contact us" });
            BagList.Add(new Bags { Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIFcKeM70VoNXsu9__uxkdzZ60003UlVjbiLLDPx2c3052Lay7aA", Title = "Black Reusable Bag", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BagList.Add(new Bags { Image = "https://cloversoftandco.com/wp-content/uploads/2018/04/CS-bag-1000-px.png", Title = "Bear Bag", Price = "19.99", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BagList.Add(new Bags { Image = "http://preciousthots.com/wp-content/uploads/2017/03/SG160724.jpg", Title = "Type Recycle Bag", Price = "20", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BagList.Add(new Bags { Image = "https://s3.distributorcentral.com/uploads/9/D/9DC075485C06D0159422586A5E24D9D5.png", Title = "Earth Recycle Bag", Price = "25", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });


        }

    }
}
