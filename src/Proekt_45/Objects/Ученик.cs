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
    /// Ученик.
    /// </summary>
    // *** Start programmer edit section *** (Ученик CustomAttributes)

    // *** End programmer edit section *** (Ученик CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("УченикE", new string[] {
            "ПриходУход as \'Приход и уход ученика\'",
            "ПриходУход.СправУч.Фио as \'Фио ученика\'",
            "ПриходУход.СправУч.КлассУч.Назв as \'Класс ученика\'",
            "ПриходУход.Расписание.Урок as \'Номер урока\'",
            "ПриходУход.Расписание.ПериодОт as \'Период От\'",
            "ПриходУход.Расписание.ПериодДо as \'Период До\'",
            "ПриходУход.Статус as \'Статус Прихода/Ухода\'",
            "ПриходУход.ВрПриУх as \'Время Прихода/Ухода\'"})]
    [MasterViewDefineAttribute("УченикE", "ПриходУход", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фио ученика")]
    public class Ученик : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Proekt_45.ПриходУход fПриходУход;
        
        private IIS.Proekt_45.Просмотр fПросмотр;
        
        // *** Start programmer edit section *** (Ученик CustomMembers)

        // *** End programmer edit section *** (Ученик CustomMembers)

        
        /// <summary>
        /// Ученик.
        /// </summary>
        // *** Start programmer edit section *** (Ученик.ПриходУход CustomAttributes)

        // *** End programmer edit section *** (Ученик.ПриходУход CustomAttributes)
        [PropertyStorage(new string[] {
                "ПриходУход"})]
        [NotNull()]
        public virtual IIS.Proekt_45.ПриходУход ПриходУход
        {
            get
            {
                // *** Start programmer edit section *** (Ученик.ПриходУход Get start)

                // *** End programmer edit section *** (Ученик.ПриходУход Get start)
                IIS.Proekt_45.ПриходУход result = this.fПриходУход;
                // *** Start programmer edit section *** (Ученик.ПриходУход Get end)

                // *** End programmer edit section *** (Ученик.ПриходУход Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ученик.ПриходУход Set start)

                // *** End programmer edit section *** (Ученик.ПриходУход Set start)
                this.fПриходУход = value;
                // *** Start programmer edit section *** (Ученик.ПриходУход Set end)

                // *** End programmer edit section *** (Ученик.ПриходУход Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Proekt_45.Просмотр.
        /// </summary>
        // *** Start programmer edit section *** (Ученик.Просмотр CustomAttributes)

        // *** End programmer edit section *** (Ученик.Просмотр CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Просмотр"})]
        public virtual IIS.Proekt_45.Просмотр Просмотр
        {
            get
            {
                // *** Start programmer edit section *** (Ученик.Просмотр Get start)

                // *** End programmer edit section *** (Ученик.Просмотр Get start)
                IIS.Proekt_45.Просмотр result = this.fПросмотр;
                // *** Start programmer edit section *** (Ученик.Просмотр Get end)

                // *** End programmer edit section *** (Ученик.Просмотр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ученик.Просмотр Set start)

                // *** End programmer edit section *** (Ученик.Просмотр Set start)
                this.fПросмотр = value;
                // *** Start programmer edit section *** (Ученик.Просмотр Set end)

                // *** End programmer edit section *** (Ученик.Просмотр Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "УченикE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View УченикE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("УченикE", typeof(IIS.Proekt_45.Ученик));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Ученик.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfУченик CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfУченик CustomAttributes)
    public class DetailArrayOfУченик : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Proekt_45.DetailArrayOfУченик members)

        // *** End programmer edit section *** (IIS.Proekt_45.DetailArrayOfУченик members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Ученик by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Ученик.
        /// </summary>
        public DetailArrayOfУченик(IIS.Proekt_45.Просмотр fПросмотр) : 
                base(typeof(Ученик), ((ICSSoft.STORMNET.DataObject)(fПросмотр)))
        {
        }
        
        public IIS.Proekt_45.Ученик this[int index]
        {
            get
            {
                return ((IIS.Proekt_45.Ученик)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Proekt_45.Ученик dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
