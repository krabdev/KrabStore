﻿using System;
using System.Web;
using System.Web.Mvc;
using KrabStore.Domain.Entities;

namespace KrabStore.WebUI.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //get the cart from the session
            Cart cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            //create the cart if there was none in the session data
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }
            //return the cart
            return cart;
        }

    }
}