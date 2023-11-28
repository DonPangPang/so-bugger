using Newtonsoft.Json;
using SoBugger.Common.Extensions;
using SoBugger.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoBugger.Domain.Logs;

public class HistoryLog : EntityBase, ICreatored
{
    public Guid InfoId { get; set; }

    [JsonIgnore]
    public string? Data { get; private set; }

    private object? _dataObject;
    [NotMapped]
    public object? DataObject
    {
        get
        {
            _dataObject ??= Data?.GzipDecompress().ToObject<object>();

            return _dataObject;
        }
        set
        {
            _dataObject = value;
            Data = value?.ToJson().GzipCompress();
        }
    }

    public Guid CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
}
