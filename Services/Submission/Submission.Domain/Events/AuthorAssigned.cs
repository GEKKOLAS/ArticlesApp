using Submission.Domain.Entities;
using Submission.Domain.Enums;

namespace Submission.Domain.Events;

// todo - write a handler to send email to the user
public record AuthorAssigned(Author author, IArticleAction<ArticleActionType> action)
    : DomainEvent(action);