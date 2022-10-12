using Branches;
using System.Runtime.CompilerServices;

public class Program
{
    private static void Main(string[] args)
    {
        var program = new Program();
        var branch = program.BuildBranch();
        var depth = program.GetBranchDepth(branch, 1);

        Console.WriteLine(depth);

    }

    public int GetBranchDepth(Branch branch, int depth)
    {
        var result = depth + 1;

        foreach(var b in branch.Branches)
        {
            if(b.Branches != null)
            {
                result = Math.Max(result, GetBranchDepth(b, depth + 1));
            }
            
        }
        
        return result;

    }

    public Branch BuildBranch()
    {

        var branch = new Branch();

        var branch21 = new Branch();
        var branch22 = new Branch();
        var branch31 = new Branch();
        var branch32 = new Branch();
        var branch33 = new Branch();
        var branch34 = new Branch();
        var branch41 = new Branch();
        var branch42 = new Branch();
        var branch51 = new Branch();
        var branch52 = new Branch();
        var branch53 = new Branch();
        var branch54 = new Branch();
        var branch61 = new Branch();

        branch51.Branches = new List<Branch> { branch61 };
        branch41.Branches = new List<Branch> { branch51, branch52 };
        branch42.Branches = new List<Branch> { branch53, branch54 };
        branch34.Branches = new List<Branch> { branch41, branch42 };
        branch21.Branches = new List<Branch> { branch31, branch32 };
        branch22.Branches = new List<Branch> { branch33, branch34};
        branch.Branches = new List<Branch> { branch21, branch22 };


        return branch;
    }


}