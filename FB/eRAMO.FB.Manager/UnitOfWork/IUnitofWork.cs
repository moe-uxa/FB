            using System;

public interface IUnitOfWork : IDisposable
{
    IShareHolderRepository ShareHolder { get; }
    IsysdiagramRepository sysdiagram { get; }
    ICertificateRepository Certificate { get; }
    ISubjectRepository Subject { get; }
    IQuestionPoolRepository QuestionPool { get; }
    ISubCategoryRepository SubCategory { get; }
    ILevelRepository Level { get; }
    IQuestionInforamtionRepository QuestionInforamtion { get; }
    IReadingRepository Reading { get; }
    IParentTypeRepository ParentType { get; }
    IQuestionOptionRepository QuestionOption { get; }
    IStudySessionRepository StudySession { get; }
    IQuestionRepository Question { get; }
    void Save();
}
