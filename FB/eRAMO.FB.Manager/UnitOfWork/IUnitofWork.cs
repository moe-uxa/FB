            using System;

public interface IUnitOfWork : IDisposable
{
    IInstructorRepository Instructor { get; }
    IOfferRepository Offer { get; }
    ISubjectRepository Subject { get; }
    INewsRepository News { get; }
    IReadingRepository Reading { get; }
    IAboutHistoryRepository AboutHistory { get; }
    ILevelRepository Level { get; }
    ICEORepository CEO { get; }
    IPartnerRepository Partner { get; }
    ICertificateRepository Certificate { get; }
    IQuestionRepository Question { get; }
    IQuestionInforamtionRepository QuestionInforamtion { get; }
    ISubCategoryRepository SubCategory { get; }
    IParentTypeRepository ParentType { get; }
    IClientReviewRepository ClientReview { get; }
    IQuestionOptionRepository QuestionOption { get; }
    IQuestionPoolRepository QuestionPool { get; }
    IStudySessionRepository StudySession { get; }
    IShareHolderRepository ShareHolder { get; }
    void Save();
}
