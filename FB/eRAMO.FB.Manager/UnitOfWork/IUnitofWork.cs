            using System;

public interface IUnitOfWork : IDisposable
{
    INewsRepository News { get; }
    IClientReviewRepository ClientReview { get; }
    IShareHolderRepository ShareHolder { get; }
    IStudySessionRepository StudySession { get; }
    IReadingRepository Reading { get; }
    ISubCategoryRepository SubCategory { get; }
    IQuestionOptionRepository QuestionOption { get; }
    IQuestionRepository Question { get; }
    ILevelRepository Level { get; }
    ISubjectRepository Subject { get; }
    IQuestionPoolRepository QuestionPool { get; }
    ICertificateRepository Certificate { get; }
    IQuestionInforamtionRepository QuestionInforamtion { get; }
    IParentTypeRepository ParentType { get; }
    void Save();
}
