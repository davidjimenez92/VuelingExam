using System.IO;
using VuelingExam.Domain.Entities;

namespace Vueling.Infrastucture.Repositories.Utilities
{
	class RepositoryUtilities
	{
		private readonly string path = null;

		public RepositoryUtilities(string path)
		{
			this.path = path;
		}

		public void CreateFile()
		{
			if (!FileExists())
				File.Create(path);
		}

		public bool FileExists()
		{
			return File.Exists(path);
		}

		public bool AppendRegister(Register model)
		{
			using (StreamWriter streamWriter = File.AppendText(path))
			{
				streamWriter.WriteLine(model.ToString());
				return true;
			}
		}
	}
}
