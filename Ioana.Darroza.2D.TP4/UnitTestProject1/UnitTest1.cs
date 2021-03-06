﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstancia()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void TestPaqueteDuplicado()
        {
            Correo correo = new Correo();
            Paquete p1 = new Paquete("Av. 9 de Julio", "2181");
            Paquete p2 = new Paquete("Av. 9 de Julio", "2181");

            correo += p1;
            try
            {
                correo += p2;
            }
            catch (Exception e)
            {

            }
        }
    }
}
