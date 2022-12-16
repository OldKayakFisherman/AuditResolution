using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace AuditImportService.Import.Models;

public class ImportReportedAgency
{
    [JsonProperty("AUDITYEAR")]
    public string? Audityear { get; set; }

    [JsonProperty("AGENCYCFDA")]
    public string? Agencycfda { get; set; }

    [JsonProperty("PYAGENCY")]
    public string? PyAgency { get; set; }

    [JsonProperty("PRIORFINDING")]
    public string? PriorFinding { get; set; }

    [JsonProperty("CURRENTFINDING")]
    public string? Currentfinding { get; set; }

    [JsonProperty("FINAL")]
    public string? Final { get; set; }

    [JsonProperty("VERSION")]
    public string? Version { get; set; }


}