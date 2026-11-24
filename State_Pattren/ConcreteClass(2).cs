using system;

//Step 2: implementing the concrete classes 

 // Ecah class handles the busines rules only for its specific state

 public class draftState : IDocumentState
 {
    public void Edit(DocumentContext context,string content)
    {
        context.Content = content;
        Console.WriteLine("Document content updated in Draft state.");
    }

    public void SubmitForReview(DocumentContext context)
    {
        context.TranstionTo(new pendingReviewState());
        Console.WriteLine("Document submitted now pending  review.");
    }

    public void Approve(DocumentContext context)
    {
        Console.WriteLine("Document cannot be approved in Draft state.submit it first");
    }

    public void Reject(DocumentContext context)
    {
        Console.WriteLine("Document cannot be rejected in Draft state.submit it first");
    }
 }       