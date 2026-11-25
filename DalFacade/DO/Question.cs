namespace DO;


public record Question
(
int questionId,
 questionType questionType,
string? content,
int isCorect
    )
{
    public Question() : this(0, 0, null, 0) { }

}





