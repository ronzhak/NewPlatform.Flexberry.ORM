﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// TypeUsageProviderTestClass.
    /// </summary>
    // *** Start programmer edit section *** (TypeUsageProviderTestClass CustomAttributes)
    [PropertyTypeUsage("SomeNotStoredObjectProperty", new string[] { "System.String", "System.Int32" })]
    // *** End programmer edit section *** (TypeUsageProviderTestClass CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class TypeUsageProviderTestClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private NewPlatform.Flexberry.ORM.Tests.DataObjectForTest fDataObjectForTest;
        
        private NewPlatform.Flexberry.ORM.Tests.DetailArrayOfCombinedTypesUsageProviderTestClass fCombinedTypesUsageProviderTestClass;
        
        // *** Start programmer edit section *** (TypeUsageProviderTestClass CustomMembers)

        // *** End programmer edit section *** (TypeUsageProviderTestClass CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.Name Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.Name Set end)
            }
        }
        
        /// <summary>
        /// SomeNotStoredObjectProperty.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual object SomeNotStoredObjectProperty
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Get)
                return null;
                // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Get)
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Set)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.SomeNotStoredObjectProperty Set)
            }
        }
        
        /// <summary>
        /// TypeUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest CustomAttributes)
        public virtual NewPlatform.Flexberry.ORM.Tests.DataObjectForTest DataObjectForTest
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get start)
                NewPlatform.Flexberry.ORM.Tests.DataObjectForTest result = this.fDataObjectForTest;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set start)
                this.fDataObjectForTest = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.DataObjectForTest Set end)
            }
        }
        
        /// <summary>
        /// TypeUsageProviderTestClass.
        /// </summary>
        // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass CustomAttributes)

        // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass CustomAttributes)
        public virtual NewPlatform.Flexberry.ORM.Tests.DetailArrayOfCombinedTypesUsageProviderTestClass CombinedTypesUsageProviderTestClass
        {
            get
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get start)
                if ((this.fCombinedTypesUsageProviderTestClass == null))
                {
                    this.fCombinedTypesUsageProviderTestClass = new NewPlatform.Flexberry.ORM.Tests.DetailArrayOfCombinedTypesUsageProviderTestClass(this);
                }
                NewPlatform.Flexberry.ORM.Tests.DetailArrayOfCombinedTypesUsageProviderTestClass result = this.fCombinedTypesUsageProviderTestClass;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set start)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set start)
                this.fCombinedTypesUsageProviderTestClass = value;
                // *** Start programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set end)

                // *** End programmer edit section *** (TypeUsageProviderTestClass.CombinedTypesUsageProviderTestClass Set end)
            }
        }
    }
}
