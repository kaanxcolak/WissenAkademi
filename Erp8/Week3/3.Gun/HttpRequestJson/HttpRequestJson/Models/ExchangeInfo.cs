using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestJson.Models;


public class ExchangeInfo
{
    public string Timezone { get; set; }
    public long ServerTime { get; set; }
    public object[] RateLimits { get; set; }
    public object[] ExchangeFilters { get; set; }
    public List<SymbolInfo> Symbols { get; set; } = new List<SymbolInfo>();
}
