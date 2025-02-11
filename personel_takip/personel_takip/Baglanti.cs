using MySql.Data.MySqlClient;
using System;
using personel_takip;

public class Baglanti
{
    private MySqlConnection baglan;

    private string connectionString = "Server=localhost; Database=personel_takip; Uid=root; Pwd=;";
    public Baglanti()
    {
        baglan = new MySqlConnection(connectionString);
    }
    public void BaglantiyiAc()
    {
        try
        {
            if (baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
                Console.WriteLine("Veritabanına bağlantı sağlandı.");
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bağlantı hatası: " + ex.Message);
        }
    }
    public void BaglantiyiKapat()
    {
        try
        {
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                baglan.Close();
                Console.WriteLine("Bağlantı kapatıldı.");
            }
        }
        catch (Exception ex)
        {

            
        }
       
    }
    // Bağlantıyı döndürme (isteğe bağlı)
    public MySqlConnection GetConnection()
    {
        return baglan;
    }
}
