namespace IRPF.Lib.Files;

using System.Xml.Serialization;

/// <summary>
/// Classe root do arquivo XML 'lates.xml' localizado em:
///  http://downloadirpf.receita.fazenda.gov.br/irpf/2020/irpf/update/latest.xml
/// </summary>
[XmlRoot("information")]
public class UpdateXml
{
    public string pubDate { get; set; }
    public string pkgver { get; set; }
    public string pkgrel { get; set; }
    public string severity { get; set; }
    public string queryDate { get; set; }
    public string updateStatus { get; set; }

    public UpdateXmlExtra extra { get; set; }
}
public class UpdateXmlExtra
{
    /// <summary>
    /// Campo JSON
    /// </summary>
    public string message { get; set; }
    [XmlArrayItem("file")]
    public UpdateXmlFile[] files;
}
public class UpdateXmlFile
{
    public string fileId { get; set; }
    public string fileVersion { get; set; }
    public string fileHash { get; set; }
    public string filePath { get; set; }
    public string filePackageName { get; set; }
}