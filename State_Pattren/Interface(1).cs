using system;

//defines the state Interface for the document

public Interface IDocumentState
{
    void Edit(DocumentContext context,string content);
    void SubmitForReview(DocumentContext context);
    void Approve(DocumentContext context);
    void Reject(DocumentContext context);
}