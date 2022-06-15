using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Name = "Eren";
musteri1.Surname = "Kara";

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Name = "Esin";
musteri2.Surname = "Kibar";

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Name = "Halit";
musteri3.Surname = "Güral";

Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

MusteriManager musteriManager = new MusteriManager();

musteriManager.Add(musteri1);
musteriManager.List(musteriler);

