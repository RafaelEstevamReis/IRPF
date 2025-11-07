namespace IRPF.Lib.Files;

public class DEC_Ajustes
{
    public static void CorrigeChecksums(string PathArquivoDEC)
    {            
        DEC_Intermediate dec = DEC_Intermediate.FromFile(PathArquivoDEC);

        if (PathArquivoDEC.ToUpper().EndsWith(".DEC"))
        {
            //DEC_Intermediate.GravarArquivoDecEntrega(dec, PathArquivoDEC);
        }
        else
        {
            DEC_Intermediate.GravarArquivoDecBackup(dec, PathArquivoDEC);
        }
    }


}
