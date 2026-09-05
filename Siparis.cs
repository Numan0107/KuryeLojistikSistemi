using System;

public class Siparis
{
    public int Id { get; set; }
    public string MusteriAdres { get; set; } = string.Empty;
    public string RestoranAdi { get; set; } = string.Empty;
    public decimal MesafeKm { get; set; }
    public string Durum { get; set; } = "Hazırlanıyor";
    public int? AtananKuryeId { get; set; }
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
}
