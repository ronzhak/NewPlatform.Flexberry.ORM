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
    /// Cabbage salad.
    /// </summary>
    // *** Start programmer edit section *** (CabbageSalad CustomAttributes)

    // *** End programmer edit section *** (CabbageSalad CustomAttributes)
    [AutoAltered()]
    [Caption("Cabbage salad")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("CabbageSaladE", new string[] {
            "CabbageSaladName as \'Cabbage salad name\'",
            "Cabbage2 as \'Cabbage2\'",
            "Cabbage2.Type as \'Type\'",
            "Cabbage1 as \'Cabbage1\'",
            "Cabbage1.Type as \'Type\'"})]
    [View("CabbageSaladL", new string[] {
            "CabbageSaladName as \'Cabbage salad name\'",
            "Cabbage2.Type as \'Type\'",
            "Cabbage1.Type as \'Type\'"})]
    public class CabbageSalad : ICSSoft.STORMNET.DataObject
    {
        
        private string fCabbageSaladName;
        
        private NewPlatform.Flexberry.ORM.Tests.Cabbage2 fCabbage1;
        
        private NewPlatform.Flexberry.ORM.Tests.Cabbage2 fCabbage2;
        
        // *** Start programmer edit section *** (CabbageSalad CustomMembers)

        // *** End programmer edit section *** (CabbageSalad CustomMembers)

        
        /// <summary>
        /// CabbageSaladName.
        /// </summary>
        // *** Start programmer edit section *** (CabbageSalad.CabbageSaladName CustomAttributes)

        // *** End programmer edit section *** (CabbageSalad.CabbageSaladName CustomAttributes)
        [StrLen(255)]
        public virtual string CabbageSaladName
        {
            get
            {
                // *** Start programmer edit section *** (CabbageSalad.CabbageSaladName Get start)

                // *** End programmer edit section *** (CabbageSalad.CabbageSaladName Get start)
                string result = this.fCabbageSaladName;
                // *** Start programmer edit section *** (CabbageSalad.CabbageSaladName Get end)

                // *** End programmer edit section *** (CabbageSalad.CabbageSaladName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CabbageSalad.CabbageSaladName Set start)

                // *** End programmer edit section *** (CabbageSalad.CabbageSaladName Set start)
                this.fCabbageSaladName = value;
                // *** Start programmer edit section *** (CabbageSalad.CabbageSaladName Set end)

                // *** End programmer edit section *** (CabbageSalad.CabbageSaladName Set end)
            }
        }
        
        /// <summary>
        /// Cabbage salad.
        /// </summary>
        // *** Start programmer edit section *** (CabbageSalad.Cabbage1 CustomAttributes)

        // *** End programmer edit section *** (CabbageSalad.Cabbage1 CustomAttributes)
        [PropertyStorage(new string[] {
                "Cabbage1"})]
        public virtual NewPlatform.Flexberry.ORM.Tests.Cabbage2 Cabbage1
        {
            get
            {
                // *** Start programmer edit section *** (CabbageSalad.Cabbage1 Get start)

                // *** End programmer edit section *** (CabbageSalad.Cabbage1 Get start)
                NewPlatform.Flexberry.ORM.Tests.Cabbage2 result = this.fCabbage1;
                // *** Start programmer edit section *** (CabbageSalad.Cabbage1 Get end)

                // *** End programmer edit section *** (CabbageSalad.Cabbage1 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CabbageSalad.Cabbage1 Set start)

                // *** End programmer edit section *** (CabbageSalad.Cabbage1 Set start)
                this.fCabbage1 = value;
                // *** Start programmer edit section *** (CabbageSalad.Cabbage1 Set end)

                // *** End programmer edit section *** (CabbageSalad.Cabbage1 Set end)
            }
        }
        
        /// <summary>
        /// Cabbage salad.
        /// </summary>
        // *** Start programmer edit section *** (CabbageSalad.Cabbage2 CustomAttributes)

        // *** End programmer edit section *** (CabbageSalad.Cabbage2 CustomAttributes)
        [PropertyStorage(new string[] {
                "Cabbage2"})]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ORM.Tests.Cabbage2 Cabbage2
        {
            get
            {
                // *** Start programmer edit section *** (CabbageSalad.Cabbage2 Get start)

                // *** End programmer edit section *** (CabbageSalad.Cabbage2 Get start)
                NewPlatform.Flexberry.ORM.Tests.Cabbage2 result = this.fCabbage2;
                // *** Start programmer edit section *** (CabbageSalad.Cabbage2 Get end)

                // *** End programmer edit section *** (CabbageSalad.Cabbage2 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CabbageSalad.Cabbage2 Set start)

                // *** End programmer edit section *** (CabbageSalad.Cabbage2 Set start)
                this.fCabbage2 = value;
                // *** Start programmer edit section *** (CabbageSalad.Cabbage2 Set end)

                // *** End programmer edit section *** (CabbageSalad.Cabbage2 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CabbageSaladE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CabbageSaladE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CabbageSaladE", typeof(NewPlatform.Flexberry.ORM.Tests.CabbageSalad));
                }
            }
            
            /// <summary>
            /// "CabbageSaladL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CabbageSaladL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CabbageSaladL", typeof(NewPlatform.Flexberry.ORM.Tests.CabbageSalad));
                }
            }
        }
    }
}
