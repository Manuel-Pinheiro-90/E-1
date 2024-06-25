namespace E_1
{
    public class Program
    {

        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine($"CV DI {cv.InformazioniPersonali.Name} {cv.InformazioniPersonali.Cognome}");

            Console.WriteLine($"INFORMAZIONI PERSONALI+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Informazioni Personali:");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Name}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine($"INFORMAZIONI PERSONALI+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine($"STUDI EFFETTUATI+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (var studio in cv.StudiEffettuati)
            {

                Console.WriteLine($"Qualifica: {studio.Qualifica}");
                Console.WriteLine($"Istituto: {studio.Istituto}");
                Console.WriteLine($"Tipo: {studio.Tipo}");
                Console.WriteLine($"Dal: {studio.Dal.ToShortDateString()}");
                Console.WriteLine($"Al: {studio.Al.ToShortDateString()}");
                Console.WriteLine();
            }

            Console.WriteLine($"LAVORI PASSATI++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (var impiego in cv.Impieghi)
            {

                Console.WriteLine($"Azienda: {impiego.Esperienza.Azienda}");
                Console.WriteLine($"Job Title: {impiego.Esperienza.JobTitle}");
                Console.WriteLine($"Dal: {impiego.Esperienza.Dal.ToShortDateString()}");
                Console.WriteLine($"Al: {impiego.Esperienza.Al.ToShortDateString()}");
                Console.WriteLine($"Descrizione: {impiego.Esperienza.Descrizione}");
                Console.WriteLine($"Compiti: {impiego.Esperienza.Compiti}");
                Console.WriteLine();
            }
        }
         static void Main(string[] args)
        {


            

             CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Name = "Ivanov",
                    Cognome = "Rominsky",
                    Telefono = "123456789",
                    Email = "mario.rossi@example.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Spionaggio",
                        Istituto = "Università degli Studi di Surguth",
                        Tipo = "Laurea",
                        Dal = new DateTime(2010, 9, 1),
                        Al = new DateTime(2013, 7, 1)
                    }
                },
                Impieghi = new List<Impiego>()
            };

            mioCV.Impieghi.Add(new Impiego
            {
                Esperienza = new Esperienza
                {
                    Azienda = "Tech Company",
                    JobTitle = "Software Developer",
                    Dal = new DateTime(2014, 1, 15),
                    Al = new DateTime(2018, 12, 31),
                    Descrizione = "Sviluppo di applicazioni web",
                    Compiti = "Progettazione e implementazione di nuove funzionalità"
            }
            });

            mioCV.Impieghi.Add(new Impiego
            {
                Esperienza = new Esperienza
                {
                    Azienda = "Innovative Solutions",
                    JobTitle = "Senior Developer",
                    Dal = new DateTime(2019, 1, 1),
                    Al = DateTime.Now,
                    Descrizione = "Gestione di progetti complessi e mentoring per i nuovi assunti",
                    Compiti = "Sviluppo e ottimizzazione di sistemi software, revisione del codice e spionaggio militare"
                }
            });


            StampaDettagliCVSuSchermo(mioCV);







        }











































        }
    }

