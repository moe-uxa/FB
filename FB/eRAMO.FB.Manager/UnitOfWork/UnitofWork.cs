using System;
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
	
			public IStudySessionRepository StudySessions
		{
			get { return new StudySessionRepository(_context); }
		}

			public IQuestionRepository Questions
		{
			get { return new QuestionRepository(_context); }
		}

			public ISubjectRepository Subjects
		{
			get { return new SubjectRepository(_context); }
		}

			public ICertificateRepository Certificates
		{
			get { return new CertificateRepository(_context); }
		}

			public IParentTypeRepository ParentTypes
		{
			get { return new ParentTypeRepository(_context); }
		}

			public ILevelRepository Levels
		{
			get { return new LevelRepository(_context); }
		}

			public IQuestionOptionRepository QuestionOptions
		{
			get { return new QuestionOptionRepository(_context); }
		}

			public IReadingRepository Readings
		{
			get { return new ReadingRepository(_context); }
		}

			public IQuestionPoolRepository QuestionPools
		{
			get { return new QuestionPoolRepository(_context); }
		}

			public IQuestionInforamtionRepository QuestionInforamtions
		{
			get { return new QuestionInforamtionRepository(_context); }
		}

			public ISubCategoryRepository SubCategories
		{
			get { return new SubCategoryRepository(_context); }
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
