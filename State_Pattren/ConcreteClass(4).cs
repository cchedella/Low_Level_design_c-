using system;

public class AprovedState : IDocumentState
{
    public void Edit(DocumentContext context,string content) =>
    Console.WriteLine("Error:locked annot edit in an approved state");

    public void SubmitForReview(DocumnetContext context) => Console.WriteLine("Error : Already Approved");

    public void Approve(DocumentContext context) => Console.WriteLine("Error:Already Approved");

    public void Reject(DocumentContext context) => context.TransitionTo(new draftState());
}