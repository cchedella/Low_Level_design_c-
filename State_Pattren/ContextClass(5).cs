using system;

public class DocumentContext
{
    private IDocumentState _currentState;

    //public properties representing the entity data

    public string content {set; get;}

    public DocumentContext(IDocumentState intialState)
    {
        TransitionTo(intialState);
    }
    //Methods to allow states to trigger transitions

    public void TransitionTo(IDocumentState state)
    {
        _currentState = state;
    }

    //Context delegates operations to the current state

    public void Edit(string content) => _currentState.Edit(this,content);
    public void SubmitForReview() =>_currentState.SubmitForReview(this);
    public void Approve() => _currentState.Approve(this);
    public void Reject()  =>_currentState.Reject(this);
}