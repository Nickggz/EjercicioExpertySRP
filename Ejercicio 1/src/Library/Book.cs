using System;

namespace Ucu.Poo.Expert
{
    public class Book //La clase "Book"
    {

        public string Title { get ; }                           //Contiene la responsabilidad de Conocer el título del libro
        public string Author { get ; }                          // El autor del libro
        public string Code { get ;  }                            // Y el código identificador del libro
        public string LibrarySector { get ; set; }              // También tiene la responsabilidad y la posibilidad de conocer y cambiar el sector de la librería en el que se encuentra
        public string LibraryShelve { get ; set; }            // Y la estantería en la que está guardado.

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;                                   //En este caso, la Clase "Book" contiene una única razón para cambiar
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;                        // Mas no una única responsabilidad
            this.LibraryShelve = shelve;                        // Bajo mi comprensión, la lase Book cumple con el principio SRP
        }                                                       // De igual manera, si queremos dividir de mejor manera las responsabilidades
                                                                // Podríamos crear otra clase que sea específicamente para almacenar
    }                                                           // y cambiar el sector de la librería y la estantería en la que se encuentra el libro
}                                                               
