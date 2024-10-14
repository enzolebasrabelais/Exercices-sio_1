Module Exercice_11_3
    Const c = 300000
    Function DilatationTemps(ByVal vfusee As Double, ByVal dfusee As Double) As Double
        Return ((dfusee) / (Math.Sqrt(1 - ((vfusee ^ 2) / (c ^ 2)))))
    End Function

    Function ContractionLongueurs(ByVal vfusee As Double, ByVal tfusee As Double) As Double
        Return ((tfusee) * (Math.Sqrt(1 - ((vfusee ^ 2) / (c ^ 2)))))
    End Function

    Function LoiComposition(ByVal vfusee As Double, ByVal vobus As Double) As Double
        Return ((vobus + vfusee(())))
    End Function
End Module
