using LINQ.Cmd;
using LINQ.Data.Models;

namespace Linq.Cmd._3_FilteringAndOrdering;

public class Ordering : QueryRunner
{
    public override void Run()
    {
        //SingleOrderBy_Q();
        //SingleOrderByDescending_Q();
        //SingleOrderBy_F();
        SingleOrderByDescending_F();
    }

    /// <summary>
    /// Single Order By , Query Syntax
    /// </summary>
    private void SingleOrderBy_Q()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result =
            from movie in sourceMovies
            orderby movie.Name
            select movie;

        PrintAll(result);
    }

    /// <summary>
    /// Single Order By Descending, Query Syntax
    /// </summary>
    private void SingleOrderByDescending_Q()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result =
            from movie in sourceMovies
            orderby movie.Name descending
            select movie;

        PrintAll(result);
    }


    /// <summary>
    /// Single Order By , Fluent Syntax
    /// </summary>
    private void SingleOrderBy_F()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result = sourceMovies
            .OrderBy(movie => movie.Name);

        PrintAll(result);
    }

    /// <summary>
    /// Single Order By Descending, Fluent Syntax
    /// </summary>
    private void SingleOrderByDescending_F()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result = sourceMovies
            .OrderByDescending(movie => movie.Name);

        PrintAll(result);
    }
}