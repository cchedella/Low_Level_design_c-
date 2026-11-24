using system;

//defines the pending state

public class pendingReviewState : IDocumentState
{
    public void Edit(DocumentContext context,string content)
    {
        Console.WriteLine("Cannot edit under the Review State");
    }

    public void SubmitForReview(DocumentContext context)
    {
        Console.WriteLine("Error: Already under review");
    }

    public void Approve(DocumentContext context)
    {
        
        Console.WriteLine("Document Approve and Locked");
    }

    public void Reject(DoucumentContext context)
    {
        context.TransitionTo(new draftState());
        Console.WriteLine("Document rejected and sent back to draft");
    }
}