﻿using XamarinCRM.Models;
using XamarinCRM.Views.Products;
using Xamarin.Forms;
using XamarinCRM.Layouts;

namespace XamarinCRM.Pages.Products
{
    public class ProductDetailPage : BaseProductPage
    {
        readonly CatalogProduct _CatalogProduct;

        public ProductDetailPage(CatalogProduct catalogProduct, bool isPerformingProductSelection = false)
            : base(isPerformingProductSelection)
        {
            _CatalogProduct = catalogProduct;

            Title = catalogProduct.Name;

            #region productImage
            Image image = new Image()
            {
                Source = _CatalogProduct.ImageUrl,
                Aspect = Aspect.AspectFit
            };
            #endregion

            #region ribbonView
            ProductDetailRibbonView detailRibbon = new ProductDetailRibbonView(_CatalogProduct, isPerformingProductSelection);
            #endregion

            #region descriptionView
            ProductDetailDescriptionView descriptionView = new ProductDetailDescriptionView(_CatalogProduct);
            #endregion

            #region compose view hierarchy
            Content = new ScrollView()
            {
                Content = new UnspacedStackLayout()
                {
                    Children =
                    {
                        image, 
                        detailRibbon,
                        descriptionView
                    }
                }
            };
            #endregion
        }
    }
}

