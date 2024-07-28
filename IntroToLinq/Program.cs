using Linq.Data.Models;

List<Movie> GetMovies()
{
    return new List<Movie> { new Movie { Name = "Spider" }, new Movie { Name = "IronMan" } };
}



// working with linq query syntax
var movies =  GetMovies();

var linqResult = 
        from movie in movies
        where movie.Name.Contains("Spider")
        select movie;




// working with linq method / fluent sysntax

var movieList = GetMovies();

var linqResult2 = movieList.Where(movie => movie.Name.Contains("Spider")).Select(movie => movie);