using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Transactions;

namespace GigHub.IntegrationTests
{
    public class Isolated : TestActionAttribute
    {
        private TransactionScope _transactionScope;

        public override void BeforeTest(ITest test)
        {
            _transactionScope = new TransactionScope();
            base.BeforeTest(test);
        }

        public override void AfterTest(ITest test)
        {
            _transactionScope.Dispose();
            base.AfterTest(test);
        }

        
        public ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }
    }
}
