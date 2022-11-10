﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ_NHOM3_HETHONGBANGIAY.model
{
    class DetailProduct
    {
        private string idProductDetail;
        private string idProduct;
        private int size;
        private string color;
        private double priceOut;
        private double priceIn;
        private bool status;

        public string IdProductDetail { get => idProductDetail; set => idProductDetail = value; }
        public string IdProduct { get => idProduct; set => idProduct = value; }
        public int Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public double PriceOut { get => priceOut; set => priceOut = value; }
        public double PriceIn { get => priceIn; set => priceIn = value; }
        public bool Status { get => status; set => status = value; }

        public DetailProduct() { }

        public DetailProduct(string idProductDetail, string idProduct, int size, string color, double priceOut, double priceIn, bool status)
        {
            this.idProductDetail = idProductDetail;
            this.idProduct = idProduct;
            this.size = size;
            this.color = color;
            this.priceOut = priceOut;
            this.priceIn = priceIn;
            this.status = status;
        }
    }
}
