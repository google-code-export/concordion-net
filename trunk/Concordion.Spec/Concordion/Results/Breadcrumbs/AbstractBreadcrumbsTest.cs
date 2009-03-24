﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concordion.Api;

namespace Concordion.Spec.Concordion.Results.Breadcrumbs
{
    abstract class AbstractBreadcrumbsTest
    {
        private TestRig testRig = new TestRig();

        protected virtual void setUpResource(string resourceName, string content) 
        {
            testRig.WithResource(new Resource(resourceName), content);
        }

        protected virtual Result getBreadcrumbsFor(string resourceName) 
        {
            var spanElements = testRig
                .Process(new Resource(resourceName))
                .GetXDocument()
                .Root
                .Descendants("span");
            
            Result result = new Result();
            foreach (var span in spanElements) 
            {
                if ("breadcrumbs".Equals(span.Attribute("class"))) 
                {
                    result.html = span.ToString();
                    result.text = span.Value;
                }
            }
            return result;
        }
    
        public class Result 
        {
            public String text = "";
            public String html = "";
        }
    }
}
