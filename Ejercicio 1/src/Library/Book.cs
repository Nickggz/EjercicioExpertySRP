using System;

namespace Ucu.Poo.Expert
{
    public class Book //La clase "Book"
    {

        public string Title { get ; }                           //Contiene la responsabilidad de Conocer el título del libro
        public string Author { get ; }                          // El autor del libro
        public string Code { get ;  }                            // Y el código identificador del libro
        public string LibrarySector { get ; set; }              // También tiene la responsabilidad de conocer el sector en el que se encuentra
        public string LibraryShelve { get ; set; }              // Y la estantería en la que está guardado.

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;                                   //En este caso, la Clase "Book" contiene dos razones para cambiar.
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;                        //Por lo tanto no cumpliría con SRP.
            this.LibraryShelve = shelve;
        }

    }
}
