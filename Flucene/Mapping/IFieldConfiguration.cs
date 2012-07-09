﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lucene.Net.Documents;


namespace Lucene.Net.Orm.Mapping
{
    public interface IFieldConfiguration
    {
        string FieldName { get; }


        IFieldConfiguration Analyze();

        IFieldConfiguration NoNormsAnalyze();

        IFieldConfiguration NotIndex();

        IFieldConfiguration NotAnalyze();

        IFieldConfiguration NoNormsNotAnalyze();


        IFieldConfiguration Store();

        IFieldConfiguration Compress();

        IFieldConfiguration NotStore();


        IFieldConfiguration Boost(float boost);


        IEnumerable<Fieldable> GetFields(object value);
    }
}
