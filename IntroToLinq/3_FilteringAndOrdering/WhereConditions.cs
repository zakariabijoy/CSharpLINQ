using LINQ.Cmd;

namespace Linq.Cmd._3_FilteringAndOrdering;

public class WhereConditions : QueryRunner
{
    public override void Run()
    {
        SingleCondition_Q();
        SingleCondition_F();
    }

    /// <summary>
    /// Single condition, query syntax
    /// </summary>
    private void SingleCondition_Q()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result = 
            from movie in sourceMovies
            where movie.Name.Contains("Spider-Man")
            select movie;

        PrintAll(result);
    }
    
    /// <summary>
    /// Single condition, fluent syntax
    /// </summary>
    private void SingleCondition_F()
    {
        var sourceMovies = Repository.GetAllMovies();

        var result = sourceMovies
            .Where(movie => movie.Name.Contains("Iron"));

        PrintAll(result);
    }
    
    /// <summary>
    /// Single condition from a function, query syntax
    /// </summary>
    private void SingleFunctionCondition_Q()
    {
        var sourceMovies = Repository.GetAllMovies();
    }
    
    /// <summary>
    /// Single condition from a function, fluent syntax
    /// </summary>
    private void SingleFunctionCondition_F()
    {
        var sourceMovies = Repository.GetAllMovies();
    }
    
    /// <summary>
    /// Multiple chained conditions, query syntax
    /// </summary>
    private void MultipleConditions_Q()
    {
        var sourceMovies = Repository.GetAllMovies();
    }
    
    /// <summary>
    /// Multiple chained conditions, fluent syntax
    /// </summary>
    private void MultiplesConditions_F()
    {
        var sourceMovies = Repository.GetAllMovies();
    }
}