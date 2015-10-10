using System;
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;

namespace eRAMO.FB.Manager
{
	public class UnitOfWork : IUnitOfWork
	{
		private FBEntities _context;

		public UnitOfWork(FBEntities context)
		{
			_context = context;
		}

		//Delete this default constructor if using an IoC container
		public UnitOfWork()
		{
			_context = new FBEntities();
		}
	
			public INewsRepository News
		{
			get { return new NewsRepository(_context); }
		}

			public IClientReviewRepository ClientReview
		{
			get { return new ClientReviewRepository(_context); }
		}

			public IShareHolderRepository ShareHolder
		{
			get { return new ShareHolderRepository(_context); }
		}

			public IStudySessionRepository StudySession
		{
			get { return new StudySessionRepository(_context); }
		}

			public IReadingRepository Reading
		{
			get { return new ReadingRepository(_context); }
		}

			public ISubCategoryRepository SubCategory
		{
			get { return new SubCategoryRepository(_context); }
		}

			public IQuestionOptionRepository QuestionOption
		{
			get { return new QuestionOptionRepository(_context); }
		}

			public IQuestionRepository Question
		{
			get { return new QuestionRepository(_context); }
		}

			public ILevelRepository Level
		{
			get { return new LevelRepository(_context); }
		}

			public ISubjectRepository Subject
		{
			get { return new SubjectRepository(_context); }
		}

			public IQuestionPoolRepository QuestionPool
		{
			get { return new QuestionPoolRepository(_context); }
		}

			public ICertificateRepository Certificate
		{
			get { return new CertificateRepository(_context); }
		}

			public IQuestionInforamtionRepository QuestionInforamtion
		{
			get { return new QuestionInforamtionRepository(_context); }
		}

			public IParentTypeRepository ParentType
		{
			get { return new ParentTypeRepository(_context); }
		}

		
		public void Save()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_context != null)
				{
					_context.Dispose();
					_context = null;
				}
			}
		}
	}
}
