﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concordion.Spec.Concordion.Command.Echo
{
    class EchoTest
    {
        private string nextResult;

        public void setNextResult(string nextResult) 
        {
            this.nextResult = nextResult;
        }

        public string render(string fragment)
        {
            return new TestRig()
                .WithStubbedEvaluationResult(nextResult)
                .ProcessFragment(fragment)
                .GetOutputFragmentXML();
        }
    }
}
