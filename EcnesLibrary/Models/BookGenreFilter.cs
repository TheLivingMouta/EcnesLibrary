using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EcnesLibrary.Models;

    public class BookGenreFilter
    {

    public List<Books>? Books { get; set; }
    public SelectList? Genre {  get; set; }
    public string? BookGenre { get; set; }
    public string? SearchString { get; set; }

    }

