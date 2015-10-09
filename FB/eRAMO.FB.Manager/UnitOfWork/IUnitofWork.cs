            using System;

public interface IUnitOfWork : IDisposable
{
    IClientReviewRepository ClientReviews { get; }
    IStudySessionRepository StudySessions { get; }
    IReadingRepository Readings { get; }
    ISubCategoryRepository SubCategorys { get; }
    IQuestionOptionRepository QuestionOptions { get; }
    IQuestionRepository Questions { get; }
    ILevelRepository Levels { get; }
    ISubjectRepository Subjects { get; }
    IQuestionPoolRepository QuestionPools { get; }
    ICertificateRepository Certificates { get; }
    IQuestionInforamtionRepository QuestionInforamtions { get; }
    IParentTypeRepository ParentTypes { get; }
    void Save();
}
