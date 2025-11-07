namespace IRPF.Lib.Files;

public class DEC_Ajustes
{
    public static void CorrigeChecksums(string PathArquivoDEC)
    {            
        DEC2025_Intermediate dec = DEC2025_Intermediate.FromFile(PathArquivoDEC);

        if (PathArquivoDEC.ToUpper().EndsWith(".DEC"))
        {
            //DEC_Intermediate.GravarArquivoDecEntrega(dec, PathArquivoDEC);
        }
        else
        {
            DEC2025_Intermediate.GravarArquivoDecBackup(dec, PathArquivoDEC);
        }
    }


}
