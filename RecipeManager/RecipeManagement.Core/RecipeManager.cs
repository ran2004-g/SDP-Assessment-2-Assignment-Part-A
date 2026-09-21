using System;
using System.Collections.Generic;

namespace RecipeManagement.Core;

/// <summary>
/// Implement this class using the five Part A collections as private fields:
/// Dictionary&lt;int, Recipe&gt;, List&lt;string&gt;, LinkedList&lt;int&gt;,
/// Stack&lt;int&gt; and Queue&lt;string&gt;.
/// </summary>
public sealed class RecipeManager : IRecipeManager
{
    // Part A: private collection fields
    private readonly Dictionary<int, Recipe> _recipeCatalogue;
    private readonly List<string> _shoppingList;
    private readonly LinkedList<int> _cookingPlan;
    private readonly Stack<int> _removedRecipeHistory;
    private readonly Queue<string> _activeInstructions;

    public RecipeManager(IEnumerable<Recipe> recipes)
    {
        // Validate input: null recipes are not allowed
        if (recipes == null)
            throw new ArgumentNullException(nameof(recipes));

        // Initialise all collections
        _recipeCatalogue = new Dictionary<int, Recipe>();
        _shoppingList = new List<string>();
        _cookingPlan = new LinkedList<int>();
        _removedRecipeHistory = new Stack<int>();
        _activeInstructions = new Queue<string>();

        // Add recipes to the catalogue and validate duplicate IDs,
        // non-positive IDs, and blank titles
        foreach (var r in recipes)
        {
            // Reuse AddRecipe validation logic
            bool ok = AddRecipe(r);

            if (!ok)
            {
                throw new ArgumentException(
                    $"Invalid recipe id {r.Id} or duplicate / blank title");
            }
        }
    }

    // Collection count properties
    public int RecipeCount => _recipeCatalogue.Count;
    public int ShoppingItemCount => _shoppingList.Count;
    public int CookingPlanCount => _cookingPlan.Count;
    public int PendingInstructionCount => _activeInstructions.Count;
    public int RemovedRecipeCount => _removedRecipeHistory.Count;
    public bool AddRecipe(Recipe recipe) =>
        throw new NotImplementedException("Part A: implement AddRecipe.");

    public Recipe? FindRecipe(int recipeId) =>
        throw new NotImplementedException("Part A: implement FindRecipe.");

    public bool RemoveRecipe(int recipeId) =>
        throw new NotImplementedException("Part A: implement RemoveRecipe.");

    public int AddIngredientsToShoppingList(int recipeId) =>
        throw new NotImplementedException("Part A: implement AddIngredientsToShoppingList.");

    public IReadOnlyList<string> GetShoppingList() =>
        throw new NotImplementedException("Part A: implement GetShoppingList.");

    public void ClearShoppingList() =>
        throw new NotImplementedException("Part A: implement ClearShoppingList.");

    public bool AddRecipeToCookingPlan(int recipeId) =>
        throw new NotImplementedException("Part A: implement AddRecipeToCookingPlan.");

    public bool RemoveRecipeFromCookingPlan(int recipeId) =>
        throw new NotImplementedException("Part A: implement RemoveRecipeFromCookingPlan.");

    public bool RestoreLastRemovedRecipe() =>
        throw new NotImplementedException("Part A: implement RestoreLastRemovedRecipe.");

    public int? PeekLastRemovedRecipe() =>
        throw new NotImplementedException("Part A: implement PeekLastRemovedRecipe.");

    public IReadOnlyList<int> GetCookingPlan() =>
        throw new NotImplementedException("Part A: implement GetCookingPlan.");

    public bool StartCooking(int recipeId) =>
        throw new NotImplementedException("Part A: implement StartCooking.");

    public string? PeekNextInstruction() =>
        throw new NotImplementedException("Part A: implement PeekNextInstruction.");

    public string? CompleteNextInstruction() =>
        throw new NotImplementedException("Part A: implement CompleteNextInstruction.");

    public IReadOnlyList<Recipe> SearchByTitle(string searchText) =>
        throw new NotImplementedException("Part B: implement SearchByTitle.");

    public IReadOnlyList<Recipe> SearchByIngredient(string searchText) =>
        throw new NotImplementedException("Part B: implement SearchByIngredient.");

    public IReadOnlyList<Recipe> GetHighestProteinRecipes(int count) =>
        throw new NotImplementedException("Part B: implement GetHighestProteinRecipes.");

    public bool AddSavedRecipe(int recipeId) =>
        throw new NotImplementedException("Part B: implement AddSavedRecipe.");

    public bool RemoveSavedRecipe(int recipeId) =>
        throw new NotImplementedException("Part B: implement RemoveSavedRecipe.");

    public bool IsRecipeSaved(int recipeId) =>
        throw new NotImplementedException("Part B: implement IsRecipeSaved.");

    public IReadOnlyList<int> GetSavedRecipes() =>
        throw new NotImplementedException("Part B: implement GetSavedRecipes.");
}
