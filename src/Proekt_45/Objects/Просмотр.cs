﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Proekt_45
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Просмотр.
    /// </summary>
    // *** Start programmer edit section *** (Просмотр CustomAttributes)

    // *** End programmer edit section *** (Просмотр CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПросмотрE", new string[] {
            "Время as \'Время\'",
            "СправРод as \'Фио родителя\'",
            "СправРод.Фио as \'Фио родителя\'"})]
    [AssociatedDetailViewAttribute("ПросмотрE", "Ученик", "УченикE", true, "", "Ученик", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ПросмотрE", "СправРод", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фио родителя")]
    [View("ПросмотрL", new string[] {
            "Время as \'Время\'",
            "СправРод.Фио as \'Фио ученика\'"})]
    public class Просмотр : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fВремя;
        
        private IIS.Proekt_45.СправРод fСправРод;
        
        private IIS.Proekt_45.DetailArrayOfУченик fУченик;
        
        // *** Start programmer edit section *** (Просмотр CustomMembers)

        // *** End programmer edit section *** (Просмотр CustomMembers)

        
        /// <summary>
        /// Время.
        /// </summary>
        // *** Start programmer edit section *** (Просмотр.Время CustomAttributes)

        // *** End programmer edit section *** (Просмотр.Время CustomAttributes)
        public virtual System.DateTime Время
        {
            get
            {
                // *** Start programmer edit section *** (Просмотр.Время Get start)

                // *** End programmer edit section *** (Просмотр.Время Get start)
                System.DateTime result = this.fВремя;
                // *** Start programmer edit section *** (Просмотр.Время Get end)

                // *** End programmer edit section *** (Просмотр.Время Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Просмотр.Время Set start)

                // *** End programmer edit section *** (Просмотр.Время Set start)
                this.fВремя = value;
                // *** Start programmer edit section *** (Просмотр.Время Set end)

                // *** End programmer edit section *** (Просмотр.Время Set end)
            }
        }
        
        /// <summary>
        /// Просмотр.
        /// </summary>
        // *** Start programmer edit section *** (Просмотр.СправРод CustomAttributes)

        // *** End programmer edit section *** (Просмотр.СправРод CustomAttributes)
        [PropertyStorage(new string[] {
                "СправРод"})]
        [NotNull()]
        public virtual IIS.Proekt_45.СправРод СправРод
        {
            get
            {
                // *** Start programmer edit section *** (Просмотр.СправРод Get start)

                // *** End programmer edit section *** (Просмотр.СправРод Get start)
                IIS.Proekt_45.СправРод result = this.fСправРод;
                // *** Start programmer edit section *** (Просмотр.СправРод Get end)

                // *** End programmer edit section *** (Просмотр.СправРод Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Просмотр.СправРод Set start)

                // *** End programmer edit section *** (Просмотр.СправРод Set start)
                this.fСправРод = value;
                // *** Start programmer edit section *** (Просмотр.СправРод Set end)

                // *** End programmer edit section *** (Просмотр.СправРод Set end)
            }
        }
        
        /// <summary>
        /// Просмотр.
        /// </summary>
        // *** Start programmer edit section *** (Просмотр.Ученик CustomAttributes)

        // *** End programmer edit section *** (Просмотр.Ученик CustomAttributes)
        public virtual IIS.Proekt_45.DetailArrayOfУченик Ученик
        {
            get
            {
                // *** Start programmer edit section *** (Просмотр.Ученик Get start)

                // *** End programmer edit section *** (Просмотр.Ученик Get start)
                if ((this.fУченик == null))
                {
                    this.fУченик = new IIS.Proekt_45.DetailArrayOfУченик(this);
                }
                IIS.Proekt_45.DetailArrayOfУченик result = this.fУченик;
                // *** Start programmer edit section *** (Просмотр.Ученик Get end)

                // *** End programmer edit section *** (Просмотр.Ученик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Просмотр.Ученик Set start)

                // *** End programmer edit section *** (Просмотр.Ученик Set start)
                this.fУченик = value;
                // *** Start programmer edit section *** (Просмотр.Ученик Set end)

                // *** End programmer edit section *** (Просмотр.Ученик Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПросмотрE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПросмотрE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПросмотрE", typeof(IIS.Proekt_45.Просмотр));
                }
            }
            
            /// <summary>
            /// "ПросмотрL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПросмотрL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПросмотрL", typeof(IIS.Proekt_45.Просмотр));
                }
            }
        }
    }
}
