using BooksServiceSample.Models;
using System.Collections.Generic;

namespace BooksServiceSample.Services
{
    public class SampleChapters
    {
        private readonly IBookChaptersService _bookChaptersService;
        public SampleChapters(IBookChaptersService bookChapterService)
        {
            _bookChaptersService = bookChapterService;
        }

        public void CreateSampleChapters()
        {
            var chapters = new List<BookChapter>();
            for (int i = 0; i < 9; i++)
            {
                chapters.Add(new BookChapter
                {
                    Number = _chapterNumbers[i],
                    Title = _sampleTitles[i],
                    Pages = _numberPages[i]
                });
            }
            _bookChaptersService.AddRange(chapters);
        }

        private readonly string[] _sampleTitles = new[]
        {
            ".NET Application Architectures",
            "Core C#",
            "Objects and Types",
            "Object-Oriented Programming with C#",
            "Generics",
            "Operators and Casts",
            "Arrays",
            "Delegates, Lambdas, and Events",
            "Windows Communication Foundation"
        };
        private readonly int[] _chapterNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 44 };
        private readonly int[] _numberPages = { 35, 42, 33, 20, 24, 38, 20, 32, 44 };
    }
}
