using BigOn.WebUI.AppCode.Infrastructure;
using System;

namespace BigOn.WebUI.Models.Entites
{
    public class ContactPost : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public int? AnswerByUseeId { get; set; }
        public DateTime? AnswerDate { get; set; }

    }
}
