using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repository.Entities.Abstract
{
    public enum Status { Active=1,Modified=2,Passive=3}
    public abstract class BaseEntity
    {
        public abstract int Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate {get=>_createDate; set=>_createDate=value;}
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

    }
}
