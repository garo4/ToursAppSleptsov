//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToursAppSleptsov
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelImage
    {
        public int id { get; set; }
        public int hotelid { get; set; }
        public byte[] imageSource { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
