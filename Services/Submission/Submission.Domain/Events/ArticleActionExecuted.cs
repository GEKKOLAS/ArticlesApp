using Submission.Domain.Entities;
using Submission.Domain.Enums;

namespace Submission.Domain.Events;

public record ArticleActionExecuted(Article Article, IArticleAction<ArticleActionType> action)
    : DomainEvent(action);