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
    /// StoredClass.
    /// </summary>
    // *** Start programmer edit section *** (StoredClass CustomAttributes)

    // *** End programmer edit section *** (StoredClass CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class StoredClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fStoredProperty;
        
        // *** Start programmer edit section *** (StoredClass CustomMembers)

        // *** End programmer edit section *** (StoredClass CustomMembers)

        
        /// <summary>
        /// NotStoredProperty.
        /// </summary>
        // *** Start programmer edit section *** (StoredClass.NotStoredProperty CustomAttributes)

        // *** End programmer edit section *** (StoredClass.NotStoredProperty CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        public virtual string NotStoredProperty
        {
            get
            {
                // *** Start programmer edit section *** (StoredClass.NotStoredProperty Get)
                return null;
                // *** End programmer edit section *** (StoredClass.NotStoredProperty Get)
            }
            set
            {
                // *** Start programmer edit section *** (StoredClass.NotStoredProperty Set)

                // *** End programmer edit section *** (StoredClass.NotStoredProperty Set)
            }
        }
        
        /// <summary>
        /// StoredProperty.
        /// </summary>
        // *** Start programmer edit section *** (StoredClass.StoredProperty CustomAttributes)

        // *** End programmer edit section *** (StoredClass.StoredProperty CustomAttributes)
        [StrLen(255)]
        public virtual string StoredProperty
        {
            get
            {
                // *** Start programmer edit section *** (StoredClass.StoredProperty Get start)

                // *** End programmer edit section *** (StoredClass.StoredProperty Get start)
                string result = this.fStoredProperty;
                // *** Start programmer edit section *** (StoredClass.StoredProperty Get end)

                // *** End programmer edit section *** (StoredClass.StoredProperty Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (StoredClass.StoredProperty Set start)

                // *** End programmer edit section *** (StoredClass.StoredProperty Set start)
                this.fStoredProperty = value;
                // *** Start programmer edit section *** (StoredClass.StoredProperty Set end)

                // *** End programmer edit section *** (StoredClass.StoredProperty Set end)
            }
        }
    }
}
