            using System;

public interface IUnitOfWork : IDisposable
{
    IStudySessionRepository StudySessions { get; }
    IQuestionRepository Questions { get; }
    ISubjectRepository Subjects { get; }
    ICertificateRepository Certificates { get; }
    IParentTypeRepository ParentTypes { get; }
    ILevelRepository Levels { get; }
    IQuestionOptionRepository QuestionOptions { get; }
    IReadingRepository Readings { get; }
    IQuestionPoolRepository QuestionPools { get; }
    IQuestionInforamtionRepository QuestionInforamtions { get; }
    ISubCategoryRepository SubCategories { get; }
    void Save();
}
