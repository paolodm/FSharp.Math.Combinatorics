module CombinatoricsTests

open NUnit.Framework;
open FsUnit;
open FSharp.Math.Combinatorics

[<TestFixture>]
type ``Combinatorics tests`` ()=

    [<Test>] member test.
     ``test combinations`` ()= 
        combinations [1; 2; 3] 2 
            |> should equal [[1; 2]; [1; 3]; [2; 2]]

    [<Test>] member test.
     ``test subsets`` ()=
        subsets [1; 2; 3]
            |> should equal [[]; [1]; [2]; [3]; [1; 2]; [1; 3]; [2; 3]; [1; 2; 3]]