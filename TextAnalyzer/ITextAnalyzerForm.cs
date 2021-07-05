using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public interface ITextAnalyzerForm
    {
        string Url { get; }

        string StatisticText { get; set; }

        event EventHandler textAnalizerClick;

        event EventHandler savePageClick;

        event EventHandler saveStatisticClick;

    }
}
