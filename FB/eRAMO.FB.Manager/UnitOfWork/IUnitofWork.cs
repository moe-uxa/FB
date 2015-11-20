            using System;

public interface IUnitOfWork : IDisposable
{
    ICEORepository CEO { get; }
    IOfferRepository Offer { get; }
    IInstructorRepository Instructor { get; }
    IPartnerRepository Partner { get; }
    IAboutHistoryRepository AboutHistory { get; }
    IStudySessionRepository StudySession { get; }
    IQuestionRepository Question { get; }
    ISubjectRepository Subject { get; }
    IParentTypeRepository ParentType { get; }
    ILevelRepository Level { get; }
    ICertificateRepository Certificate { get; }
    IQuestionOptionRepository QuestionOption { get; }
    INewsRepository News { get; }
    IShareHolderRepository ShareHolder { get; }
    IReadingRepository Reading { get; }
    IQuestionPoolRepository QuestionPool { get; }
    IQuestionInforamtionRepository QuestionInforamtion { get; }
    ISubCategoryRepository SubCategory { get; }
    IClientReviewRepository ClientReview { get; }
    void Save();
}
