using System;

namespace _0_Framwork.Domain
{
    public class EntityBace
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public EntityBace()
        {
            CreateDate= DateTime.Now;
        }
    }
}
