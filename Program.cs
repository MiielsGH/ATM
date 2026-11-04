string PIN = "1992";
string attempt = "";
int saldo = 1000000;

int tries = 3;

while (attempt != PIN && tries > 0)
{
        tries--;

    Console.Write("Enter your PIN: ");
    attempt = Console.ReadLine();

if (attempt != PIN)
    {
         Console.WriteLine($"PIN salah silahkan coba lagi.\n Sisa Percobaan: {tries}\n");
    }
}
if (tries == 0 && attempt != PIN)
{
    Console.WriteLine("You have run out of attempts.");
}
else
{
Console.WriteLine("Login Berhasil!\n");
Console.WriteLine("-------------------------------");
Console.WriteLine("Selamat datang di ATM kami!\nSilahkan pilih menu: ");
}

string[] menu = {"1. Cek Saldo", "2. Tarik Tunai", "3. Setor Tunai", "4. Keluar"};

for (int i = 0; i < menu.Length; i++)
{
    Console.WriteLine(menu[i]);
}

string menuUtama = Console.ReadLine();

switch (menuUtama)
{
    case "1":
        Console.WriteLine($"Saldo Anda: Rp {saldo} ,-");
        break;
    case "2":
        Console.Write("Masukkan jumlah penarikan: ");
        int tarik = int.Parse(Console.ReadLine());
        if (tarik > saldo)
        {
            Console.WriteLine("Saldo tidak cukup.");
        }
        else
        {
            saldo -= tarik;
            Console.WriteLine($"Penarikan berhasil. Sisa saldo: Rp {saldo} ,-");
        }
        break;
    case "3":
        Console.Write("Masukkan jumlah setoran: ");
        int setor = int.Parse(Console.ReadLine());
        saldo += setor;
        Console.WriteLine($"Setoran berhasil. Saldo baru: Rp {saldo} ,-");
        break;
    case "4":
        Console.WriteLine("Terima kasih telah menggunakan layanan kami.");
        break;
    default:
        Console.WriteLine("Menu tidak valid.");
        break;
}