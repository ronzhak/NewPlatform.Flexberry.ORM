﻿namespace NewPlatform.Flexberry.ORM.Tests
{
    using ICSSoft.Services;
    using ICSSoft.STORMNET.Business;
    using Microsoft.Practices.Unity;
    using System.Configuration;
    using Xunit;

    /// <summary>
    /// Тестовый класс для <see cref="ConfigResolver"/>.
    /// </summary>
    public class ConfigResolverTest
    {
        /// <summary>
        /// Тест для проверки получения инстанции <see cref="ConfigResolver"/>.
        /// </summary>
        [Fact]
        public void GetConfigResolverTest()
        {
            // Arrange.
            IUnityContainer container = UnityFactory.GetContainer();

            // Act.
            IConfigResolver configResolver = container.Resolve<IConfigResolver>();
            configResolver.ResolveConnectionString("TestConnStr");

            // Assert.
            Assert.NotNull(configResolver);
        }

        /// <summary>
        /// Тест для проверки получения строки соединения по имени <see cref="ConfigResolver.ResolveConnectionString(string)"/>.
        /// </summary>
        [Fact]
        public void ResolveConnectionStringTest()
        {
            // Arrange.
            IUnityContainer container = UnityFactory.GetContainer();
            IConfigResolver configResolver = container.Resolve<IConfigResolver>();
            string connectionStringName = "TestConnStr";
            string expectedResult = ConfigurationManager.ConnectionStrings[connectionStringName].ToString();


            // Act.
            string actualResult = configResolver.ResolveConnectionString(connectionStringName);

            // Assert.
            Assert.Equal(expectedResult, actualResult);
        }
    }
}