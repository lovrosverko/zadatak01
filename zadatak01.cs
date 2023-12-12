using System;

class KlasaC
{
	public int Zbroj(int[] niz)
	{
		int zbroj = 0;
		for (int brojac = 0; brojac < niz.Length; brojac++)
		{
			zbroj += niz[brojac];
		}

		return zbroj;
	}

	public double Prosjek(int[] niz)
	{
		int zbroj = Zbroj(niz);
		double prosjek = (double)zbroj / niz.Length;
		return prosjek;
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		int redniBroj = 1;
		int[] niz = new int[5];
		Console.WriteLine("Vježba 2 - klase i objekti\n");
		Console.WriteLine("Upiši 5 brojeva.");
		for (int brojac = 0; brojac < niz.Length; brojac++)
		{
			Console.Write(redniBroj + ". broj: ");
			niz[brojac] = Convert.ToInt32(Console.ReadLine());
			redniBroj++;
		}

		KlasaC objekt = new KlasaC();
		Console.WriteLine("Zbroj članova niza je: " + objekt.Zbroj(niz));
		Console.WriteLine("Prosjek članova niza je: " + objekt.Prosjek(niz));
	}
}