using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public abstract class Task
    {
        private AuditTrail _AuditTrail;

        public Task()
        {
            _AuditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            _AuditTrail = auditTrail;
        }

        public void Execute()
        {
            _AuditTrail.Recrod();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
